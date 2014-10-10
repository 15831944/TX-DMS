using System.Windows.Forms;

namespace TxPms
{
  partial class MainForm
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.PartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.NewPartStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.SelectPartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editPartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.executePartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.BrowseReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.AuditReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ApproveReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.CadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.FitToWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.CadLayoutModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.measureToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.LeftStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.menuStrip1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PartToolStripMenuItem,
            this.ReportMenuItem,
            this.CadToolStripMenuItem,
            this.mockToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(913, 24);
      this.menuStrip1.TabIndex = 4;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // PartToolStripMenuItem
      // 
      this.PartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewPartStripMenuItem,
            this.SelectPartMenuItem,
            this.editPartMenuItem,
            this.executePartMenuItem});
      this.PartToolStripMenuItem.Name = "PartToolStripMenuItem";
      this.PartToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
      this.PartToolStripMenuItem.Text = "零件";
      // 
      // NewPartStripMenuItem
      // 
      this.NewPartStripMenuItem.Name = "NewPartStripMenuItem";
      this.NewPartStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.NewPartStripMenuItem.Text = "新建";
      this.NewPartStripMenuItem.Click += new System.EventHandler(this.NewPartStripMenuItem_Click);
      // 
      // SelectPartMenuItem
      // 
      this.SelectPartMenuItem.Name = "SelectPartMenuItem";
      this.SelectPartMenuItem.Size = new System.Drawing.Size(152, 22);
      this.SelectPartMenuItem.Text = "选择";
      this.SelectPartMenuItem.Click += new System.EventHandler(this.SelectToolStripMenuItem_Click);
      // 
      // editPartMenuItem
      // 
      this.editPartMenuItem.Name = "editPartMenuItem";
      this.editPartMenuItem.Size = new System.Drawing.Size(152, 22);
      this.editPartMenuItem.Text = "编辑";
      this.editPartMenuItem.Click += new System.EventHandler(this.editReportToolStripMenuItem_Click);
      // 
      // executePartMenuItem
      // 
      this.executePartMenuItem.Name = "executePartMenuItem";
      this.executePartMenuItem.Size = new System.Drawing.Size(152, 22);
      this.executePartMenuItem.Text = "执行";
      this.executePartMenuItem.Click += new System.EventHandler(this.executeReportToolStripMenuItem_Click);
      // 
      // ReportMenuItem
      // 
      this.ReportMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BrowseReportMenuItem,
            this.AuditReportMenuItem,
            this.ApproveReportMenuItem});
      this.ReportMenuItem.Name = "ReportMenuItem";
      this.ReportMenuItem.Size = new System.Drawing.Size(41, 20);
      this.ReportMenuItem.Text = "报告";
      // 
      // BrowseReportMenuItem
      // 
      this.BrowseReportMenuItem.Name = "BrowseReportMenuItem";
      this.BrowseReportMenuItem.Size = new System.Drawing.Size(94, 22);
      this.BrowseReportMenuItem.Text = "查看";
      // 
      // AuditReportMenuItem
      // 
      this.AuditReportMenuItem.Name = "AuditReportMenuItem";
      this.AuditReportMenuItem.Size = new System.Drawing.Size(94, 22);
      this.AuditReportMenuItem.Text = "评审";
      // 
      // ApproveReportMenuItem
      // 
      this.ApproveReportMenuItem.Name = "ApproveReportMenuItem";
      this.ApproveReportMenuItem.Size = new System.Drawing.Size(94, 22);
      this.ApproveReportMenuItem.Text = "审批";
      // 
      // CadToolStripMenuItem
      // 
      this.CadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FitToWindowToolStripMenuItem,
            this.CadLayoutModeToolStripMenuItem});
      this.CadToolStripMenuItem.Name = "CadToolStripMenuItem";
      this.CadToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
      this.CadToolStripMenuItem.Text = "CAD窗口";
      // 
      // FitToWindowToolStripMenuItem
      // 
      this.FitToWindowToolStripMenuItem.Name = "FitToWindowToolStripMenuItem";
      this.FitToWindowToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
      this.FitToWindowToolStripMenuItem.Text = "适应窗口";
      // 
      // CadLayoutModeToolStripMenuItem
      // 
      this.CadLayoutModeToolStripMenuItem.Name = "CadLayoutModeToolStripMenuItem";
      this.CadLayoutModeToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
      this.CadLayoutModeToolStripMenuItem.Text = "显示模式";
      // 
      // mockToolStripMenuItem
      // 
      this.mockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.measureToolToolStripMenuItem});
      this.mockToolStripMenuItem.Name = "mockToolStripMenuItem";
      this.mockToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
      this.mockToolStripMenuItem.Text = "模拟";
      // 
      // measureToolToolStripMenuItem
      // 
      this.measureToolToolStripMenuItem.Name = "measureToolToolStripMenuItem";
      this.measureToolToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
      this.measureToolToolStripMenuItem.Text = "量具";
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LeftStripStatusLabel});
      this.statusStrip1.Location = new System.Drawing.Point(0, 600);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(913, 22);
      this.statusStrip1.TabIndex = 5;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // LeftStripStatusLabel
      // 
      this.LeftStripStatusLabel.Name = "LeftStripStatusLabel";
      this.LeftStripStatusLabel.Size = new System.Drawing.Size(0, 17);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(913, 622);
      _CadForm = new CadForm();
      _CadForm.Dock = DockStyle.Fill;
      this.Controls.Add(_CadForm);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.Name = "MainForm";
      this.Text = "MainForm";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem PartToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem NewPartStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem SelectPartMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editPartMenuItem;
    private System.Windows.Forms.ToolStripMenuItem executePartMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ReportMenuItem;
    private System.Windows.Forms.ToolStripMenuItem BrowseReportMenuItem;
    private System.Windows.Forms.ToolStripMenuItem AuditReportMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ApproveReportMenuItem;
    private System.Windows.Forms.ToolStripMenuItem CadToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem FitToWindowToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem CadLayoutModeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mockToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem measureToolToolStripMenuItem;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel LeftStripStatusLabel;

    private CadForm _CadForm;

  }
}