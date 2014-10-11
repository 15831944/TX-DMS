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
      this.comboPartNameEx = new Qios.DevSuite.Components.QComboBox();
      this.qButtonOK = new Qios.DevSuite.Components.QButton();
      this.qButtonCancel = new Qios.DevSuite.Components.QButton();
      this.SuspendLayout();
      // 
      // label7
      // 
      this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)));
      this.label7.AutoSize = true;
      this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(48, 32);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(45, 15);
      this.label7.TabIndex = 6;
      this.label7.Text = "零件：";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // comboPartNameEx
      // 
      this.comboPartNameEx.Location = new System.Drawing.Point(114, 30);
      this.comboPartNameEx.Name = "comboPartNameEx";
      this.comboPartNameEx.Size = new System.Drawing.Size(163, 19);
      this.comboPartNameEx.TabIndex = 8;
      // 
      // qButtonOK
      // 
      this.qButtonOK.Image = null;
      this.qButtonOK.Location = new System.Drawing.Point(51, 83);
      this.qButtonOK.Name = "qButtonOK";
      this.qButtonOK.Size = new System.Drawing.Size(75, 23);
      this.qButtonOK.TabIndex = 9;
      this.qButtonOK.Text = "确定";
      this.qButtonOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // qButtonCancel
      // 
      this.qButtonCancel.Image = null;
      this.qButtonCancel.Location = new System.Drawing.Point(184, 83);
      this.qButtonCancel.Name = "qButtonCancel";
      this.qButtonCancel.Size = new System.Drawing.Size(75, 23);
      this.qButtonCancel.TabIndex = 10;
      this.qButtonCancel.Text = "取消";
      this.qButtonCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // SelectReportControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(328, 135);
      this.Controls.Add(this.qButtonCancel);
      this.Controls.Add(this.qButtonOK);
      this.Controls.Add(this.comboPartNameEx);
      this.Controls.Add(this.label7);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "SelectReportControl";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label7;
    private Qios.DevSuite.Components.QComboBox comboPartNameEx;
    private Qios.DevSuite.Components.QButton qButtonOK;
    private Qios.DevSuite.Components.QButton qButtonCancel;


  }
}
