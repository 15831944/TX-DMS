using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Text;
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
    private PartReport _PartReport;
    private Dimension _SeletedDimension;
    private int _SelectedRow;
    private List<EditDimensionEntityViewModel> _DataSource =null;
    public EditReportControl()
    {
      InitializeComponent();
      Mediator.Mediator.Instance.Register(UI.SelectPartTemplate, OnSelect);
      Mediator.Mediator.Instance.Register(UI.CreatePartTemplate, OnCreate);

      Mediator.Mediator.Instance.Register(Cad.OnDimensionSelected, OnCadElementSelected);
    }

    private void OnCadElementSelected(object i_Obj)
    {
      var dim = i_Obj as Teigha.DatabaseServices.Dimension;
      var text = i_Obj as MText;
      if (dim ==null && text==null)
        return;

      if(dim!=null)
        PmsService.Instance.CurrentCadHandle = dim.Handle.ToString().Trim();
      if(text!=null)
        PmsService.Instance.CurrentCadHandle = text.Handle.ToString().Trim();


      dataGridView1.ClearSelection();
      //Highlight row accordingly
      if (_DataSource == null) 
        return;
      int rowNumber = -1;
      bool matched = false;
      foreach (var editDimensionEntityViewModel in _DataSource)
      {
        rowNumber++;
        if (editDimensionEntityViewModel.GetDimension().CadHandle == dim.Handle.ToString().Trim())
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
    }
    private void OnSelect(object i_O)
    {
      var template = i_O as Part;
      if (template == null)
        return;

      _Part = template;


      _DataSource = new List<EditDimensionEntityViewModel>();
      PmsService.Instance.GetDimensionsByPart(template);
      foreach (var en in template.Dimensions)
      {
        _DataSource.Add(new EditDimensionEntityViewModel(en));
      }

      dataGridView1.DataSource = _DataSource;
      txtPartName.Text = template.Name;
      txtPartNumber.Text = template.CadNumber;
      txtSecondNumber.Text = template.SecondNumber;
    }

    private void btnAddCadFile_Click(object sender, EventArgs e)
    {
      Mediator.Mediator.Instance.NotifyColleagues(UI.OpenCadFile,null);
    }

    private void btnSave_Click(object sender, EventArgs e)
    {

    }

    private void btnMachCadHandle_Click(object sender, EventArgs e)
    {
      if (dataGridView1.SelectedRows.Count >= 0)
      {
        var dim = _DataSource[_SelectedRow].GetDimension();
        dim.CadHandle = PmsService.Instance.CurrentCadHandle;
        dataGridView1.InvalidateRow(_SelectedRow);
      }
    }

    private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
    {
      _SeletedDimension = _Part.Dimensions[e.RowIndex];
      _SelectedRow = e.RowIndex;

    }
  }
}
