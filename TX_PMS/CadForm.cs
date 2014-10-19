using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Core.Service;
using Dwglib;
using Dwglib.GripPoints;
using Mediator;
using Teigha.DatabaseServices;
using Teigha.GraphicsSystem;
using Teigha.Runtime;
using Teigha.GraphicsInterface;
using Teigha.Geometry;
using System.Runtime.InteropServices;

namespace TxPms
{
  public partial class CadForm : Form
  {
    enum Mode
    {
      Quiescent,
      Selection,
      DragDrop
    }
    private bool _IsMoving;
    Services dd;
    Graphics graphics;
    LayoutHelperDevice helperDevice;
    Database database = null;
    ObjectIdCollection selected = new ObjectIdCollection();
    Point2d startSelPoint;
    Point3d firstCornerPoint;

    LayoutManager lm;
    RectFram selRect;
    ExGripManager gripManager;
    Mode mouseMode;
    int bZoomWindow = -1;

    [DllImport("dwmapi.dll", EntryPoint = "DwmEnableComposition")]
    protected extern static uint Win32DwmEnableComposition(uint uCompositionAction);

    void DisableAero()
    {
      Win32DwmEnableComposition((uint)0);
    }

    public CadForm()
    {
      dd = new Services();
      SystemObjects.DynamicLinker.LoadApp("GripPoints", false, false);
      SystemObjects.DynamicLinker.LoadApp("PlotSettingsValidator", false, false);
      InitializeComponent();
      this.MouseWheel += Form1_MouseWheel;
      HostApplicationServices.Current = new HostAppServ(dd);
      Environment.SetEnvironmentVariable("DDPLOTSTYLEPATHS", ((HostAppServ)HostApplicationServices.Current).FindConfigPath(String.Format("PrinterStyleSheetDir")));
      
      gripManager = new ExGripManager();
      mouseMode = Mode.Quiescent;
      //DisableAero();
      Initialize();
    }

    // helper function transforming parameters from screen to world coordinates
    void dolly(Teigha.GraphicsSystem.View pView, int x, int y) 
    {
      Vector3d vec = new Vector3d(-x, -y, 0.0);
      vec = vec.TransformBy((pView.ScreenMatrix * pView.ProjectionMatrix).Inverse());
      pView.Dolly(vec);
    }
    void Form1_MouseWheel(object sender, MouseEventArgs e)
    {
      if (helperDevice == null)
        return;
      int mouseX = e.X;// -splitContainer1.Panel1.Width;
      int mouseY = e.Y;
      //if (mouseX < panel1.Left || mouseY < panel1.Top || mouseX > panel1.Right || mouseY > panel1.Bottom)
     //   return;

      //Debug.WriteLine(string.Format("mouse location in panel coordinates x:{0}, y{1}",p.X,p.Y));
      using (Teigha.GraphicsSystem.View pView = helperDevice.ActiveView)
      {
        // camera position in world coordinates
        Point3d pos = pView.Position;
        // TransformBy() returns a transformed copy
        pos = pos.TransformBy(pView.WorldToDeviceMatrix);
        int vx = (int)pos.X;
        int vy = (int)pos.Y;
        vx = mouseX - vx;
        vy = mouseY - vy;
        // we move point of view to the mouse location, to create an illusion of scrolling in/out there
        dolly(pView, -vx, -vy);
        // note that we essentially ignore delta value (sign is enough for illustrative purposes)
        pView.Zoom(e.Delta > 0 ? 1.0 / 0.9 : 0.9);
        dolly(pView, vx, vy);
        //
        Invalidate();
      }
    }

    public void file_open_handler(object i_O)
    {
      if (DialogResult.OK == openFileDialog.ShowDialog(this))
      {
        OpenDwgFile(openFileDialog.FileName);
//        if (!panelGraphicContainer.Controls.Contains(panel1))
//          panelGraphicContainer.Controls.Add(panel1);
      }
      this.Show();
    }

