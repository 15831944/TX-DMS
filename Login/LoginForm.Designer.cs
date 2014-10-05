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
      this.TxtUserName = new System.Windows.Forms.TextBox();
      this.TxtPwd = new System.Windows.Forms.TextBox();
      this.BtnOK = new System.Windows.Forms.Button();
      this.BtnCancel = new System.Windows.Forms.Button();
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
      // TxtUserName
      // 
      this.TxtUserName.Location = new System.Drawing.Point(106, 30);
      this.TxtUserName.Name = "TxtUserName";
      this.TxtUserName.Size = new System.Drawing.Size(100, 21);
      this.TxtUserName.TabIndex = 2;
      // 
      // TxtPwd
      // 
      this.TxtPwd.Location = new System.Drawing.Point(106, 72);
      this.TxtPwd.Name = "TxtPwd";
      this.TxtPwd.Size = new System.Drawing.Size(100, 21);
      this.TxtPwd.TabIndex = 3;
      // 
      // BtnOK
      // 
      this.BtnOK.Location = new System.Drawing.Point(55, 117);
      this.BtnOK.Name = "BtnOK";
      this.BtnOK.Size = new System.Drawing.Size(75, 23);
      this.BtnOK.TabIndex = 4;
      this.BtnOK.Text = "确定 ";
      this.BtnOK.UseVisualStyleBackColor = true;
      this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
      // 
      // BtnCancel
      // 
      this.BtnCancel.Location = new System.Drawing.Point(149, 117);
      this.BtnCancel.Name = "BtnCancel";
      this.BtnCancel.Size = new System.Drawing.Size(75, 23);
      this.BtnCancel.TabIndex = 5;
      this.BtnCancel.Text = "取消";
      this.BtnCancel.UseVisualStyleBackColor = true;
      this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(287, 186);
      this.Controls.Add(this.BtnCancel);
      this.Controls.Add(this.BtnOK);
      this.Controls.Add(this.TxtPwd);
      this.Controls.Add(this.TxtUserName);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "LoginForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "登陆";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox TxtUserName;
    private System.Windows.Forms.TextBox TxtPwd;
    private System.Windows.Forms.Button BtnOK;
    private System.Windows.Forms.Button BtnCancel;

  }
}