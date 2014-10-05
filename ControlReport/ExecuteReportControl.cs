﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using Core.Model;
using Core.Service;
using Mediator;
using Teigha.DatabaseServices;
using Dimension = Core.Model.Dimension;

namespace ControlReport
{
  public partial class ExecuteReportControl : UserControl
  {
    private Part _CurrentTemplate;
    private PartReport _PartReport;
    private Dimension _SeletedDimension;
    private int _SelectedRow;

    public delegate void InvokeDelegate();

    private List<ExecuteDimensionEntityViewModel> _DataSource;
    public ExecuteReportControl()
    {
      InitializeComponent();
      Mediator.Mediator.Instance.Register(UI.SelectPartTemplate, OnPartSpecified);
      Mediator.Mediator.Instance.Register(MeasurementTool.OnDataArrived, OnMeasurementDataArrived);

      Mediator.Mediator.Instance.Register(Cad.OnDimensionSelected, OnCadElementSelected);
      this.Load += new EventHandler(ExecuteReportControl_Load);
    }

    void ExecuteReportControl_Load(object sender, EventArgs e)
    {
      if (PmsService.Instance.CurrentUser == null || PmsService.Instance.CurrentUser.Group==null)
        return;
      if (PmsService.Instance.CurrentUser.Group.Name == "检测")
      {
        txtAuditComment.Enabled = false;
        txtApproveComment.Enabled = false;
        ChkAudit.Enabled = false;
        ChkApprove.Enabled = false;
      }
      if (PmsService.Instance.CurrentUser.Group.Name == "评审")
      {
        txtOperatorComment.Enabled = false;
        btnCreateReport.Visible = false;
        ChkAudit.Enabled = true;
        ChkApprove.Enabled = false;
        txtApproveComment.Enabled = false;
      }
      if (PmsService.Instance.CurrentUser.Group.Name == "审批")
      {
        txtOperatorComment.Enabled = false;
        btnCreateReport.Visible = false;
        txtAuditComment.Enabled = false;
        ChkAudit.Enabled = false;
        ChkApprove.Enabled = true;
      }
    }
    private void OnCadElementSelected(object i_Obj)
    {
      var dim = i_Obj as DBObject;
      if (dim == null)
        return;
      PmsService.Instance.CurrentCadHandle = dim.Handle.ToString().Trim();
      TryToHightLightRow(PmsService.Instance.CurrentCadHandle);
    }