    private void OpenDwgFile(string i_Path)
    {
      if (lm != null)
      {
        lm.LayoutSwitched -= reinitGraphDevice;
        HostApplicationServices.WorkingDatabase = null;
        lm = null;
      }

      bool bLoaded = true;
      database = new Database(false, false);
      try
      {
        database.ReadDwgFile(i_Path, FileOpenMode.OpenForReadAndAllShare, false, "");
      }
      catch (System.Exception ex)
      {
        MessageBox.Show(ex.Message);
        bLoaded = false;
      }
     
      if (bLoaded)
      {
        HostApplicationServices.WorkingDatabase = database;
        lm = LayoutManager.Current;
        lm.LayoutSwitched += reinitGraphDevice;
        String str = HostApplicationServices.Current.FontMapFileName;

        panel1.Enabled = true;
        Text = String.Format("外协件检验系统 - [{0}]",
                             PmsService.Instance.CurrentTemplate == null ? "" : PmsService.Instance.CurrentTemplate.Name);

        InitializeGraphics();
        Mediator.Mediator.Instance.NotifyColleagues(Cad.OnOpened, database);
        ThreadPool.QueueUserWorkItem(delegate { CadSelectionManager.Instance.Initialize(database); });
        UpdateCadAsync(1000);
      }
    }
    public delegate void VoidDelegate2(int i_Delayed);


    public void SetLayout(string i_LayoutString)
    {
      LayoutManager LayMan = LayoutManager.Current;
      LayMan.CurrentLayout = i_LayoutString;
    }

    void InitializeGraphics()
    {
      try
      {
        graphics = Graphics.FromHwnd(panel1.Handle);
        // load some predefined rendering module (may be also "WinDirectX" or "WinOpenGL")
        using (GsModule gsModule = (GsModule)SystemObjects.DynamicLinker.LoadModule("WinGDI.txv", false, true))
        {
          // create graphics device
          using (Device graphichsDevice = gsModule.CreateDevice())
          {
            // setup device properties
            using (Dictionary props = graphichsDevice.Properties)
            {
              if (props.Contains("WindowHWND")) // Check if property is supported
                props.AtPut("WindowHWND", new RxVariant((Int32)panel1.Handle)); // hWnd necessary for DirectX device
              if (props.Contains("WindowHDC")) // Check if property is supported
                props.AtPut("WindowHDC", new RxVariant(graphics.GetHdc())); // hWindowDC necessary for Bitmap device
              if (props.Contains("DoubleBufferEnabled")) // Check if property is supported
                props.AtPut("DoubleBufferEnabled", new RxVariant(true));
              if (props.Contains("EnableSoftwareHLR")) // Check if property is supported
                props.AtPut("EnableSoftwareHLR", new RxVariant(true));
              if (props.Contains("DiscardBackFaces")) // Check if property is supported
                props.AtPut("DiscardBackFaces", new RxVariant(true));
            }
            // setup paperspace viewports or tiles
            ContextForDbDatabase ctx = new ContextForDbDatabase(database);
            ctx.UseGsModel = true;

            helperDevice = LayoutHelperDevice.SetupActiveLayoutViews(graphichsDevice, ctx);
            Aux.preparePlotstyles(database, ctx);
            gripManager.init(helperDevice, helperDevice.Model, database);
            //helperDevice.ActiveView.Mode = Teigha.GraphicsSystem.RenderMode.HiddenLine;
          }
        }
        // set palette
        helperDevice.SetLogicalPalette(Device.DarkPalette);
        // set output extents
        resize();


        helperDevice.Model.Invalidate(InvalidationHint.kInvalidateAll);
      }
      catch (System.Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
    }
    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      if (helperDevice != null)
      {
        try
        {
          helperDevice.Update();
        }
        catch (System.Exception ex)
        {
          graphics.DrawString(ex.ToString(), new Font("Arial", 16), new SolidBrush(Color.Black), new PointF(150.0F, 150.0F));
        }
      }
    }
    public void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      DisposeResource();
    }

    private void DisposeResource()
    {

      if (selRect != null)
        helperDevice.ActiveView.Erase(selRect);
      selRect = null;

      if (gripManager != null)
        gripManager.uninit();
      gripManager = null;
      if (graphics != null)
        graphics.Dispose();
      graphics = null;
      if (helperDevice != null)
        helperDevice.Dispose();
      helperDevice = null;
      if (database != null)
        database.Dispose();
      database = null;
      if (dd != null)
        dd.Dispose();
      dd = null;
    }

