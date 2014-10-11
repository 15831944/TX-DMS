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
using Qios.DevSuite.Components;
using Qios.DevSuite.Components.Ribbon;
using Teigha.DatabaseServices;

namespace TxPms
{
  public partial class MainForm : Form
  {
    private CadForm _CadForm  = new CadForm();
    public MainForm()
    {
      InitializeComponent();
      _CadForm.MdiParent = this;
      _CadForm.WindowState = FormWindowState.Maximized;
      _CadForm.ControlBox = false;
      _CadForm.Show();
      DockReportControl();
      this.FormClosing += MainForm_FormClosing;
      Mediator.Mediator.Instance.Register(Cad.OnOpened, OnCadOpened);

    }

    void DockReportControl()
    {
      BrowseReportForm tmp_oTasks = new BrowseReportForm();
      tmp_oTasks.Owner = this;
      tmp_oTasks.Closing += new CancelEventHandler(Tasks_Closing);
      tmp_oTasks.DockWindow(this.qDockBarBottom);
      tmp_oTasks.SlideWindow(true,false);
     
      PartForm partForm = new PartForm();
      partForm.Owner = this;
      partForm.DockWindow(this.qDockBarRight);

    }
    private void Tasks_Closing(object sender, CancelEventArgs e)
    {
      //allow the user to cancel the closing of forms
      //e.Cancel = (MessageBox.Show("Do you want to close " + ((Control)sender).Text + "?", "Closing...", MessageBoxButtons.OKCancel) == DialogResult.Cancel);
    }

    private void OnCadOpened(object i_Obj)
    {
      Database database = i_Obj as Database;
      if(database==null) return;

      using (DBDictionary layoutDict = (DBDictionary)database.LayoutDictionaryId.GetObject(OpenMode.ForRead))
      {
//        qCadToolBar.Controls.Clear();
//        foreach (DBDictionaryEntry dicEntry in layoutDict)
//        {
//
//          //var layout1 = new ToolStripMenuItem {Text = dicEntry.Key};
//          //            CadLayoutModeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
//          //              {
//          //                layout1
//          //              });
//          //layout1.Click += layout1_Click;
//          qCadToolBar.ToolItems.Add(new QToolItem(dicEntry.Key));
//
//        }
      }
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



    private void BrowseReportMenuItem_Click(object sender, EventArgs e)
    {
      BrowseReportForm frm = new BrowseReportForm();
      //frm.Show(this);
    }

    private void qCompositeMenuItem1_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
    {

    }

    private void qRibbonItem4_ItemActivated(object sender, QCompositeEventArgs e)
    {
      MockMeasureToolForm frm = new MockMeasureToolForm();
      frm.Show(this);
    }

    private void qRibbonItemOpen_ItemActivated(object sender, QCompositeEventArgs e)
    {
      SelectReportControl selectReportControl = new SelectReportControl();
      selectReportControl.ShowDialog(this);
    }

    private void qRibbonItemExecute_ItemActivated(object sender, QCompositeEventArgs e)
    {
      Mediator.Mediator.Instance.NotifyColleagues(UI.ExecuteReport, null);
    }

    private void qRibbonItemEdit_ItemActivated(object sender, QCompositeEventArgs e)
    {
      Mediator.Mediator.Instance.NotifyColleagues(UI.EditReport, null);
    }

    private void qRibbonItemNew_ItemActivated(object sender, QCompositeEventArgs e)
    {
      Mediator.Mediator.Instance.NotifyColleagues(UI.CreatePart, null);
    }
  }
}
