using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Core.Service;

namespace ControlReport
{
  public partial class BrowseReportForm : Form
  {
    private List<BrowseReportViewModel> _DateSource;
    public BrowseReportForm()
    {
      InitializeComponent();
      _DateSource = new List<BrowseReportViewModel>();
      Load += BrowseReportForm_Load;
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
  }
}