    void resize()
    {
      if (helperDevice != null)
      {
        Rectangle r = panel1.Bounds;

          r.Offset(-panel1.Location.X, -panel1.Location.Y);
          // HDC assigned to the device corresponds to the whole client area of the panel
        if (r.Height > 0 && r.Width > 0)
        {
          helperDevice.OnSize(r);
         UpdateCadAsync(500);
        }
      }
    }
    private void panel1_Resize(object sender, EventArgs e)
    {
      resize();
    }
    bool get_layout_extents(Database db, Teigha.GraphicsSystem.View pView, ref BoundBlock3d bbox)
    {
      BlockTable bt = (BlockTable)db.BlockTableId.GetObject(OpenMode.ForRead);
      BlockTableRecord pSpace = (BlockTableRecord)bt[BlockTableRecord.PaperSpace].GetObject(OpenMode.ForRead);
      Layout pLayout = (Layout)pSpace.LayoutId.GetObject(OpenMode.ForRead);
      Extents3d ext = new Extents3d();
      if (pLayout.GetViewports().Count > 0)
      {
        bool bOverall = true;
        foreach (ObjectId id in pLayout.GetViewports())
        {
          if (bOverall)
          {
            bOverall = false;
            continue;
          }
          Teigha.DatabaseServices.Viewport pVp = (Teigha.DatabaseServices.Viewport)id.GetObject(OpenMode.ForRead);
        }
        ext.TransformBy(pView.ViewingMatrix);
        bbox.Set(ext.MinPoint, ext.MaxPoint);
      }
      else
      {
        ext = pLayout.Extents;
      }
      bbox.Set(ext.MinPoint, ext.MaxPoint);
      return ext.MinPoint != ext.MaxPoint;
    }
    void zoom_extents(Teigha.GraphicsSystem.View pView, DBObject pVpObj)
    {
      // here protocol extension is used again, that provides some helpful functions
      using (AbstractViewPE pVpPE = new AbstractViewPE(pView))
      {
        BoundBlock3d bbox = new BoundBlock3d();
        bool bBboxValid = pVpPE.GetViewExtents(bbox);

        // paper space overall view
        if (pVpObj is Teigha.DatabaseServices.Viewport && ((Teigha.DatabaseServices.Viewport)pVpObj).Number == 1)
        {
          if (!bBboxValid || !(bbox.GetMinimumPoint().X < bbox.GetMaximumPoint().X && bbox.GetMinimumPoint().Y < bbox.GetMaximumPoint().Y))
          {
            bBboxValid = get_layout_extents(database, pView, ref bbox);
          }
        }
        else if (!bBboxValid) // model space viewport
        {
          bBboxValid = get_layout_extents(database, pView, ref bbox);
        }

        if (!bBboxValid)
        {
          // set to somewhat reasonable (e.g. paper size)
          if (database.Measurement == MeasurementValue.Metric)
          {
            bbox.Set(Point3d.Origin, new Point3d(297.0, 210.0, 0.0)); // set to papersize ISO A4 (portrait)
          }
          else
          {
            bbox.Set(Point3d.Origin, new Point3d(11.0, 8.5, 0.0)); // ANSI A (8.50 x 11.00) (landscape)
          }
          bbox.TransformBy(pView.ViewingMatrix);
        }

        pVpPE.ZoomExtents(bbox);
      }
    }
    // the same as Editor.ActiveViewportId if ApplicationServices are available

    public void zoom_extents_handler(object sender, EventArgs e)
    {

    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      switch (e.KeyCode)
      {
        case Keys.Escape:
          switch (mouseMode)
          {
            case Mode.DragDrop:
              {
                using (Teigha.GraphicsSystem.View pView = helperDevice.ActiveView)
                {
                  gripManager.DragFinal(new Point3d(), false);
                  helperDevice.Model.Invalidate(InvalidationHint.kInvalidateAll);
                  Invalidate();
                }
                break;
              }
            case Mode.Selection:
              if (selRect != null)
              {
                using (Teigha.GraphicsSystem.View pView = helperDevice.ActiveView)
                {
                  pView.Erase(selRect);
                  selRect = null;
                }
              }
              break;
          }
          mouseMode = Mode.Quiescent;

          ClearSelection();
          break;
        case Keys.Oemplus:
          break;
        case Keys.OemMinus:
          break;
      }
    }

    private void ClearSelection()
    {
      foreach (ObjectId id in selected)
      {
        gripManager.removeEntityGrips(id, true);
      }
      selected.Clear();
      if (helperDevice != null)
        helperDevice.Invalidate();
      Invalidate();
    }

