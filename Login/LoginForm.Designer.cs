using System.Windows.Forms;

namespace Login
{
  partial class LoginForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.qInputBoxUser = new System.Windows.Forms.TextBox();
      this.qInputBoxPwd = new System.Windows.Forms.TextBox();
      this.qButtonOK = new System.Windows.Forms.Button();
      this.qButtonCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(53, 33);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(47, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "用户名:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(65, 75);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(35, 12);
      this.label2.TabIndex = 1;
      this.label2.Text = "密码:";
      // 
      // qInputBoxUser
      // 
      this.qInputBoxUser.Location = new System.Drawing.Point(106, 30);
      this.qInputBoxUser.Name = "qInputBoxUser";
      this.qInputBoxUser.Size = new System.Drawing.Size(100, 21);
      this.qInputBoxUser.TabIndex = 6;
      // 
      // qInputBoxPwd
      // 
      this.qInputBoxPwd.Location = new System.Drawing.Point(106, 71);
      this.qInputBoxPwd.Name = "qInputBoxPwd";
      this.qInputBoxPwd.Size = new System.Drawing.Size(100, 21);
      this.qInputBoxPwd.TabIndex = 7;
      // 
      // qButtonOK
      // 
      this.qButtonOK.Location = new System.Drawing.Point(48, 118);
      this.qButtonOK.Name = "qButtonOK";
      this.qButtonOK.Size = new System.Drawing.Size(75, 23);
      this.qButtonOK.TabIndex = 8;
      this.qButtonOK.Text = "确定";
      this.qButtonOK.Click += new System.EventHandler(this.BtnOK_Click);
      // 
      // qButtonCancel
      // 
      this.qButtonCancel.Location = new System.Drawing.Point(157, 118);
      this.qButtonCancel.Name = "qButtonCancel";
      this.qButtonCancel.Size = new System.Drawing.Size(75, 23);
      this.qButtonCancel.TabIndex = 9;
      this.qButtonCancel.Text = "取消";
      this.qButtonCancel.Click += new System.EventHandler(this.BtnCancel_Click);
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(287, 170);
      this.Controls.Add(this.qButtonCancel);
      this.Controls.Add(this.qButtonOK);
      this.Controls.Add(this.qInputBoxPwd);
      this.Controls.Add(this.qInputBoxUser);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.ForeColor = System.Drawing.SystemColors.WindowText;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "LoginForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "登陆";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private TextBox qInputBoxUser;
    private TextBox qInputBoxPwd;
    private Button qButtonOK;
    private Button qButtonCancel;

  }
}