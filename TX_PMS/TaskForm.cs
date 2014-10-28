using System;
using System.Windows.Forms;
using Core.Model;
using Core.Service;

namespace TxPms
{
  public partial class TaskForm : Form
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
        qComboBoxPartCadNumber.Items.Add(partTemplate);
      }
      qComboBoxPartCadNumber.DisplayMember = "CadNumber";

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
            Part = (Part) qComboBoxPartCadNumber.SelectedItem,
            SampleNumber = int.Parse(qTextBoxSample.Text),
            TotalNumber = int.Parse(qTextBoxTotal.Text),
            Supplier = (Supplier) qComboBoxSupplier.SelectedItem,
            CreateDatetime = DateTime.Now,
            Creator = PmsService.Instance.CurrentUser.Name
          };
        PmsService.Instance.Save(task);
        Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void qComboBoxPartName_SelectedItemChanged(object sender, EventArgs e)
    {
      qTextBoxCadName.Text = ((Part)qComboBoxPartCadNumber.SelectedItem).Name;
    }

    private void qButtonCancel_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