    private void reinitGraphDevice(object sender, Teigha.DatabaseServices.LayoutEventArgs e)
    {
      helperDevice.Dispose();
      graphics.Dispose();
      InitializeGraphics();
    }


    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
      if (_IsMoving)
      {
        using (Teigha.GraphicsSystem.View pView = helperDevice.ActiveView)
        {
          int vx = e.X;
          int vy = e.Y;
          vx = (int)startSelPoint.X- vx;
          vy = (int)startSelPoint.Y - vy;
          // we move point of view to the mouse location, to create an illusion of scrolling in/out there
          dolly(pView, -vx, -vy);
          startSelPoint = new Point2d(e.X,e.Y);
          Invalidate();
        }
      }
    }

    private int _SelectRegion = 20;
    private void Form1_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        using (Teigha.GraphicsSystem.View pView = helperDevice.ActiveView)
        {
          ClearSelection();
          selRect = new RectFram(toEyeToWorld(e.X, e.Y));
          pView.Add(selRect);
          startSelPoint = new Point2d(e.X, e.Y);
          Invalidate();
          selRect.setValue(toEyeToWorld(e.X + _SelectRegion, e.Y + _SelectRegion));
          pView.Select(new Point2dCollection(new Point2d[] {startSelPoint, new Point2d(e.X + _SelectRegion, e.Y + _SelectRegion)}),
                       new SR(selected, database.CurrentSpaceId), startSelPoint.X < e.X ? Teigha.GraphicsSystem.SelectionMode.Window : Teigha.GraphicsSystem.SelectionMode.Crossing);
          pView.Erase(selRect);
          selRect = null;
          gripManager.updateSelection(selected);
          helperDevice.Invalidate();
          Invalidate();
        }
      }
      else if(e.Button == MouseButtons.Right)
      {
        _IsMoving = true;
        startSelPoint = new Point2d(e.X, e.Y);
      }
    }

    private void Form1_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        _IsMoving = false;
      }
      if (helperDevice != null && bZoomWindow == -1)
      {
        ;
      }
    }


    private Point3d toEyeToWorld(int x, int y)
    {
      using (Teigha.GraphicsSystem.View pView = helperDevice.ActiveView)
      {
        Point3d wcsPt = new Point3d(x, y, 0.0);
        wcsPt = wcsPt.TransformBy((pView.ScreenMatrix * pView.ProjectionMatrix).Inverse());
        wcsPt = new Point3d(wcsPt.X, wcsPt.Y, 0.0);
        using (AbstractViewPE pVpPE = new AbstractViewPE(pView))
        {
          return wcsPt.TransformBy(pVpPE.EyeToWorld);
        }
      }
    }

    private void ZoomWindow(Point3d pt1, Point3d pt2)
    {
      using (Teigha.GraphicsSystem.View pView = helperDevice.ActiveView)
      {
        using (AbstractViewPE pVpPE = new AbstractViewPE(pView))
        {
          pt1 = pt1.TransformBy(pVpPE.WorldToEye);
          pt2 = pt2.TransformBy(pVpPE.WorldToEye);
          Vector3d eyeVec = pt2 - pt1;

          if (((eyeVec.X < -1E-10) || (eyeVec.X > 1E-10)) && ((eyeVec.Y < -1E-10) || (eyeVec.Y > 1E-10)))
          {
            Point3d newPos = pt1 + eyeVec / 2.0;
            pView.Dolly(newPos.GetAsVector());
            double wf = pView.FieldWidth / Math.Abs(eyeVec.X);
            double hf = pView.FieldHeight / Math.Abs(eyeVec.Y);
            pView.Zoom(wf < hf ? wf : hf);
            Invalidate();
          }
        }
      }
    }

    private void panel1_MouseClick(object sender, MouseEventArgs e)
    {
      panel1.Focus();
      if (bZoomWindow > -1 && bZoomWindow < 2)
      {
        if (bZoomWindow == 1)
        {
          bZoomWindow = -1;
          ZoomWindow(firstCornerPoint, toEyeToWorld(e.X, e.Y));
        }
        if (bZoomWindow == 0)
        {
          firstCornerPoint = toEyeToWorld(e.X, e.Y);
          bZoomWindow = 1;
        }
      }
    }

    private void CadForm_SizeChanged(object sender, EventArgs e)
    {

      Mediator.Mediator.Instance.NotifyColleaguesAsync(UI.Resize, null);
    }
  }
}