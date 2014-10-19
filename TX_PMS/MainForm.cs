using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
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
    public delegate void MessageHanlderDelegate(object i_B);
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
      Mediator.Mediator.Instance.Register(Cad.OnOpened, i_O => BeginInvoke(new MessageHanlderDelegate(OnCadOpened), i_O));
      Mediator.Mediator.Instance.Register(App.ExecutionProgress,i_O =>
        {
          toolStripStatusLabelTaskExecution.Text = string.Format("检验进度：{0}",i_O.ToString());
        });
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
        qRibbonPageWindow.Items.Clear();
        var ribbinPanel = new QRibbonPanel();
        qRibbonPageWindow.Items.Add(ribbinPanel);
        foreach (DBDictionaryEntry dicEntry in layoutDict)
        {
          var oneItem = new QRibbonItem();
          oneItem.Title = dicEntry.Key;
          oneItem.Configuration.IconConfiguration.IconSize=new Size(32,32);
          ribbinPanel.Items.Add(oneItem);
          oneItem.ItemActivated += oneItem_ItemActivated;
        }
      }
    }

    void oneItem_ItemActivated(object sender, QCompositeEventArgs e)
    {
      LayoutManager LayMan = LayoutManager.Current;
      LayMan.CurrentLayout = ((QRibbonItem)sender).Title;
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

    private void MainForm_Activated(object sender, EventArgs e)
    {
      Mediator.Mediator.Instance.NotifyColleagues(Cad.OnReFresh,null);
    }

    private void MainForm_Deactivate(object sender, EventArgs e)
    {
      Mediator.Mediator.Instance.NotifyColleagues(Cad.OnReFresh, null);
    }
  }
}
