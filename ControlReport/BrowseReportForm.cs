using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Core.Service;
using Mediator;

namespace ControlReport
{
  public partial class BrowseReportForm : Form
  {
    private List<BrowseReportViewModel> _DateSource;
    private BrowseReportViewModel _SelectedReportViewModel;
    public BrowseReportForm()
    {
      InitializeComponent();
      _DateSource = new List<BrowseReportViewModel>();
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
      Close();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