    private void TryToHightLightRow(string i_Handle)
    {
      dataGridView1.ClearSelection();
      //Highlight row accordingly
      if (_DataSource == null)
        return;
      int rowNumber = -1;
      bool matched = false;
      foreach (var editDimensionEntityViewModel in _DataSource)
      {
        rowNumber++;
        if (editDimensionEntityViewModel.GetDimension().CadHandle == i_Handle.Trim())
        {
          matched = true;
          break;
        }
      }
      if (matched)
        dataGridView1.Rows[rowNumber].Selected = true;
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


      _DataSource = new List<ExecuteDimensionEntityViewModel>();

      PmsService.Instance.PopulateDimensionsForPart(_CurrentTemplate);

      foreach (var en in _CurrentTemplate.Dimensions)
      {
        _DataSource.Add(new ExecuteDimensionEntityViewModel(en));
      }

      if (_CurrentTemplate.Dimensions.Count > 0)
      {
        _SeletedDimension = _CurrentTemplate.Dimensions[0];
      }

      dataGridView1.DataSource = _DataSource;
      txtManufacturer.DataBindings.Clear();
      txtManufacturer.DataBindings.Add("Text", _PartReport, "Supplier"); // = _PartReport.Supplier;
      txtPartName.DataBindings.Clear();
      txtPartName.DataBindings.Add("Text", _CurrentTemplate, "Name"); //txtPartName.Text = _CurrentTemplate.Name;
      txtPartNumber.DataBindings.Clear();
      txtPartNumber.DataBindings.Add("Text", _CurrentTemplate, "CadNumber");
        //txtPartNumber.Text = _CurrentTemplate.CadNumber;
      txtSecondNumber.DataBindings.Clear();
      txtSecondNumber.DataBindings.Add("Text", _CurrentTemplate, "SecondNumber");
        //txtSecondNumber.Text = _CurrentTemplate.SecondNumber;
      txtTotolNumber.DataBindings.Clear();
      txtTotolNumber.DataBindings.Add("Text", _PartReport, "TotalCount");
        //txtTotolNumber.Text = _PartReport.TotalCount.ToString(CultureInfo.InvariantCulture);
      txtSampleNumber.DataBindings.Clear();
      txtSampleNumber.DataBindings.Add("Text", _PartReport, "SampleCount");
        //txtSampleNumber.Text = _PartReport.SampleCount.ToString(CultureInfo.InvariantCulture);
//      LblTester.DataBindings.Clear();
//      LblTester.DataBindings.Add("Text", _PartReport, "Operator"); //txtOperator.Text = _PartReport.Operator;
//      LblTestDate.DataBindings.Clear();
//      LblTestDate.DataBindings.Add("Text", _PartReport, "MeasurementDatetime");
//      txtOperatorComment.DataBindings.Clear();
//      txtOperatorComment.DataBindings.Add("Text", _PartReport, "OperatorComment");
//
//
//      LblAuditor.DataBindings.Clear();
//      LblAuditor.DataBindings.Add("Text", _PartReport, "Auditor");
//      txtAuditComment.DataBindings.Clear();
//      txtAuditComment.DataBindings.Add("Text", _PartReport, "AuditComment");
//      LblAuditDate.DataBindings.Clear();
//      LblAuditDate.DataBindings.Add("Text", _PartReport, "AuditDatetime");
//
//
//      LblAuditor.DataBindings.Clear();
//      LblAuditor.DataBindings.Add("Text", _PartReport, "Approver");
//      txtApproveComment.DataBindings.Clear();
//      txtApproveComment.DataBindings.Add("Text", _PartReport, "ApproveComment");
//      LblApproveDate.DataBindings.Clear();
//      LblApproveDate.DataBindings.Add("Text", _PartReport, "ApproveDatetime");
      if (PmsService.Instance.CurrentUser.Group.Name == "检测")
      {
        LblTester.Text = PmsService.Instance.CurrentUser.Name;
        LblTestDate.Text = DateTime.Now.ToLongDateString();
      }
      if (PmsService.Instance.CurrentUser.Group.Name == "评审")
      {
        BindMeasurementControl();
        LblAuditor.Text = PmsService.Instance.CurrentUser.Name;
        LblAuditDate.Text = DateTime.Now.ToLongDateString();
      }
      if (PmsService.Instance.CurrentUser.Group.Name == "审批")
      {
        BindMeasurementControl();
        BindAuditControl();
        LblApprover.Text = PmsService.Instance.CurrentUser.Name;
        LblApproveDate.Text = DateTime.Now.ToLongDateString();
      }
    }

    private void BindMeasurementControl()
    {
      LblTester.DataBindings.Clear();
      LblTester.DataBindings.Add("Text", _PartReport, "Operator"); //txtOperator.Text = _PartReport.Operator;
      LblTestDate.DataBindings.Clear();
      LblTestDate.DataBindings.Add("Text", _PartReport, "MeasurementDatetime");
      txtOperatorComment.DataBindings.Clear();
      txtOperatorComment.DataBindings.Add("Text", _PartReport, "OperatorComment");
    }

    private void BindAuditControl()
    {
      LblAuditor.DataBindings.Clear();
      LblAuditor.DataBindings.Add("Text", _PartReport, "Auditor");
      txtAuditComment.DataBindings.Clear();
      txtAuditComment.DataBindings.Add("Text", _PartReport, "AuditComment");
      LblAuditDate.DataBindings.Clear();
      LblAuditDate.DataBindings.Add("Text", _PartReport, "AuditDatetime");
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

    private void btnCreateReport_Click(object sender, EventArgs e)
    {
      _PartReport.Operator = PmsService.Instance.CurrentUser.Name;
      _PartReport.MeasurementDatetime = DateTime.Now;
      PmsService.Instance.SaveReport(_PartReport);
    }
  }
}
