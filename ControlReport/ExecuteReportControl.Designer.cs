﻿namespace ControlReport
{
  partial class ExecuteReportControl
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
      this.label3 = new System.Windows.Forms.Label();
      this.txtManufacturer = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
      this.label7 = new System.Windows.Forms.Label();
      this.txtPartNumber = new System.Windows.Forms.TextBox();
      this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
      this.label6 = new System.Windows.Forms.Label();
      this.txtSampleNumber = new System.Windows.Forms.TextBox();
      this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
      this.label4 = new System.Windows.Forms.Label();
      this.txtPartName = new System.Windows.Forms.TextBox();
      this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
      this.label5 = new System.Windows.Forms.Label();
      this.txtTotolNumber = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.IndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DimensionTypeEditColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NominalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.MeasuredColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.StatusColumn = new System.Windows.Forms.DataGridViewImageColumn();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnCreateReport = new System.Windows.Forms.Button();
      this.btnReMeasureing = new System.Windows.Forms.Button();
      this.flowLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.flowLayoutPanel6.SuspendLayout();
      this.flowLayoutPanel5.SuspendLayout();
      this.flowLayoutPanel3.SuspendLayout();
      this.flowLayoutPanel4.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // flowLayoutPanel2
      // 
      this.flowLayoutPanel2.Controls.Add(this.label3);
      this.flowLayoutPanel2.Controls.Add(this.txtManufacturer);
      this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 30);
      this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.flowLayoutPanel2.Name = "flowLayoutPanel2";
      this.flowLayoutPanel2.Size = new System.Drawing.Size(580, 30);
      this.flowLayoutPanel2.TabIndex = 2;
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(61, 26);
      this.label3.TabIndex = 0;
      this.label3.Text = "外协单位：";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtManufacturer
      // 
      this.txtManufacturer.Location = new System.Drawing.Point(70, 3);
      this.txtManufacturer.Name = "txtManufacturer";
      this.txtManufacturer.Size = new System.Drawing.Size(189, 20);
      this.txtManufacturer.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(241, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(98, 30);
      this.label1.TabIndex = 0;
      this.label1.Text = "外协件检验报告";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(580, 600);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel6, 0, 1);
      this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel5, 0, 1);
      this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel4, 1, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 60);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 2;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(580, 60);
      this.tableLayoutPanel2.TabIndex = 3;
      // 
      // flowLayoutPanel6
      // 
      this.flowLayoutPanel6.Controls.Add(this.label7);
      this.flowLayoutPanel6.Controls.Add(this.txtPartNumber);
      this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel6.Location = new System.Drawing.Point(0, 30);
      this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
      this.flowLayoutPanel6.Name = "flowLayoutPanel6";
      this.flowLayoutPanel6.Size = new System.Drawing.Size(290, 30);
      this.flowLayoutPanel6.TabIndex = 7;
      // 
      // label7
      // 
      this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(3, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(61, 26);
      this.label7.TabIndex = 0;
      this.label7.Text = "零件图号：";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtPartNumber
      // 
      this.txtPartNumber.Location = new System.Drawing.Point(70, 3);
      this.txtPartNumber.Name = "txtPartNumber";
      this.txtPartNumber.Size = new System.Drawing.Size(189, 20);
      this.txtPartNumber.TabIndex = 1;
      // 
      // flowLayoutPanel5
      // 
      this.flowLayoutPanel5.Controls.Add(this.label6);
      this.flowLayoutPanel5.Controls.Add(this.txtSampleNumber);
      this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel5.Location = new System.Drawing.Point(290, 30);
      this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
      this.flowLayoutPanel5.Name = "flowLayoutPanel5";
      this.flowLayoutPanel5.Size = new System.Drawing.Size(290, 30);
      this.flowLayoutPanel5.TabIndex = 6;
      // 
      // label6
      // 
      this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(3, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(85, 26);
      this.label6.TabIndex = 0;
      this.label6.Text = "抽样数量（只）：";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtSampleNumber
      // 
      this.txtSampleNumber.Location = new System.Drawing.Point(94, 3);
      this.txtSampleNumber.Name = "txtSampleNumber";
      this.txtSampleNumber.Size = new System.Drawing.Size(189, 20);
      this.txtSampleNumber.TabIndex = 1;
      // 
      // flowLayoutPanel3
      // 
      this.flowLayoutPanel3.Controls.Add(this.label4);
      this.flowLayoutPanel3.Controls.Add(this.txtPartName);
      this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
      this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
      this.flowLayoutPanel3.Name = "flowLayoutPanel3";
      this.flowLayoutPanel3.Size = new System.Drawing.Size(290, 30);
      this.flowLayoutPanel3.TabIndex = 4;
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(3, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(61, 26);
      this.label4.TabIndex = 0;
      this.label4.Text = "零件名称：";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtPartName
      // 
      this.txtPartName.Location = new System.Drawing.Point(70, 3);
      this.txtPartName.Name = "txtPartName";
      this.txtPartName.Size = new System.Drawing.Size(189, 20);
      this.txtPartName.TabIndex = 1;
      // 
      // flowLayoutPanel4
      // 
      this.flowLayoutPanel4.Controls.Add(this.label5);
      this.flowLayoutPanel4.Controls.Add(this.txtTotolNumber);
      this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel4.Location = new System.Drawing.Point(290, 0);
      this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
      this.flowLayoutPanel4.Name = "flowLayoutPanel4";
      this.flowLayoutPanel4.Size = new System.Drawing.Size(290, 30);
      this.flowLayoutPanel4.TabIndex = 5;
      // 
      // label5
      // 
      this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(3, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(85, 26);
      this.label5.TabIndex = 0;
      this.label5.Text = "送样数量（只）：";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtTotolNumber
      // 
      this.txtTotolNumber.Location = new System.Drawing.Point(94, 3);
      this.txtTotolNumber.Name = "txtTotolNumber";
      this.txtTotolNumber.Size = new System.Drawing.Size(189, 20);
      this.txtTotolNumber.TabIndex = 1;
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 1;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.Controls.Add(this.dataGridView1, 0, 0);
      this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 1);
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 123);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 2;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(574, 474);
      this.tableLayoutPanel3.TabIndex = 4;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndexColumn,
            this.DimensionTypeEditColumn,
            this.NominalColumn,
            this.MeasuredColumn,
            this.StatusColumn});
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(1, 8);
      this.dataGridView1.Margin = new System.Windows.Forms.Padding(1, 8, 1, 1);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(572, 405);
      this.dataGridView1.TabIndex = 5;
      this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
      // 
      // IndexColumn
      // 
      this.IndexColumn.DataPropertyName = "Index";
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      this.IndexColumn.DefaultCellStyle = dataGridViewCellStyle4;
      this.IndexColumn.Frozen = true;
      this.IndexColumn.HeaderText = "序号";
      this.IndexColumn.MinimumWidth = 40;
      this.IndexColumn.Name = "IndexColumn";
      this.IndexColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.IndexColumn.Width = 40;
      // 
      // DimensionTypeEditColumn
      // 
      this.DimensionTypeEditColumn.DataPropertyName = "DimensionType";
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      this.DimensionTypeEditColumn.DefaultCellStyle = dataGridViewCellStyle5;
      this.DimensionTypeEditColumn.Frozen = true;
      this.DimensionTypeEditColumn.HeaderText = "检验项目";
      this.DimensionTypeEditColumn.Name = "DimensionTypeEditColumn";
      this.DimensionTypeEditColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.DimensionTypeEditColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.DimensionTypeEditColumn.Width = 65;
      // 
      // NominalColumn
      // 
      this.NominalColumn.DataPropertyName = "Nominal";
      dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      this.NominalColumn.DefaultCellStyle = dataGridViewCellStyle6;
      this.NominalColumn.HeaderText = "标准要求";
      this.NominalColumn.Name = "NominalColumn";
      this.NominalColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.NominalColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.NominalColumn.Width = 80;
      // 
      // MeasuredColumn
      // 
      this.MeasuredColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.MeasuredColumn.DataPropertyName = "Measured";
      this.MeasuredColumn.HeaderText = "实测数据";
      this.MeasuredColumn.Name = "MeasuredColumn";
      this.MeasuredColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.MeasuredColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // StatusColumn
      // 
      this.StatusColumn.DataPropertyName = "StatusBitmap";
      this.StatusColumn.HeaderText = "状态";
      this.StatusColumn.Name = "StatusColumn";
      this.StatusColumn.Width = 40;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnCreateReport);
      this.panel1.Controls.Add(this.btnReMeasureing);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(3, 417);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(568, 54);
      this.panel1.TabIndex = 6;
      // 
      // btnCreateReport
      // 
      this.btnCreateReport.Location = new System.Drawing.Point(297, 15);
      this.btnCreateReport.Name = "btnCreateReport";
      this.btnCreateReport.Size = new System.Drawing.Size(75, 23);
      this.btnCreateReport.TabIndex = 2;
      this.btnCreateReport.Text = "生成报告";
      this.btnCreateReport.UseVisualStyleBackColor = true;
      // 
      // btnReMeasureing
      // 
      this.btnReMeasureing.Location = new System.Drawing.Point(178, 15);
      this.btnReMeasureing.Name = "btnReMeasureing";
      this.btnReMeasureing.Size = new System.Drawing.Size(75, 23);
      this.btnReMeasureing.TabIndex = 0;
      this.btnReMeasureing.Text = "重新检测";
      this.btnReMeasureing.UseVisualStyleBackColor = true;
      this.btnReMeasureing.Click += new System.EventHandler(this.btnReMeasureing_Click);
      // 
      // ExecuteReportControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "ExecuteReportControl";
      this.Size = new System.Drawing.Size(580, 600);
      this.flowLayoutPanel2.ResumeLayout(false);
      this.flowLayoutPanel2.PerformLayout();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.flowLayoutPanel6.ResumeLayout(false);
      this.flowLayoutPanel6.PerformLayout();
      this.flowLayoutPanel5.ResumeLayout(false);
      this.flowLayoutPanel5.PerformLayout();
      this.flowLayoutPanel3.ResumeLayout(false);
      this.flowLayoutPanel3.PerformLayout();
      this.flowLayoutPanel4.ResumeLayout(false);
      this.flowLayoutPanel4.PerformLayout();
      this.tableLayoutPanel3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtPartName;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtTotolNumber;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtPartNumber;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtSampleNumber;
    private System.Windows.Forms.DataGridViewTextBoxColumn PlusTolColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn MinusTolColumn;
    private System.Windows.Forms.TextBox txtManufacturer;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnCreateReport;
    private System.Windows.Forms.Button btnReMeasureing;
    private System.Windows.Forms.DataGridViewTextBoxColumn IndexColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn DimensionTypeEditColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn NominalColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn MeasuredColumn;
    private System.Windows.Forms.DataGridViewImageColumn StatusColumn;

  }
}
