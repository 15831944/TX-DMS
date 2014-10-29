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
      var parts = PmsService.Instance.GetParts();
      foreach (var partTemplate in parts)
      {
        viewModels.Add(new PartTemplateViewModel(partTemplate));
      }
      comboPartNameEx.DataSource = viewModels;
      comboPartNameEx.ValueMember = "Part";
      comboPartNameEx.DisplayMember = "PartName";
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      PmsService.Instance.CurrentPart = (Part) comboPartNameEx.SelectedValue;
      Mediator.Mediator.Instance.NotifyColleagues(UI.SelectPart, PmsService.Instance.CurrentPart);
      Close();
    }

    public class PartTemplateViewModel
    {
      private readonly Part _PartTemplate;
      public PartTemplateViewModel(Part i_PartTemplate)
      {
        _PartTemplate = i_PartTemplate;
      }

      public string PartSecondNumber { get { return _PartTemplate.SecondNumber; } }
      public string PartCadNumber { get { return _PartTemplate.CadNumber; } }
      public string PartName { get { return _PartTemplate.Name; } }
      public Part Part { get { return _PartTemplate; } } 
    }
  }
}
