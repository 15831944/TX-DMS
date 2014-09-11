using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OdViewExMgd
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
      Load += MainForm_Load;
      Resize += MainForm_SizeChanged;
      zoomFitToolStripMenuItem.Enabled = false;
    }

    void MainForm_SizeChanged(object sender, EventArgs e)
    {
      LayoutMdi(_MdiLayout);
    }

    private CadForm _CadForm;
    private ReportForm _ReportForm;
    private MdiLayout _MdiLayout = MdiLayout.TileVertical;
    void MainForm_Load(object sender, EventArgs e)
    {
      _CadForm = new CadForm();
      _CadForm.MdiParent = this;
      _CadForm.Show();

      _ReportForm = new ReportForm();
      _ReportForm.MdiParent = this;
      _ReportForm.Show();
      LayoutMdi(_MdiLayout);
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
  }
}
