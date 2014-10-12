using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ControlReport;
using Core.Model;
using Core.Service;

namespace TxPms
{
  public partial class TaskForm : Qios.DevSuite.Components.Ribbon.QRibbonForm
  {
    public TaskForm()
    {
      InitializeComponent();
      PopulateControls();
    }

    private void PopulateControls()
    {
      var parts = PmsService.Instance.GetParts();
      foreach (var partTemplate in parts)
      {
        qComboBoxPartName.Items.Add(partTemplate);
      }
      qComboBoxPartName.DisplayMember = "Name";

      var suppliers = PmsService.Instance.GetSuppliers();
      foreach (var supplier in suppliers)
      {
        qComboBoxSupplier.Items.Add(supplier);
      }
      qComboBoxSupplier.DisplayMember = "Name";
    }

    private void qButtonOK_Click(object sender, EventArgs e)
    {
      try
      {
        var task = new Task
          {
            Part = (Part) qComboBoxPartName.SelectedItem,
            SampleNumber = int.Parse(qTextBoxSample.Text),
            TotalNumber = int.Parse(qTextBoxTotal.Text),
            Supplier = (Supplier) qComboBoxSupplier.SelectedItem,
            CreateDatetime = DateTime.Now,
            Creator = PmsService.Instance.CurrentUser.Name
          };
        PmsService.Instance.Save(task);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void qComboBoxPartName_SelectedItemChanged(object sender, EventArgs e)
    {
      qTextBoxCadNumber.Text = ((Part)qComboBoxPartName.SelectedItem).CadNumber;
    }

    private void qButtonCancel_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
