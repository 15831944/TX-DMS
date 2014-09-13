using System;
using System.Collections.Generic;
using System.Data;
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
    public delegate void InvokeDelegate();
    public ExecuteReportControl()
    {
      InitializeComponent();
//      if (Process.GetCurrentProcess().ProcessName.StartsWith("devenv", StringComparison.Ordinal))
//        return;
      Mediator.Mediator.Instance.Register(InterfaceCommand.SelectPartTemplate, OnSelect);

      //Mediator.Mediator.Instance.Register(ModelEvent.DimensionReportChanged, i_O => this.BeginInvoke(new InvokeDelegate(UpdateWindow)));



//
//      var dimensionViewModels = new List<DimensionViewModel>();
//      foreach (var dimensionResult in results)
//      {
//        dimensionViewModels.Add(new DimensionViewModel(dimensionResult));
//      }

//      dataGridView1.DataSource = dimensionViewModels;
//      txtManufacturer.DataBindings.Add("Text", dimensionViewModels[0], "Manufacturer");
//      txtPartName.DataBindings.Add("Text", dimensionViewModels[0], "PartName");
//      txtPartNumber.DataBindings.Add("Text", dimensionViewModels[0], "PartNumber");
//      txtSampleNumber.DataBindings.Add("Text", dimensionViewModels[0], "SampleCount");
//      txtTotolNumber.DataBindings.Add("Text", dimensionViewModels[0], "TotalCount");
    }

//    void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
//    {
//      ComboBox combo = e.Control as ComboBox;
//      if (combo != null)
//      {
//        // Remove an existing event-handler, if present, to avoid 
//        // adding multiple handlers when the editing control is reused.
//        combo.SelectedIndexChanged -=
//            new EventHandler(ComboBox_SelectedIndexChanged);
//
//        // Add the event handler. 
//        combo.SelectedIndexChanged +=
//            new EventHandler(ComboBox_SelectedIndexChanged);
//      }
//    }

    private PartTemplate _CurrentTemplate;
   
    private void OnSelect(object i_O)
    {
      var template = i_O as PartTemplate;
      if (template == null)
        return;

      _CurrentTemplate = template;
      UpdateWindow();
    }

    private void UpdateWindow()
    {
      if(_CurrentTemplate == null)
        return;
      var viewModels = new List<ExecuteDimensionEntityViewModel>();
      foreach (var en in _CurrentTemplate.DimensionEntitys)
      {
        viewModels.Add(new ExecuteDimensionEntityViewModel(en));
      }

      dataGridView1.DataSource = viewModels;
      txtManufacturer.Text = _CurrentTemplate.Supplier;
      txtPartName.Text = _CurrentTemplate.PartName;
      txtPartNumber.Text = _CurrentTemplate.PartCadNumber;
      txtTotolNumber.Text = _CurrentTemplate.TotalCount.ToString(CultureInfo.InvariantCulture);
      txtSampleNumber.Text = _CurrentTemplate.SampleCount.ToString(CultureInfo.InvariantCulture);
    }

    private void btnReMeasureing_Click(object sender, EventArgs e)
    {
      
    }

    private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      dataGridView1.InvalidateCell(dataGridView1.ColumnCount-1, e.RowIndex);
    }
  }
}
