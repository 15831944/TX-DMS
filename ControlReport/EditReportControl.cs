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

namespace ControlReport
{
  public partial class EditReportControl : UserControl
  {
    private Part _Part;
    public EditReportControl()
    {
      InitializeComponent();
      Mediator.Mediator.Instance.Register(UI.SelectPartTemplate, OnSelect);
      Mediator.Mediator.Instance.Register(UI.CreatePartTemplate, OnCreate);
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


      var viewModels = new List<EditDimensionEntityViewModel>();
      PmsService.Instance.GetDimensionsByPart(template);
      foreach (var en in template.Dimensions)
      {
        viewModels.Add(new EditDimensionEntityViewModel(en));
      }

      dataGridView1.DataSource = viewModels;
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
  }
}
