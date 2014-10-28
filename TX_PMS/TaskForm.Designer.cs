namespace TxPms
{
  partial class TaskForm
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
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.qTextBoxCadName = new Qios.DevSuite.Components.QTextBox();
      this.qComboBoxPartCadNumber = new Qios.DevSuite.Components.QComboBox();
      this.qButtonOK = new Qios.DevSuite.Components.QButton();
      this.qButtonCancel = new Qios.DevSuite.Components.QButton();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.qTextBoxSample = new Qios.DevSuite.Components.QTextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.qTextBoxTotal = new Qios.DevSuite.Components.QTextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.qComboBoxSupplier = new Qios.DevSuite.Components.QComboBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(211, 29);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(29, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "名称";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(36, 29);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(29, 12);
      this.label2.TabIndex = 1;
      this.label2.Text = "图号";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 30);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 12);
      this.label3.TabIndex = 2;
      this.label3.Text = "生产厂商";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.qTextBoxCadName);
      this.groupBox1.Controls.Add(this.qComboBoxPartCadNumber);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(395, 59);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "零件";
      // 
      // qTextBoxCadName
      // 
      this.qTextBoxCadName.Location = new System.Drawing.Point(246, 26);
      this.qTextBoxCadName.Name = "qTextBoxCadName";
      this.qTextBoxCadName.Size = new System.Drawing.Size(100, 18);
      this.qTextBoxCadName.TabIndex = 8;
      // 
      // qComboBoxPartCadNumber
      // 
      this.qComboBoxPartCadNumber.Location = new System.Drawing.Point(71, 26);
      this.qComboBoxPartCadNumber.Name = "qComboBoxPartCadNumber";
      this.qComboBoxPartCadNumber.Size = new System.Drawing.Size(100, 18);
      this.qComboBoxPartCadNumber.TabIndex = 4;
      this.qComboBoxPartCadNumber.SelectedItemChanged += new System.EventHandler(this.qComboBoxPartName_SelectedItemChanged);
      // 
      // qButtonOK
      // 
      this.qButtonOK.Image = null;
      this.qButtonOK.Location = new System.Drawing.Point(94, 179);
      this.qButtonOK.Name = "qButtonOK";
      this.qButtonOK.Size = new System.Drawing.Size(75, 23);
      this.qButtonOK.TabIndex = 4;
      this.qButtonOK.Text = "确定";
      this.qButtonOK.Click += new System.EventHandler(this.qButtonOK_Click);
      // 
      // qButtonCancel
      // 
      this.qButtonCancel.Image = null;
      this.qButtonCancel.Location = new System.Drawing.Point(234, 179);
      this.qButtonCancel.Name = "qButtonCancel";
      this.qButtonCancel.Size = new System.Drawing.Size(75, 23);
      this.qButtonCancel.TabIndex = 5;
      this.qButtonCancel.Text = "取消";
      this.qButtonCancel.Click += new System.EventHandler(this.qButtonCancel_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.qTextBoxSample);
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Controls.Add(this.qTextBoxTotal);
      this.groupBox2.Controls.Add(this.label4);
      this.groupBox2.Controls.Add(this.qComboBoxSupplier);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox2.Location = new System.Drawing.Point(0, 59);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(395, 114);
      this.groupBox2.TabIndex = 6;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "批次";
      // 
      // qTextBoxSample
      // 
      this.qTextBoxSample.Location = new System.Drawing.Point(246, 65);
      this.qTextBoxSample.Name = "qTextBoxSample";
      this.qTextBoxSample.Size = new System.Drawing.Size(100, 18);
      this.qTextBoxSample.TabIndex = 7;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(211, 68);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(29, 12);
      this.label5.TabIndex = 6;
      this.label5.Text = "抽样";
      // 
      // qTextBoxTotal
      // 
      this.qTextBoxTotal.Location = new System.Drawing.Point(71, 65);
      this.qTextBoxTotal.Name = "qTextBoxTotal";
      this.qTextBoxTotal.Size = new System.Drawing.Size(102, 18);
      this.qTextBoxTotal.TabIndex = 5;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(36, 68);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(29, 12);
      this.label4.TabIndex = 4;
      this.label4.Text = "总数";
      // 
      // qComboBoxSupplier
      // 
      this.qComboBoxSupplier.Location = new System.Drawing.Point(71, 27);
      this.qComboBoxSupplier.Name = "qComboBoxSupplier";
      this.qComboBoxSupplier.Size = new System.Drawing.Size(100, 18);
      this.qComboBoxSupplier.TabIndex = 3;
      // 
      // TaskForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(395, 219);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.qButtonCancel);
      this.Controls.Add(this.qButtonOK);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "TaskForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "新建任务";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.GroupBox groupBox1;
    private Qios.DevSuite.Components.QButton qButtonOK;
    private Qios.DevSuite.Components.QButton qButtonCancel;
    private System.Windows.Forms.GroupBox groupBox2;
    private Qios.DevSuite.Components.QComboBox qComboBoxPartCadNumber;
    private Qios.DevSuite.Components.QComboBox qComboBoxSupplier;
    private System.Windows.Forms.Label label4;
    private Qios.DevSuite.Components.QTextBox qTextBoxTotal;
    private System.Windows.Forms.Label label5;
    private Qios.DevSuite.Components.QTextBox qTextBoxSample;
    private Qios.DevSuite.Components.QTextBox qTextBoxCadName;
  }
}