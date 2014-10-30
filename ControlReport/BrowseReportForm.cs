using System;
using System.ComponentModel;
using System.Windows.Forms;
using Core.Model;
using Core.Service;
using Mediator;

namespace ControlReport
{
  public partial class BrowseReportForm : Form
  {
    private BindingList<BrowseReportViewModel> _DateSource;
    private BrowseReportViewModel _SelectedReportViewModel;
    public BrowseReportForm()
    {
      InitializeComponent();
      Mediator.Mediator.Instance.Register(Execution.OneCompleted, i_O =>
        {
          var report = i_O as PartReport;
          if(report==null) return;
          _DateSource.Add(new BrowseReportViewModel(report));
          dataGridView1.DataSource = _DateSource;
        });
      Mediator.Mediator.Instance.Register(Execution.TaskStarted, i_O =>
      {
        var task = i_O as Task;
        if (task == null) return;
        var executedReports = PmsService.Instance.GetPartReports(task);
        foreach (var report in executedReports)
        {
          _DateSource.Add(new BrowseReportViewModel(report)); 
        }
        dataGridView1.DataSource = _DateSource;
      });
      _DateSource = new BindingList<BrowseReportViewModel>();
      Load += BrowseReportForm_Load;
      dataGridView1.RowEnter += dataGridView1_RowEnter;
    }

    void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
    {
      if ( _DateSource.Count > 0)
        _SelectedReportViewModel = _DateSource[e.RowIndex];
    }

    void BrowseReportForm_Load(object sender, EventArgs e)
    {
      var reports = PmsService.Instance.GetPartReports();
      foreach (var partReport in reports)
      {
        PmsService.Instance.PopulateDimensionsForReport(partReport);
        _DateSource.Add(new BrowseReportViewModel(partReport));
      }

      dataGridView1.DataSource = _DateSource;
    }

    private void btnDetail_Click(object sender, EventArgs e)
    {
      if(_SelectedReportViewModel==null)
        return;
      Mediator.Mediator.Instance.NotifyColleagues(UI.SelectPartReport,_SelectedReportViewModel.GetPartReport());
      //Close();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      //Close();
    }

  }
}
