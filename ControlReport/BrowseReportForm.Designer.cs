namespace ControlReport
{
  partial class BrowseReportForm
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.BtnDetail = new System.Windows.Forms.Button();
      this.BtnCancel = new System.Windows.Forms.Button();
      this.PartNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CadNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.SupplierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.MeasurementResultColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.AuditColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ApproveColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.tableLayoutPanel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.57265F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.42735F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(687, 585);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartNameColumn,
            this.CadNumberColumn,
            this.SupplierColumn,
            this.MeasurementResultColumn,
            this.AuditColumn,
            this.ApproveColumn});
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(3, 3);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 23;
      this.dataGridView1.Size = new System.Drawing.Size(681, 517);
      this.dataGridView1.TabIndex = 0;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 3;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel2.Controls.Add(this.BtnDetail, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.BtnCancel, 1, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 526);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(681, 56);
      this.tableLayoutPanel2.TabIndex = 1;
      // 
      // BtnDetail
      // 
      this.BtnDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnDetail.Location = new System.Drawing.Point(3, 3);
      this.BtnDetail.Name = "BtnDetail";
      this.BtnDetail.Size = new System.Drawing.Size(220, 50);
      this.BtnDetail.TabIndex = 0;
      this.BtnDetail.Text = "明细";
      this.BtnDetail.UseVisualStyleBackColor = true;
      // 
      // BtnCancel
      // 
      this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnCancel.Location = new System.Drawing.Point(229, 3);
      this.BtnCancel.Name = "BtnCancel";
      this.BtnCancel.Size = new System.Drawing.Size(220, 50);
      this.BtnCancel.TabIndex = 1;
      this.BtnCancel.Text = "关闭";
      this.BtnCancel.UseVisualStyleBackColor = true;
      // 
      // PartNameColumn
      // 
      this.PartNameColumn.DataPropertyName = "Partname";
      this.PartNameColumn.HeaderText = "名称";
      this.PartNameColumn.Name = "PartNameColumn";
      // 
      // CadNumberColumn
      // 
      this.CadNumberColumn.DataPropertyName = "PartCadNumber";
      this.CadNumberColumn.HeaderText = "图号";
      this.CadNumberColumn.Name = "CadNumberColumn";
      // 
      // SupplierColumn
      // 
      this.SupplierColumn.DataPropertyName = "Supplier";
      this.SupplierColumn.HeaderText = "单位";
      this.SupplierColumn.Name = "SupplierColumn";
      // 
      // MeasurementResultColumn
      // 
      this.MeasurementResultColumn.DataPropertyName = "MeasurementResult";
      this.MeasurementResultColumn.HeaderText = "检验结果";
      this.MeasurementResultColumn.Name = "MeasurementResultColumn";
      // 
      // AuditColumn
      // 
      this.AuditColumn.DataPropertyName = "AuditResult";
      this.AuditColumn.HeaderText = "评审结果";
      this.AuditColumn.Name = "AuditColumn";
      // 
      // ApproveColumn
      // 
      this.ApproveColumn.DataPropertyName = "ApproveResult";
      this.ApproveColumn.HeaderText = "审批结果";
      this.ApproveColumn.Name = "ApproveColumn";
      // 
      // BrowseReportForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(687, 585);
      this.Controls.Add(this.tableLayoutPanel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "BrowseReportForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "浏览报告";
      this.tableLayoutPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button BtnDetail;
    private System.Windows.Forms.Button BtnCancel;
    private System.Windows.Forms.DataGridViewTextBoxColumn PartNameColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn CadNumberColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn SupplierColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn MeasurementResultColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn AuditColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn ApproveColumn;

  }
}