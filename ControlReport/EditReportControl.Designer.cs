namespace ControlReport
{
  partial class EditReportControl
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
      this.label4 = new System.Windows.Forms.Label();
      this.txtPartName = new System.Windows.Forms.TextBox();
      this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
      this.label7 = new System.Windows.Forms.Label();
      this.txtPartNumber = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.IndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DimensionTypeEditColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NominalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.PlusTolColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.MinusTolColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnAddCadFile = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.flowLayoutPanel3.SuspendLayout();
      this.flowLayoutPanel4.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(580, 600);
      this.tableLayoutPanel1.TabIndex = 1;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel4, 1, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 10);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(580, 30);
      this.tableLayoutPanel2.TabIndex = 3;
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
      this.txtPartName.Size = new System.Drawing.Size(161, 20);
      this.txtPartName.TabIndex = 1;
      // 
      // flowLayoutPanel4
      // 
      this.flowLayoutPanel4.Controls.Add(this.label7);
      this.flowLayoutPanel4.Controls.Add(this.txtPartNumber);
      this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel4.Location = new System.Drawing.Point(290, 0);
      this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
      this.flowLayoutPanel4.Name = "flowLayoutPanel4";
      this.flowLayoutPanel4.Size = new System.Drawing.Size(290, 30);
      this.flowLayoutPanel4.TabIndex = 5;
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
      this.txtPartNumber.Size = new System.Drawing.Size(161, 20);
      this.txtPartNumber.TabIndex = 1;
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 1;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.Controls.Add(this.dataGridView1, 0, 0);
      this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 1);
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 43);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 2;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(574, 554);
      this.tableLayoutPanel3.TabIndex = 4;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
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
            this.PlusTolColumn,
            this.MinusTolColumn});
      this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
      this.dataGridView1.Location = new System.Drawing.Point(1, 8);
      this.dataGridView1.Margin = new System.Windows.Forms.Padding(1, 8, 1, 1);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(572, 485);
      this.dataGridView1.TabIndex = 5;
      // 
      // IndexColumn
      // 
      this.IndexColumn.DataPropertyName = "Index";
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
      this.DimensionTypeEditColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.DimensionTypeEditColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.DimensionTypeEditColumn.Width = 65;
      // 
      // NominalColumn
      // 
      this.NominalColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.NominalColumn.DataPropertyName = "Nominal";
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      this.NominalColumn.DefaultCellStyle = dataGridViewCellStyle3;
      this.NominalColumn.HeaderText = "理论值";
      this.NominalColumn.Name = "NominalColumn";
      this.NominalColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.NominalColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // PlusTolColumn
      // 
      this.PlusTolColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.PlusTolColumn.DataPropertyName = "PlusTol";
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      this.PlusTolColumn.DefaultCellStyle = dataGridViewCellStyle4;
      this.PlusTolColumn.HeaderText = "上公差";
      this.PlusTolColumn.Name = "PlusTolColumn";
      // 
      // MinusTolColumn
      // 
      this.MinusTolColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.MinusTolColumn.DataPropertyName = "MinusTol";
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      this.MinusTolColumn.DefaultCellStyle = dataGridViewCellStyle5;
      this.MinusTolColumn.HeaderText = "下公差";
      this.MinusTolColumn.Name = "MinusTolColumn";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnAddCadFile);
      this.panel1.Controls.Add(this.btnSave);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(3, 497);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(568, 54);
      this.panel1.TabIndex = 6;
      // 
      // btnAddCadFile
      // 
      this.btnAddCadFile.Location = new System.Drawing.Point(158, 13);
      this.btnAddCadFile.Name = "btnAddCadFile";
      this.btnAddCadFile.Size = new System.Drawing.Size(67, 23);
      this.btnAddCadFile.TabIndex = 2;
      this.btnAddCadFile.Text = "Cad文件";
      this.btnAddCadFile.UseVisualStyleBackColor = true;
      this.btnAddCadFile.Click += new System.EventHandler(this.btnAddCadFile_Click);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(273, 13);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 1;
      this.btnSave.Text = "保存";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // EditReportControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Margin = new System.Windows.Forms.Padding(1, 8, 1, 1);
      this.Name = "EditReportControl";
      this.Size = new System.Drawing.Size(580, 600);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
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

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtPartNumber;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtPartName;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnAddCadFile;
    private System.Windows.Forms.DataGridViewTextBoxColumn IndexColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn DimensionTypeEditColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn NominalColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn PlusTolColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn MinusTolColumn;
  }
}
