namespace ControlReport
{
  partial class SelectReportControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label7 = new System.Windows.Forms.Label();
      this.comboPartCadNumber = new System.Windows.Forms.ComboBox();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label7
      // 
      this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)));
      this.label7.AutoSize = true;
      this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(78, 34);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(69, 15);
      this.label7.TabIndex = 6;
      this.label7.Text = "零件图号：";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // comboPartCadNumber
      // 
      this.comboPartCadNumber.FormattingEnabled = true;
      this.comboPartCadNumber.Location = new System.Drawing.Point(157, 32);
      this.comboPartCadNumber.Name = "comboPartCadNumber";
      this.comboPartCadNumber.Size = new System.Drawing.Size(163, 21);
      this.comboPartCadNumber.TabIndex = 7;
      this.comboPartCadNumber.Text = "请选择...";
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(206, 83);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(96, 30);
      this.btnCancel.TabIndex = 5;
      this.btnCancel.Text = "取消";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnOK
      // 
      this.btnOK.Location = new System.Drawing.Point(89, 83);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(87, 30);
      this.btnOK.TabIndex = 4;
      this.btnOK.Text = "确定";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // SelectReportControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(382, 141);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.comboPartCadNumber);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "SelectReportControl";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.ComboBox comboPartCadNumber;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnOK;


  }
}
