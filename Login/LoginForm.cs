using System;
using System.Windows.Forms;
using Core.Service;

namespace Login
{
  public partial class LoginForm : Form
  {
    public LoginForm()
    {
      InitializeComponent();
    }

    private void BtnOK_Click(object sender, EventArgs e)
    {
      try
      {
        PmsService.Instance.CheckUser(qInputBoxUser.Text, qInputBoxPwd.Text);
        
        DialogResult = DialogResult.OK;
        Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "登陆错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      } 
   
    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
