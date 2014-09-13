using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using Core.Model;
using Mediator;

namespace ControlReport
{
  public partial class EditReportControl : UserControl
  {
    public EditReportControl()
    {
      InitializeComponent();
      foreach (var item in DimensionType.DimensionTypes)
      {
        DimensionTypeEditColumn.Items.Add(item.Text);
      }
      Mediator.Mediator.Instance.Register(InterfaceCommand.SelectPartTemplate, OnSelect);
    }

    private void OnSelect(object i_O)
    {
      var template = i_O as PartTemplate;
      if (template == null)
        return;


      var viewModels = new List<EditDimensionEntityViewModel>();
      foreach (var en in template.DimensionEntitys)
      {
        viewModels.Add(new EditDimensionEntityViewModel(en));
      }

      dataGridView1.DataSource = viewModels;
      txtManufacturer.Text = template.Supplier;
      txtPartName.Text = template.PartName;
      txtPartNumber.Text = template.PartCadNumber;
      txtTotolNumber.Text = template.TotalCount.ToString(CultureInfo.InvariantCulture);
      txtSampleNumber.Text = template.SampleCount.ToString(CultureInfo.InvariantCulture);
    }
  }
}
