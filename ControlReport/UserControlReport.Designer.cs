﻿namespace ControlReport
{
  partial class UserControlReport
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
      this.label7 = new System.Windows.Forms.Label();
      this.textBox6 = new System.Windows.Forms.TextBox();
      this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
      this.label6 = new System.Windows.Forms.Label();
      this.textBox5 = new System.Windows.Forms.TextBox();
      this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
      this.label4 = new System.Windows.Forms.Label();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
      this.label5 = new System.Windows.Forms.Label();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.IndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DimensionTypeEditColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.NominalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.MeasuredColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.StatusColumn = new System.Windows.Forms.DataGridViewImageColumn();
      this.flowLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.flowLayoutPanel6.SuspendLayout();
      this.flowLayoutPanel5.SuspendLayout();
      this.flowLayoutPanel3.SuspendLayout();
      this.flowLayoutPanel4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // flowLayoutPanel2
      // 
      this.flowLayoutPanel2.Controls.Add(this.label3);
      this.flowLayoutPanel2.Controls.Add(this.textBox2);
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
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(70, 3);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(189, 20);
      this.textBox2.TabIndex = 1;
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
      this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 3);
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
      this.flowLayoutPanel6.Controls.Add(this.textBox6);
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
      // textBox6
      // 
      this.textBox6.Location = new System.Drawing.Point(70, 3);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new System.Drawing.Size(189, 20);
      this.textBox6.TabIndex = 1;
      // 
      // flowLayoutPanel5
      // 
      this.flowLayoutPanel5.Controls.Add(this.label6);
      this.flowLayoutPanel5.Controls.Add(this.textBox5);
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
      // textBox5
      // 
      this.textBox5.Location = new System.Drawing.Point(94, 3);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new System.Drawing.Size(189, 20);
      this.textBox5.TabIndex = 1;
      // 
      // flowLayoutPanel3
      // 
      this.flowLayoutPanel3.Controls.Add(this.label4);
      this.flowLayoutPanel3.Controls.Add(this.textBox3);
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
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(70, 3);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(189, 20);
      this.textBox3.TabIndex = 1;
      // 
      // flowLayoutPanel4
      // 
      this.flowLayoutPanel4.Controls.Add(this.label5);
      this.flowLayoutPanel4.Controls.Add(this.textBox4);
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
      // textBox4
      // 
      this.textBox4.Location = new System.Drawing.Point(94, 3);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(189, 20);
      this.textBox4.TabIndex = 1;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToOrderColumns = true;
      this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndexColumn,
            this.DimensionTypeEditColumn,
            this.NominalColumn,
            this.MeasuredColumn,
            this.StatusColumn});
      this.dataGridView1.Location = new System.Drawing.Point(1, 128);
      this.dataGridView1.Margin = new System.Windows.Forms.Padding(1, 8, 1, 1);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(578, 495);
      this.dataGridView1.TabIndex = 4;
      // 
      // IndexColumn
      // 
      this.IndexColumn.DataPropertyName = "DimensionEntity.Index";
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      this.IndexColumn.DefaultCellStyle = dataGridViewCellStyle1;
      this.IndexColumn.Frozen = true;
      this.IndexColumn.HeaderText = "序号";
      this.IndexColumn.MinimumWidth = 40;
      this.IndexColumn.Name = "IndexColumn";
      this.IndexColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.IndexColumn.Width = 40;
      // 
      // DimensionTypeEditColumn
      // 
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      this.DimensionTypeEditColumn.DefaultCellStyle = dataGridViewCellStyle2;
      this.DimensionTypeEditColumn.Frozen = true;
      this.DimensionTypeEditColumn.HeaderText = "检验项目";
      this.DimensionTypeEditColumn.Name = "DimensionTypeEditColumn";
      this.DimensionTypeEditColumn.Width = 80;
      // 
      // NominalColumn
      // 
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      this.NominalColumn.DefaultCellStyle = dataGridViewCellStyle3;
      this.NominalColumn.HeaderText = "标准要求";
      this.NominalColumn.Name = "NominalColumn";
      this.NominalColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.NominalColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.NominalColumn.Width = 150;
      // 
      // MeasuredColumn
      // 
      this.MeasuredColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.MeasuredColumn.HeaderText = "实测数据";
      this.MeasuredColumn.Name = "MeasuredColumn";
      this.MeasuredColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.MeasuredColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // StatusColumn
      // 
      this.StatusColumn.HeaderText = "状态";
      this.StatusColumn.Name = "StatusColumn";
      this.StatusColumn.Width = 40;
      // 
      // UserControlReport
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "UserControlReport";
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
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox textBox6;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn IndexColumn;
    private System.Windows.Forms.DataGridViewComboBoxColumn DimensionTypeEditColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn NominalColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn MeasuredColumn;
    private System.Windows.Forms.DataGridViewImageColumn StatusColumn;

  }
}
