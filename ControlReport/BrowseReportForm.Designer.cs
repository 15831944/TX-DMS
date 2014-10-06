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
      this.PartNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CadNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.MeasurementResultColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.AuditColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ApproveColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnDetail = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
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
            this.MeasurementResultColumn,
            this.AuditColumn,
            this.ApproveColumn});
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(3, 3);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 23;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(681, 517);
      this.dataGridView1.TabIndex = 0;
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
      this.CadNumberColumn.Width = 120;
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
      this.ApproveColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.ApproveColumn.DataPropertyName = "ApproveResult";
      this.ApproveColumn.HeaderText = "审批结果";
      this.ApproveColumn.Name = "ApproveColumn";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnClose);
      this.panel1.Controls.Add(this.btnDetail);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(3, 526);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(681, 56);
      this.panel1.TabIndex = 1;
      // 
      // btnDetail
      // 
      this.btnDetail.Location = new System.Drawing.Point(140, 12);
      this.btnDetail.Name = "btnDetail";
      this.btnDetail.Size = new System.Drawing.Size(117, 33);
      this.btnDetail.TabIndex = 0;
      this.btnDetail.Text = "明细";
      this.btnDetail.UseVisualStyleBackColor = true;
      this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(406, 12);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(133, 32);
      this.btnClose.TabIndex = 1;
      this.btnClose.Text = "关闭";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // BrowseReportForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(687, 585);
      this.Controls.Add(this.tableLayoutPanel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "BrowseReportForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "浏览报告";
      this.tableLayoutPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn PartNameColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn CadNumberColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn MeasurementResultColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn AuditColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn ApproveColumn;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnDetail;

  }
}