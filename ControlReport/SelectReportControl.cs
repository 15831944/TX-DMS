using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Core.Model;
using Core.Service;
using Mediator;

namespace ControlReport
{
  public partial class SelectReportControl : Form
  {
    public SelectReportControl()
    {
      InitializeComponent();
      PopulateData();
    }

    private void PopulateData()
    {
      var viewModels = new List<PartTemplateViewModel>();
      foreach (var partTemplate in PmsService.Instance.GetPartTemplates())
      {
        viewModels.Add(new PartTemplateViewModel(partTemplate));
      }
      comboPartCadNumber.DataSource = viewModels;
      comboPartCadNumber.ValueMember = "PartTemplate";
      comboPartCadNumber.DisplayMember = "PartCadNumber";
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      PmsService.Instance.CurrentTemplate = (Part) comboPartCadNumber.SelectedValue;
      Mediator.Mediator.Instance.NotifyColleagues(InterfaceCommand.SelectPartTemplate, PmsService.Instance.CurrentTemplate);
      Close();
    }

    class PartTemplateViewModel
    {
      private Part _PartTemplate;
      public PartTemplateViewModel(Part i_PartTemplate)
      {
        _PartTemplate = i_PartTemplate;
      }

      public string PartCadNumber { get { return _PartTemplate.CadNumber; } }
      public Part PartTemplate { get { return _PartTemplate; } }
    }
  }
}
