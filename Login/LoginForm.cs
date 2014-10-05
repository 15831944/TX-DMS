using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Core.Service;
using Mediator;

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
        PmsService.Instance.CheckUser(TxtUserName.Text, TxtPwd.Text);
        //Mediator.Mediator.Instance.NotifyColleagues(App.OnLogin, true);
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
