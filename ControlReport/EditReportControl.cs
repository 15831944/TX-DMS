using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Core.Model;
using Core.Service;
using Mediator;
using Teigha.DatabaseServices;
using Dimension = Core.Model.Dimension;

namespace ControlReport
{
  public partial class EditReportControl : UserControl
  {
    private Part _Part;
    private Dimension _SeletedDimension;
    private int _SelectedRow;
    private BindingList<EditDimensionEntityViewModel> _DataSource = new BindingList<EditDimensionEntityViewModel>();
    public EditReportControl()
    {
      InitializeComponent();
      Mediator.Mediator.Instance.Register(UI.SelectPartTemplate, OnPartSpecified);
      Mediator.Mediator.Instance.Register(UI.CreatePartTemplate, OnCreate);
      Mediator.Mediator.Instance.Register(Cad.OnDimensionSelected, OnCadElementSelected);
     
    }

    private void OnCadElementSelected(object i_Obj)
    {
      var dim = i_Obj as DBObject;
      if (dim ==null)
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

    private void OnCreate(object i_O)
    {
      _Part = new Part();
      _DataSource.Clear();
      BindingPart(_Part);
    }

    private void OnPartSpecified(object i_O)
    {
      var template = i_O as Part;
      if (template == null)
        return;

      _Part = template;
      BindingPart(_Part);
    }
    private void BindingPart(Part i_Part)
    {

      _DataSource.Clear();
      PmsService.Instance.PopulateDimensionsForPart(i_Part);
      foreach (var en in i_Part.Dimensions)
      {
        _DataSource.Add(new EditDimensionEntityViewModel(en));
      }

      dataGridView1.DataSource = _DataSource;
      txtPartName.DataBindings.Clear();
      txtPartName.DataBindings.Add("Text", i_Part, "Name");
      txtPartNumber.DataBindings.Clear();
      txtPartNumber.DataBindings.Add("Text", i_Part, "CadNumber");
      txtSecondNumber.DataBindings.Clear();
      txtSecondNumber.DataBindings.Add("Text", i_Part, "SecondNumber");
    }
    private void btnAddCadFile_Click(object i_Sender, EventArgs e)
    {
      Mediator.Mediator.Instance.NotifyColleagues(UI.OpenCadFile,null);
    }

    private void btnSave_Click(object i_Sender, EventArgs e)
    {
      Mediator.Mediator.Instance.NotifyColleagues(UI.SavePartTemplate,_Part);
      PmsService.Instance.SavePart(_Part);
      PmsService.Instance.SaveDimesinos(ConstructDimensions());
    }

    private List<Dimension> ConstructDimensions()
    {
      var result = new List<Dimension>();
      if (_DataSource == null) return result;
      foreach (var editDimensionEntityViewModel in _DataSource)
      {
        result.Add(editDimensionEntityViewModel.GetDimension());
      }
      return result;
    }

    private void btnMachCadHandle_Click(object i_Sender, EventArgs e)
    {
      if (dataGridView1.SelectedRows.Count >= 0)
      {
        var dim = _DataSource[_SelectedRow].GetDimension();
        dim.CadHandle = PmsService.Instance.CurrentCadHandle;
        dataGridView1.InvalidateRow(_SelectedRow);
      }
    }

    private void dataGridView1_RowEnter(object i_Sender, DataGridViewCellEventArgs e)
    {
      if(_Part!=null && _Part.Dimensions.Count>0)
      _SeletedDimension = _Part.Dimensions[e.RowIndex];
      _SelectedRow = e.RowIndex;
    }

    private void btnNew_Click(object i_Sender, EventArgs e)
    {
      _SeletedDimension = new Dimension() {SerialNumber = _DataSource.Count + 1, Part = _Part};
      //_Part.Dimensions.Add(_SeletedDimension);
      var newOne = new EditDimensionEntityViewModel(_SeletedDimension);
      _DataSource.Add(newOne);
      dataGridView1.DataSource = _DataSource;
      dataGridView1.Refresh();
    }

    private void btnDelete_Click(object i_Sender, EventArgs e)
    {
      if (_DataSource != null && _DataSource.Count > 1)
      {
        var lastDimension = _DataSource[_DataSource.Count - 1].GetDimension();
        PmsService.Instance.DeleteDimension(lastDimension);
        _DataSource.RemoveAt(_DataSource.Count - 1);
      }
    }
  }
}
