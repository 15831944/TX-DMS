using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using Core.Model;
using Core.Service;
using Mediator;

namespace ControlReport
{
  public partial class ExecuteReportControl : UserControl
  {
    private Part _CurrentTemplate;
    private PartReport _PartReport;
    private Dimension _SeletedDimension;
    private int _SelectedRow;

    public delegate void InvokeDelegate();
    public ExecuteReportControl()
    {
      InitializeComponent();
      Mediator.Mediator.Instance.Register(UI.SelectPartTemplate, OnPartSpecified);
      Mediator.Mediator.Instance.Register(MeasurementTool.OnDataArrived, OnMeasurementDataArrived);
    }

    private  void OnMeasurementDataArrived(object i_O)
    {
      _SeletedDimension.Measured = (float)i_O;
      dataGridView1.InvalidateRow(_SelectedRow);
    }


    private void OnPartSpecified(object i_O)
    {
      var template = i_O as Part;
      if (template == null)
        return;
      _PartReport = new PartReport() {Part = template};
      _CurrentTemplate = template;
      if (_CurrentTemplate == null)
        return;


      var viewModels = new List<ExecuteDimensionEntityViewModel>();

      PmsService.Instance.GetDimensionsByPart(_CurrentTemplate);

      foreach (var en in _CurrentTemplate.Dimensions)
      {
        viewModels.Add(new ExecuteDimensionEntityViewModel(en));
      }

      if (_CurrentTemplate.Dimensions.Count > 0)
      {
        _SeletedDimension = _CurrentTemplate.Dimensions[0];
      }

      dataGridView1.DataSource = viewModels;
      txtManufacturer.Text = _PartReport.Supplier;
      txtPartName.Text = _CurrentTemplate.Name;
      txtPartNumber.Text = _CurrentTemplate.CadNumber;
      txtSecondNumber.Text = _CurrentTemplate.SecondNumber;
      txtTotolNumber.Text = _CurrentTemplate.TotalCount.ToString(CultureInfo.InvariantCulture);
      txtSampleNumber.Text = _CurrentTemplate.SampleCount.ToString(CultureInfo.InvariantCulture);

    }



    private void btnReMeasureing_Click(object sender, EventArgs e)
    {
 
    }

    private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      dataGridView1.InvalidateRow(e.RowIndex);
    }

    private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
    {
      _SeletedDimension = _CurrentTemplate.Dimensions[e.RowIndex];
      _SelectedRow = e.RowIndex;

    }
  }
}
