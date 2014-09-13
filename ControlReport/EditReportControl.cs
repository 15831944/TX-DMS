using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Core.Model;

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
    }
  }
}
