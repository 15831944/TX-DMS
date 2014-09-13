﻿///////////////////////////////////////////////////////////////////////////////
// Copyright © 2009-2010, Open Design Alliance (the "Alliance") 
// 
// This software is owned by the Alliance, and may only be incorporated into 
// application programs owned by members of the Alliance subject to a signed 
// Membership Agreement and Supplemental Software License Agreement with the
// Alliance. The structure and organization of this software are the valuable 
// trade secrets of the Alliance and its suppliers. The software is also 
// protected by copyright law and international treaty provisions. Application 
// programs incorporating this software must include the following statement 
// with their copyright notices:
//
// Teigha™.NET for .dwg files 2009-2010 by Open Design Alliance. All rights reserved.
//
// By use of this software, you acknowledge and accept these terms.
//
//
// *DWG is the native and proprietary file format for AutoCAD® and a trademark 
// of Autodesk, Inc. The Open Design Alliance is not associated with Autodesk.
///////////////////////////////////////////////////////////////////////////////
using System;
using System.Drawing;
using System.Windows.Forms;
using ControlReport;
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
      splitContainer1.MouseWheel += Form1_MouseWheel;
      FitToWindowToolStripMenuItem.Enabled = false;
      CadLayoutModeToolStripMenuItem.Enabled = false;
      HostApplicationServices.Current = new HostAppServ(dd);
      Environment.SetEnvironmentVariable("DDPLOTSTYLEPATHS", ((HostAppServ)HostApplicationServices.Current).FindConfigPath(String.Format("PrinterStyleSheetDir")));

      gripManager = new ExGripManager();
      mouseMode = Mode.Quiescent;
      //DisableAero();
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
      int mouseX = e.X-splitContainer1.Panel1.Width;
      int mouseY = e.Y;
      if (mouseX < panel1.Left || mouseY < panel1.Top || mouseX > panel1.Right || mouseY > panel1.Bottom)
        return;

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

    public void file_open_handler(object sender, EventArgs e)
    {
      if (DialogResult.OK == openFileDialog.ShowDialog(this))
      {
        if (lm != null)
        {
          lm.LayoutSwitched -= reinitGraphDevice;
          HostApplicationServices.WorkingDatabase = null;
          lm = null;
        }

        bool bLoaded = true;
        database = new Database(false, false);
        if (openFileDialog.FilterIndex == 1)
        {
          try
          {
            database.ReadDwgFile(openFileDialog.FileName, FileOpenMode.OpenForReadAndAllShare, false, "");
          }
          catch (System.Exception ex)
          {
            MessageBox.Show(ex.Message);
            bLoaded = false;
          }
        }
        else if (openFileDialog.FilterIndex == 2)
        {
          try
          {
            database.DxfIn(openFileDialog.FileName, "");
          }
          catch (System.Exception ex)
          {
            MessageBox.Show(ex.Message);
            bLoaded = false;
          }
        }

        if (bLoaded)
        {
          HostApplicationServices.WorkingDatabase = database;
          lm = LayoutManager.Current;
          lm.LayoutSwitched += reinitGraphDevice;
          String str = HostApplicationServices.Current.FontMapFileName;

          //menuStrip.
          FitToWindowToolStripMenuItem.Enabled = true;
          CadLayoutModeToolStripMenuItem.Enabled = true;
          panel1.Enabled = true;
          Text = String.Format("外协件检验系统 - [{0}]", openFileDialog.SafeFileName);

          initializeGraphics();
          Invalidate();
          zoom_extents_handler(null, null);


          CadLayoutModeToolStripMenuItem.DropDownItems.Clear();
          using (DBDictionary layoutDict = (DBDictionary) database.LayoutDictionaryId.GetObject(OpenMode.ForRead))
          {
            foreach (DBDictionaryEntry dicEntry in layoutDict)
            {
              var layout1 = new ToolStripMenuItem {Text = dicEntry.Key};
              CadLayoutModeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
                {
                  layout1
                });
              layout1.Click += layout1_Click;
            }
          }
        }
      }
    }

    void layout1_Click(object sender, EventArgs e)
    {
      LayoutManager LayMan = LayoutManager.Current;
      LayMan.CurrentLayout = ((ToolStripMenuItem) sender).Text;
    }

    void initializeGraphics()
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
    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      DisposeResource();
    }

    private void DisposeResource()
    {
      if (selRect != null)
        helperDevice.ActiveView.Erase(selRect);
      selRect = null;

      gripManager.uninit();
      gripManager = null;
      if (graphics != null)
        graphics.Dispose();
      if (helperDevice != null)
        helperDevice.Dispose();
      if (database != null)
        database.Dispose();
      dd.Dispose();
    }
    void resize()
    {
      if (helperDevice != null)
      {
        Rectangle r = panel1.Bounds;
        r.Offset(-panel1.Location.X, -panel1.Location.Y);
        // HDC assigned to the device corresponds to the whole client area of the panel
        helperDevice.OnSize(r);
        Invalidate();
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
      if (database == null)
        return;
      using (DBObject pVpObj = Aux.active_viewport_id(database).GetObject(OpenMode.ForWrite))
      {
        // using protocol extensions we handle PS and MS viewports in the same manner
        AbstractViewportData pAVD = new AbstractViewportData(pVpObj);
        Teigha.GraphicsSystem.View pView = pAVD.GsView;
        // do actual zooming - change GS view
        zoom_extents(pView, pVpObj);
        // save changes to database
        pAVD.SetView(pView);
        pAVD.Dispose();
        pVpObj.Dispose();
        Invalidate();
      }
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
      initializeGraphics();
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

    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (database != null)
      {
        if (DialogResult.OK == saveAsFileDialog.ShowDialog(this))
        {
          database.SaveAs(saveAsFileDialog.FileName, DwgVersion.Current);
        }
      }
    }

    private void editReportToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Mediator.Mediator.Instance.NotifyColleagues(InterfaceCommand.EditReport, null);
    }

    private void executeReportToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Mediator.Mediator.Instance.NotifyColleagues(InterfaceCommand.ExecuteReport, null);
    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e)
    {
      SelectReportControl selectReportControl = new SelectReportControl();
      selectReportControl.ShowDialog(this);
    }
  }
}