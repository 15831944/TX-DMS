using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Core.Module;
using Mediator;

namespace ControlReport
{
  public partial class UserControlReport : UserControl
  {
    public UserControlReport()
    {
      InitializeComponent();
      foreach (var item in DimensionType.DimensionTypes)
      {
        DimensionTypeEditColumn.Items.Add(item.Text);
      }
      Mediator.Mediator.Instance.Register(InterfaceCommand.ExecuteReport, i_O =>
        {
          dataGridView1.AllowUserToAddRows = false;
          dataGridView1.AllowUserToDeleteRows = false;
          StatusColumn.Visible = true;
          MeasuredColumn.Visible = true;
          dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        });
      Mediator.Mediator.Instance.Register(InterfaceCommand.EditReport, i_O =>
      {
        dataGridView1.AllowUserToAddRows = true;
        dataGridView1.AllowUserToDeleteRows = true;
        StatusColumn.Visible = false;
        MeasuredColumn.Visible = false;
        NominalColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
      });

      var dimensionEntities = new List<DimensionEntity>();
      var templates = new List<DimensionTemplate>();
      var results = new List<DimensionResult>();
      for(int i=0; i<10;i++)
      {
        var dimensionEntity = new DimensionEntity()
          {
            Dimensiontype = DimensionType.GetDimension(i),
            Index = 0,
            MinusTol = 0.1,
            PlusTol = 0.1,
            Nominal = i+5,
            Symbol = (char) 0x0424,
          };
        dimensionEntities.Add(dimensionEntity);
        var dimensionTemplate = new DimensionTemplate()
          {
            DimensionEntity = dimensionEntity,
            Manufacturer = string.Format("Manufacture {0}", i + 1),
            Operator = string.Format("Operator {0}", i + 1),
            PartName = string.Format("PartName {0}", i + 1),
            PartNumber = string.Format("PartNumber {0}", i + 1),
            Time = DateTime.Now,
          };
        templates.Add(dimensionTemplate);
        var dimensionResult = new DimensionResult() {DimensionEntity = dimensionEntity, DimensionTemplate = dimensionTemplate, Measured = i + 5};
        results.Add(dimensionResult);
      }
      
      foreach (var dimensionResult in results)
      {
        var dimension = dimensionResult.DimensionEntity;
        dataGridView1.Rows.Add(dimension.Index, dimension.Dimensiontype.Text, dimension.ToString(), "",Resource.PROCESS_PROCESSING);
    }
    }
  }
}
