using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ControlReport;
using Mediator;
using MockMeasureToolControl;
using Teigha.DatabaseServices;

namespace TxPms
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();

      this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
    }

    void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      _CadForm.Form1_FormClosing(sender,e);
    }


    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
//      if (database != null)
//      {
//        if (DialogResult.OK == saveAsFileDialog.ShowDialog(this))
//        {
//          database.SaveAs(saveAsFileDialog.FileName, DwgVersion.Current);
//        }
//      }
    }

    private void editReportToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Mediator.Mediator.Instance.NotifyColleagues(UI.EditReport, null);
    }

    private void executeReportToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Mediator.Mediator.Instance.NotifyColleagues(UI.ExecuteReport, null);
    }

    private void SelectToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SelectReportControl selectReportControl = new SelectReportControl();
      selectReportControl.ShowDialog(this);
    }

    private void NewPartStripMenuItem_Click(object sender, EventArgs e)
    {

      Mediator.Mediator.Instance.NotifyColleagues(UI.CreatePart, null);
    }

    private void measureToolToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MockMeasureToolForm frm = new MockMeasureToolForm();
      frm.Show(this);
    }

    private void BrowseReportMenuItem_Click(object sender, EventArgs e)
    {
      BrowseReportForm frm = new BrowseReportForm();
      frm.Show(this);
    }
  }
}
