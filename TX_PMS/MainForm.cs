using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ControlReport;
using Core.Service;
using Mediator;
using MockMeasureToolControl;
using Qios.DevSuite.Components;
using Qios.DevSuite.Components.Ribbon;
using Teigha.DatabaseServices;

namespace TxPms
{
  public partial class MainForm : QRibbonForm  
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
      Mediator.Mediator.Instance.Register(UI.Resize,i_O => this.BeginInvoke(new VoidDelegate(Invalidate),true));
      Mediator.Mediator.Instance.Register(App.ExecutionProgress,i_O =>
        {
          toolStripStatusLabelTaskExecution.Text = string.Format("检验进度：{0}",i_O.ToString());
        });
    }

    public  delegate void VoidDelegate(bool i_B);
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



    private void qRibbonItemMockTool_ItemActivated(object sender, QCompositeEventArgs e)
    {
      MockMeasureToolForm frm = new MockMeasureToolForm();
      frm.Show(this);
    }

    private void qRibbonItemOpenPart_ItemActivated(object sender, QCompositeEventArgs e)
    {
      SelectReportControl selectReportControl = new SelectReportControl();
      selectReportControl.ShowDialog(this);
    }

    private void qRibbonItemExecutePart_ItemActivated(object sender, QCompositeEventArgs e)
    {
      Mediator.Mediator.Instance.NotifyColleagues(UI.ExecuteReport, null);
    }

    private void qRibbonItemEditPart_ItemActivated(object sender, QCompositeEventArgs e)
    {
      Mediator.Mediator.Instance.NotifyColleagues(UI.EditReport, null);
    }

    private void qRibbonItemNewPart_ItemActivated(object sender, QCompositeEventArgs e)
    {
      Mediator.Mediator.Instance.NotifyColleagues(UI.CreatePart, null);
    }

    private void qRibbonItemNewTask_ItemActivated(object sender, QCompositeEventArgs e)
    {
      TaskForm taskForm = new TaskForm();
      taskForm.ShowDialog(this);
    }

    private void qRibbonItemExecuteTask_ItemActivated(object sender, QCompositeEventArgs e)
    {
      var tasks = PmsService.Instance.GetTasks();
      if(tasks.Count==0) return;

      Mediator.Mediator.Instance.NotifyColleagues(UI.SelectTask, tasks[tasks.Count-1]);
    }
  }
}
