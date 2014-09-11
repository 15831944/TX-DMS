using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TxPms
{
  public partial class MainForm : Form,  ResizeListener
  {
    public MainForm()
    {
      InitializeComponent();
      Load += MainForm_Load;
      Resize += MainForm_SizeChanged;
      zoomFitToolStripMenuItem.Enabled = false;
      this.MouseMove += new MouseEventHandler(MainForm_MouseMove);
    }

    void MainForm_MouseMove(object sender, MouseEventArgs e)
    {
      Debug.WriteLine(string.Format("Mouse:X{0}; Y{1}",e.X,e.Y));
    }

    void MainForm_SizeChanged(object sender, EventArgs e)
    {
      LayoutMdi(_MdiLayout);
    }

    private CadForm _CadForm;
    private ReportForm _ReportForm;
    private MdiLayout _MdiLayout = MdiLayout.TileVertical;
    private const string Cad = "Cad";
    private const string Report = "Report";
    void MainForm_Load(object sender, EventArgs e)
    {
      _ReportForm = new ReportForm(this, Report);
      _ReportForm.MdiParent = this;
      _ReportForm.Show();

      _CadForm = new CadForm(this, Cad);
      _CadForm.MdiParent = this;
      _CadForm.Show();


      MainForm_SizeChanged(null, null);
    }
    
    private void cadWindowToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (_CadForm != null)
      {
        _CadForm.file_open_handler(null, null);
        zoomFitToolStripMenuItem.Enabled = true;
      }
    }

    private void zoomFitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (_CadForm != null)
      {
        _CadForm.zoom_extents_handler();
      }
    }

    private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      _MdiLayout = MdiLayout.TileHorizontal;
      LayoutMdi(MdiLayout.TileHorizontal);
    }

    private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      _MdiLayout = MdiLayout.TileVertical;
      LayoutMdi(_MdiLayout);
    }

    public void OnResize(ResizeArgs i_ResizeArgs)
    {
//      if (_MdiLayout == MdiLayout.TileHorizontal)
//      {
//        if (i_ResizeArgs.FormName == Report)
//        {
//          _CadForm.Top = i_ResizeArgs.Botton;
//        }
//        else
//        {
//         _ReportForm.Height = i_ResizeArgs.Top;
//        }
//      }
//      else
//      {
//        if (i_ResizeArgs.FormName == Report)
//        {
//          _CadForm.Left = i_ResizeArgs.Right;
//        }
//        else
//        {
//          _ReportForm.Width = i_ResizeArgs.Left;
//        }
//      }
    }
  }
}
