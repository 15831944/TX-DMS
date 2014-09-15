﻿using System;
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
    private PartReport _PartReport;
    public delegate void InvokeDelegate();
    public ExecuteReportControl()
    {
      InitializeComponent();
      Mediator.Mediator.Instance.Register(InterfaceCommand.SelectPartTemplate, OnSelect);


    }



    private Part _CurrentTemplate;
   
    private void OnSelect(object i_O)
    {
      var template = i_O as Part;
      if (template == null)
        return;
      _PartReport = new PartReport() { Part = template };
      _CurrentTemplate = template;
      if (_CurrentTemplate == null)
        return;
      var viewModels = new List<ExecuteDimensionEntityViewModel>();
      foreach (var en in _CurrentTemplate.DimensionEntitys)
      {
        viewModels.Add(new ExecuteDimensionEntityViewModel(en));
      }

      dataGridView1.DataSource = viewModels;
      txtManufacturer.Text = _PartReport.Supplier;
      txtPartName.Text = _CurrentTemplate.Name;
      txtPartNumber.Text = _CurrentTemplate.CadNumber;
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
