namespace ControlReport
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.label1 = new System.Windows.Forms.Label();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.IndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DimensionTypeEditColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NominalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.MeasuredColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.StatusColumn = new System.Windows.Forms.DataGridViewImageColumn();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
      this.label9 = new System.Windows.Forms.Label();
      this.txtOperator = new System.Windows.Forms.TextBox();
      this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
      this.label8 = new System.Windows.Forms.Label();
      this.txtMeasurementDateTime = new System.Windows.Forms.TextBox();
      this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
      this.label2 = new System.Windows.Forms.Label();
      this.txtSecondNumber = new System.Windows.Forms.TextBox();
      this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
      this.label4 = new System.Windows.Forms.Label();
      this.txtPartName = new System.Windows.Forms.TextBox();
      this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
      this.label5 = new System.Windows.Forms.Label();
      this.txtTotolNumber = new System.Windows.Forms.TextBox();
      this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
      this.label7 = new System.Windows.Forms.Label();
      this.txtPartNumber = new System.Windows.Forms.TextBox();
      this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
      this.label6 = new System.Windows.Forms.Label();
      this.txtSampleNumber = new System.Windows.Forms.TextBox();
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.label3 = new System.Windows.Forms.Label();
      this.txtManufacturer = new System.Windows.Forms.TextBox();
      this.tableApprove = new System.Windows.Forms.TableLayoutPanel();
      this.flowLayoutPanel12 = new System.Windows.Forms.FlowLayoutPanel();
      this.btnApprovePass = new System.Windows.Forms.Button();
      this.btnApproveFail = new System.Windows.Forms.Button();
      this.btnCreateReport = new System.Windows.Forms.Button();
      this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
      this.txtApprove = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.txtOperatorComment = new System.Windows.Forms.TextBox();
      this.label13 = new System.Windows.Forms.Label();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.txtAudit = new System.Windows.Forms.TextBox();
      this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
      this.btnAuditPass = new System.Windows.Forms.Button();
      this.btnAuditFail = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.tableLayoutPanel2.SuspendLayout();
      this.flowLayoutPanel8.SuspendLayout();
      this.flowLayoutPanel7.SuspendLayout();
      this.flowLayoutPanel2.SuspendLayout();
      this.flowLayoutPanel3.SuspendLayout();
      this.flowLayoutPanel4.SuspendLayout();
      this.flowLayoutPanel6.SuspendLayout();
      this.flowLayoutPanel5.SuspendLayout();
      this.flowLayoutPanel1.SuspendLayout();
      this.tableApprove.SuspendLayout();
      this.flowLayoutPanel12.SuspendLayout();
      this.tableLayoutPanel4.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.flowLayoutPanel11.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(323, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(98, 28);
      this.label1.TabIndex = 0;
      this.label1.Text = "外协件检验报告";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.tableApprove, 0, 3);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(745, 796);
      this.tableLayoutPanel1.TabIndex = 0;
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
      this.dataGridView1.Location = new System.Drawing.Point(1, 158);
      this.dataGridView1.Margin = new System.Windows.Forms.Padding(1, 7, 1, 1);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 23;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(743, 437);
      this.dataGridView1.TabIndex = 7;
      // 
      // IndexColumn
      // 
      this.IndexColumn.DataPropertyName = "SerialNumber";
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
      this.DimensionTypeEditColumn.DataPropertyName = "DimensionType";
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      this.DimensionTypeEditColumn.DefaultCellStyle = dataGridViewCellStyle2;
      this.DimensionTypeEditColumn.Frozen = true;
      this.DimensionTypeEditColumn.HeaderText = "检验项目";
      this.DimensionTypeEditColumn.Name = "DimensionTypeEditColumn";
      this.DimensionTypeEditColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.DimensionTypeEditColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.DimensionTypeEditColumn.Width = 65;
      // 
      // NominalColumn
      // 
      this.NominalColumn.DataPropertyName = "Nominal";
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      this.NominalColumn.DefaultCellStyle = dataGridViewCellStyle3;
      this.NominalColumn.HeaderText = "标准要求";
      this.NominalColumn.Name = "NominalColumn";
      this.NominalColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
      this.StatusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.StatusColumn.Width = 40;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel8, 0, 3);
      this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel7, 0, 3);
      this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 0, 1);
      this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel4, 1, 1);
      this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel6, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel5, 1, 2);
      this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 2);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 28);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 4;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(745, 123);
      this.tableLayoutPanel2.TabIndex = 3;
      // 
      // flowLayoutPanel8
      // 
      this.flowLayoutPanel8.Controls.Add(this.label9);
      this.flowLayoutPanel8.Controls.Add(this.txtOperator);
      this.flowLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel8.Location = new System.Drawing.Point(0, 90);
      this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
      this.flowLayoutPanel8.Name = "flowLayoutPanel8";
      this.flowLayoutPanel8.Size = new System.Drawing.Size(372, 33);
      this.flowLayoutPanel8.TabIndex = 12;
      // 
      // label9
      // 
      this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)));
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(3, 0);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(65, 27);
      this.label9.TabIndex = 2;
      this.label9.Text = "检测人员：";
      this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtOperator
      // 
      this.txtOperator.Location = new System.Drawing.Point(74, 3);
      this.txtOperator.Name = "txtOperator";
      this.txtOperator.Size = new System.Drawing.Size(189, 21);
      this.txtOperator.TabIndex = 3;
      // 
      // flowLayoutPanel7
      // 
      this.flowLayoutPanel7.Controls.Add(this.label8);
      this.flowLayoutPanel7.Controls.Add(this.txtMeasurementDateTime);
      this.flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel7.Location = new System.Drawing.Point(372, 90);
      this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
      this.flowLayoutPanel7.Name = "flowLayoutPanel7";
      this.flowLayoutPanel7.Size = new System.Drawing.Size(373, 33);
      this.flowLayoutPanel7.TabIndex = 11;
      // 
      // label8
      // 
      this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)));
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(3, 0);
      this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 39, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(65, 27);
      this.label8.TabIndex = 2;
      this.label8.Text = "检测日期：";
      this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtMeasurementDateTime
      // 
      this.txtMeasurementDateTime.Location = new System.Drawing.Point(110, 3);
      this.txtMeasurementDateTime.Name = "txtMeasurementDateTime";
      this.txtMeasurementDateTime.Size = new System.Drawing.Size(189, 21);
      this.txtMeasurementDateTime.TabIndex = 3;
      // 
      // flowLayoutPanel2
      // 
      this.flowLayoutPanel2.Controls.Add(this.label2);
      this.flowLayoutPanel2.Controls.Add(this.txtSecondNumber);
      this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel2.Location = new System.Drawing.Point(372, 0);
      this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.flowLayoutPanel2.Name = "flowLayoutPanel2";
      this.flowLayoutPanel2.Size = new System.Drawing.Size(373, 30);
      this.flowLayoutPanel2.TabIndex = 10;
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)));
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 0);
      this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 39, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(65, 27);
      this.label2.TabIndex = 0;
      this.label2.Text = "零件版本：";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtSecondNumber
      // 
      this.txtSecondNumber.Location = new System.Drawing.Point(110, 3);
      this.txtSecondNumber.Name = "txtSecondNumber";
      this.txtSecondNumber.Size = new System.Drawing.Size(189, 21);
      this.txtSecondNumber.TabIndex = 1;
      // 
      // flowLayoutPanel3
      // 
      this.flowLayoutPanel3.Controls.Add(this.label4);
      this.flowLayoutPanel3.Controls.Add(this.txtPartName);
      this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 30);
      this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
      this.flowLayoutPanel3.Name = "flowLayoutPanel3";
      this.flowLayoutPanel3.Size = new System.Drawing.Size(372, 30);
      this.flowLayoutPanel3.TabIndex = 4;
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)));
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(3, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(65, 27);
      this.label4.TabIndex = 0;
      this.label4.Text = "零件名称：";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtPartName
      // 
      this.txtPartName.Location = new System.Drawing.Point(74, 3);
      this.txtPartName.Name = "txtPartName";
      this.txtPartName.Size = new System.Drawing.Size(189, 21);
      this.txtPartName.TabIndex = 1;
      // 
      // flowLayoutPanel4
      // 
      this.flowLayoutPanel4.Controls.Add(this.label5);
      this.flowLayoutPanel4.Controls.Add(this.txtTotolNumber);
      this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel4.Location = new System.Drawing.Point(372, 30);
      this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
      this.flowLayoutPanel4.Name = "flowLayoutPanel4";
      this.flowLayoutPanel4.Size = new System.Drawing.Size(373, 30);
      this.flowLayoutPanel4.TabIndex = 5;
      // 
      // label5
      // 
      this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)));
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(3, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(101, 27);
      this.label5.TabIndex = 0;
      this.label5.Text = "送样数量（只）：";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtTotolNumber
      // 
      this.txtTotolNumber.Location = new System.Drawing.Point(110, 3);
      this.txtTotolNumber.Name = "txtTotolNumber";
      this.txtTotolNumber.Size = new System.Drawing.Size(189, 21);
      this.txtTotolNumber.TabIndex = 1;
      // 
      // flowLayoutPanel6
      // 
      this.flowLayoutPanel6.Controls.Add(this.label7);
      this.flowLayoutPanel6.Controls.Add(this.txtPartNumber);
      this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel6.Location = new System.Drawing.Point(0, 0);
      this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
      this.flowLayoutPanel6.Name = "flowLayoutPanel6";
      this.flowLayoutPanel6.Size = new System.Drawing.Size(372, 30);
      this.flowLayoutPanel6.TabIndex = 7;
      // 
      // label7
      // 
      this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)));
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(3, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(65, 27);
      this.label7.TabIndex = 0;
      this.label7.Text = "零件图号：";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtPartNumber
      // 
      this.txtPartNumber.Location = new System.Drawing.Point(74, 3);
      this.txtPartNumber.Name = "txtPartNumber";
      this.txtPartNumber.Size = new System.Drawing.Size(189, 21);
      this.txtPartNumber.TabIndex = 1;
      // 
      // flowLayoutPanel5
      // 
      this.flowLayoutPanel5.Controls.Add(this.label6);
      this.flowLayoutPanel5.Controls.Add(this.txtSampleNumber);
      this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel5.Location = new System.Drawing.Point(372, 60);
      this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
      this.flowLayoutPanel5.Name = "flowLayoutPanel5";
      this.flowLayoutPanel5.Size = new System.Drawing.Size(373, 30);
      this.flowLayoutPanel5.TabIndex = 6;
      // 
      // label6
      // 
      this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)));
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(3, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(101, 27);
      this.label6.TabIndex = 0;
      this.label6.Text = "抽样数量（只）：";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtSampleNumber
      // 
      this.txtSampleNumber.Location = new System.Drawing.Point(110, 3);
      this.txtSampleNumber.Name = "txtSampleNumber";
      this.txtSampleNumber.Size = new System.Drawing.Size(189, 21);
      this.txtSampleNumber.TabIndex = 1;
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.Controls.Add(this.label3);
      this.flowLayoutPanel1.Controls.Add(this.txtManufacturer);
      this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 60);
      this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(372, 30);
      this.flowLayoutPanel1.TabIndex = 9;
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)));
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(65, 27);
      this.label3.TabIndex = 2;
      this.label3.Text = "外协单位：";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtManufacturer
      // 
      this.txtManufacturer.Location = new System.Drawing.Point(74, 3);
      this.txtManufacturer.Name = "txtManufacturer";
      this.txtManufacturer.Size = new System.Drawing.Size(189, 21);
      this.txtManufacturer.TabIndex = 3;
      // 
      // tableApprove
      // 
      this.tableApprove.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
      this.tableApprove.ColumnCount = 3;
      this.tableApprove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.99053F));
      this.tableApprove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.00948F));
      this.tableApprove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
      this.tableApprove.Controls.Add(this.flowLayoutPanel12, 2, 2);
      this.tableApprove.Controls.Add(this.btnCreateReport, 2, 0);
      this.tableApprove.Controls.Add(this.tableLayoutPanel4, 1, 2);
      this.tableApprove.Controls.Add(this.label12, 0, 1);
      this.tableApprove.Controls.Add(this.label11, 0, 0);
      this.tableApprove.Controls.Add(this.txtOperatorComment, 1, 0);
      this.tableApprove.Controls.Add(this.label13, 0, 2);
      this.tableApprove.Controls.Add(this.tableLayoutPanel3, 1, 1);
      this.tableApprove.Controls.Add(this.flowLayoutPanel11, 2, 1);
      this.tableApprove.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableApprove.Location = new System.Drawing.Point(3, 599);
      this.tableApprove.Name = "tableApprove";
      this.tableApprove.RowCount = 3;
      this.tableApprove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableApprove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableApprove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableApprove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableApprove.Size = new System.Drawing.Size(739, 194);
      this.tableApprove.TabIndex = 9;
      // 
      // flowLayoutPanel12
      // 
      this.flowLayoutPanel12.Controls.Add(this.btnApprovePass);
      this.flowLayoutPanel12.Controls.Add(this.btnApproveFail);
      this.flowLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel12.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
      this.flowLayoutPanel12.Location = new System.Drawing.Point(614, 132);
      this.flowLayoutPanel12.Name = "flowLayoutPanel12";
      this.flowLayoutPanel12.Size = new System.Drawing.Size(121, 58);
      this.flowLayoutPanel12.TabIndex = 11;
      // 
      // btnApprovePass
      // 
      this.btnApprovePass.Location = new System.Drawing.Point(3, 3);
      this.btnApprovePass.Name = "btnApprovePass";
      this.btnApprovePass.Size = new System.Drawing.Size(75, 23);
      this.btnApprovePass.TabIndex = 9;
      this.btnApprovePass.Text = "通过";
      this.btnApprovePass.UseVisualStyleBackColor = true;
      // 
      // btnApproveFail
      // 
      this.btnApproveFail.Location = new System.Drawing.Point(3, 32);
      this.btnApproveFail.Name = "btnApproveFail";
      this.btnApproveFail.Size = new System.Drawing.Size(75, 23);
      this.btnApproveFail.TabIndex = 10;
      this.btnApproveFail.Text = "失败";
      this.btnApproveFail.UseVisualStyleBackColor = true;
      // 
      // btnCreateReport
      // 
      this.btnCreateReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)));
      this.btnCreateReport.Location = new System.Drawing.Point(617, 4);
      this.btnCreateReport.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
      this.btnCreateReport.Name = "btnCreateReport";
      this.btnCreateReport.Size = new System.Drawing.Size(75, 57);
      this.btnCreateReport.TabIndex = 4;
      this.btnCreateReport.Text = "生成报告";
      this.btnCreateReport.UseVisualStyleBackColor = true;
      // 
      // tableLayoutPanel4
      // 
      this.tableLayoutPanel4.ColumnCount = 1;
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel4.Controls.Add(this.txtApprove, 0, 0);
      this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel4.Location = new System.Drawing.Point(81, 129);
      this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel4.Name = "tableLayoutPanel4";
      this.tableLayoutPanel4.RowCount = 1;
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
      this.tableLayoutPanel4.Size = new System.Drawing.Size(529, 64);
      this.tableLayoutPanel4.TabIndex = 7;
      // 
      // txtApprove
      // 
      this.txtApprove.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtApprove.Location = new System.Drawing.Point(3, 3);
      this.txtApprove.Multiline = true;
      this.txtApprove.Name = "txtApprove";
      this.txtApprove.Size = new System.Drawing.Size(523, 58);
      this.txtApprove.TabIndex = 3;
      // 
      // label12
      // 
      this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(4, 65);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(73, 63);
      this.label12.TabIndex = 4;
      this.label12.Text = "评审:";
      this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label11
      // 
      this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(4, 1);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(73, 63);
      this.label11.TabIndex = 0;
      this.label11.Text = "检验员及\r\n结论:";
      this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // txtOperatorComment
      // 
      this.txtOperatorComment.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtOperatorComment.Location = new System.Drawing.Point(84, 4);
      this.txtOperatorComment.Multiline = true;
      this.txtOperatorComment.Name = "txtOperatorComment";
      this.txtOperatorComment.Size = new System.Drawing.Size(523, 57);
      this.txtOperatorComment.TabIndex = 3;
      // 
      // label13
      // 
      this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(4, 129);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(73, 64);
      this.label13.TabIndex = 5;
      this.label13.Text = "审批:";
      this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 1;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.Controls.Add(this.txtAudit, 0, 0);
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(81, 65);
      this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 1;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(529, 63);
      this.tableLayoutPanel3.TabIndex = 6;
      // 
      // txtAudit
      // 
      this.txtAudit.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtAudit.Location = new System.Drawing.Point(3, 3);
      this.txtAudit.Multiline = true;
      this.txtAudit.Name = "txtAudit";
      this.txtAudit.Size = new System.Drawing.Size(523, 57);
      this.txtAudit.TabIndex = 3;
      // 
      // flowLayoutPanel11
      // 
      this.flowLayoutPanel11.Controls.Add(this.btnAuditPass);
      this.flowLayoutPanel11.Controls.Add(this.btnAuditFail);
      this.flowLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel11.Location = new System.Drawing.Point(614, 68);
      this.flowLayoutPanel11.Name = "flowLayoutPanel11";
      this.flowLayoutPanel11.Size = new System.Drawing.Size(121, 57);
      this.flowLayoutPanel11.TabIndex = 10;
      // 
      // btnAuditPass
      // 
      this.btnAuditPass.Location = new System.Drawing.Point(3, 3);
      this.btnAuditPass.Name = "btnAuditPass";
      this.btnAuditPass.Size = new System.Drawing.Size(75, 23);
      this.btnAuditPass.TabIndex = 9;
      this.btnAuditPass.Text = "通过";
      this.btnAuditPass.UseVisualStyleBackColor = true;
      // 
      // btnAuditFail
      // 
      this.btnAuditFail.Location = new System.Drawing.Point(3, 32);
      this.btnAuditFail.Name = "btnAuditFail";
      this.btnAuditFail.Size = new System.Drawing.Size(75, 23);
      this.btnAuditFail.TabIndex = 10;
      this.btnAuditFail.Text = "失败";
      this.btnAuditFail.UseVisualStyleBackColor = true;
      // 
      // ExecuteReportControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoScroll = true;
      this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "ExecuteReportControl";
      this.Size = new System.Drawing.Size(745, 796);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.flowLayoutPanel8.ResumeLayout(false);
      this.flowLayoutPanel8.PerformLayout();
      this.flowLayoutPanel7.ResumeLayout(false);
      this.flowLayoutPanel7.PerformLayout();
      this.flowLayoutPanel2.ResumeLayout(false);
      this.flowLayoutPanel2.PerformLayout();
      this.flowLayoutPanel3.ResumeLayout(false);
      this.flowLayoutPanel3.PerformLayout();
      this.flowLayoutPanel4.ResumeLayout(false);
      this.flowLayoutPanel4.PerformLayout();
      this.flowLayoutPanel6.ResumeLayout(false);
      this.flowLayoutPanel6.PerformLayout();
      this.flowLayoutPanel5.ResumeLayout(false);
      this.flowLayoutPanel5.PerformLayout();
      this.flowLayoutPanel1.ResumeLayout(false);
      this.flowLayoutPanel1.PerformLayout();
      this.tableApprove.ResumeLayout(false);
      this.tableApprove.PerformLayout();
      this.flowLayoutPanel12.ResumeLayout(false);
      this.tableLayoutPanel4.ResumeLayout(false);
      this.tableLayoutPanel4.PerformLayout();
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel3.PerformLayout();
      this.flowLayoutPanel11.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox txtOperator;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox txtMeasurementDateTime;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtSecondNumber;
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
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtManufacturer;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn IndexColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn DimensionTypeEditColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn NominalColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn MeasuredColumn;
    private System.Windows.Forms.DataGridViewImageColumn StatusColumn;
    private System.Windows.Forms.Button btnCreateReport;
    private System.Windows.Forms.TableLayoutPanel tableApprove;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private System.Windows.Forms.TextBox txtApprove;
    private System.Windows.Forms.TextBox txtAudit;
    private System.Windows.Forms.TextBox txtOperatorComment;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel11;
    private System.Windows.Forms.Button btnAuditPass;
    private System.Windows.Forms.Button btnAuditFail;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel12;
    private System.Windows.Forms.Button btnApprovePass;
    private System.Windows.Forms.Button btnApproveFail;
  }
}
