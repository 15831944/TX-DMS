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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.LeftStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.qRibbonPanel1 = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
      this.qCompositeMenuItem3 = new Qios.DevSuite.Components.QCompositeMenuItem();
      this.qCompositeMenuItem4 = new Qios.DevSuite.Components.QCompositeMenuItem();
      this.qDockBarLeft = new Qios.DevSuite.Components.QDockBar();
      this.qDockBarBottom = new Qios.DevSuite.Components.QDockBar();
      this.qDockBarRight = new Qios.DevSuite.Components.QDockBar();
      this.qRibbonPanel2 = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
      this.qRibbon1 = new Qios.DevSuite.Components.Ribbon.QRibbon();
      this.qRibbonPage1 = new Qios.DevSuite.Components.Ribbon.QRibbonPage();
      this.qRibbonPanel3 = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
      this.qRibbonItem1 = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
      this.qRibbonPanel4 = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
      this.qRibbonItem2 = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
      this.qRibbonPanel5 = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
      this.qRibbonItem3 = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
      this.qRibbonPage2 = new Qios.DevSuite.Components.Ribbon.QRibbonPage();
      this.qRibbonPanel6 = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
      this.qRibbonItem4 = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
      this.statusStrip1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.qRibbon1)).BeginInit();
      this.qRibbon1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.qRibbonPage1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.qRibbonPage2)).BeginInit();
      this.SuspendLayout();
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
      this.NewPartStripMenuItem.Size = new System.Drawing.Size(94, 22);
      this.NewPartStripMenuItem.Text = "新建";
      this.NewPartStripMenuItem.Click += new System.EventHandler(this.NewPartStripMenuItem_Click);
      // 
      // SelectPartMenuItem
      // 
      this.SelectPartMenuItem.Name = "SelectPartMenuItem";
      this.SelectPartMenuItem.Size = new System.Drawing.Size(94, 22);
      this.SelectPartMenuItem.Text = "选择";
      this.SelectPartMenuItem.Click += new System.EventHandler(this.SelectToolStripMenuItem_Click);
      // 
      // editPartMenuItem
      // 
      this.editPartMenuItem.Name = "editPartMenuItem";
      this.editPartMenuItem.Size = new System.Drawing.Size(94, 22);
      this.editPartMenuItem.Text = "编辑";
      this.editPartMenuItem.Click += new System.EventHandler(this.editReportToolStripMenuItem_Click);
      // 
      // executePartMenuItem
      // 
      this.executePartMenuItem.Name = "executePartMenuItem";
      this.executePartMenuItem.Size = new System.Drawing.Size(94, 22);
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
      // qRibbonPanel1
      // 
      this.qRibbonPanel1.Title = "qRibbonPanel1";
      // 
      // qCompositeMenuItem3
      // 
      this.qCompositeMenuItem3.Title = "编辑";
      // 
      // qCompositeMenuItem4
      // 
      this.qCompositeMenuItem4.Title = "执行";
      // 
      // qDockBarLeft
      // 
      this.qDockBarLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.qDockBarLeft.Location = new System.Drawing.Point(0, 131);
      this.qDockBarLeft.Name = "qDockBarLeft";
      this.qDockBarLeft.PersistGuid = new System.Guid("1ebab76d-f39e-4275-b798-7884460bca14");
      this.qDockBarLeft.Size = new System.Drawing.Size(22, 469);
      this.qDockBarLeft.TabIndex = 6;
      this.qDockBarLeft.Text = "qDockBar1";
      // 
      // qDockBarBottom
      // 
      this.qDockBarBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.qDockBarBottom.Location = new System.Drawing.Point(22, 578);
      this.qDockBarBottom.Name = "qDockBarBottom";
      this.qDockBarBottom.PersistGuid = new System.Guid("5abadc58-e97d-45c7-a1b5-9162b21d79fc");
      this.qDockBarBottom.Size = new System.Drawing.Size(891, 22);
      this.qDockBarBottom.TabIndex = 7;
      this.qDockBarBottom.Text = "qDockBar2";
      // 
      // qDockBarRight
      // 
      this.qDockBarRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.qDockBarRight.Location = new System.Drawing.Point(891, 131);
      this.qDockBarRight.Name = "qDockBarRight";
      this.qDockBarRight.PersistGuid = new System.Guid("293bc58e-3352-473e-9d1c-dbf044ae5f57");
      this.qDockBarRight.Size = new System.Drawing.Size(22, 447);
      this.qDockBarRight.TabIndex = 8;
      this.qDockBarRight.Text = "qDockBar3";
      // 
      // qRibbonPanel2
      // 
      this.qRibbonPanel2.Title = "qRibbonPanel2";
      // 
      // qRibbon1
      // 
      this.qRibbon1.ActiveTabPage = this.qRibbonPage1;
      this.qRibbon1.Controls.Add(this.qRibbonPage1);
      this.qRibbon1.Controls.Add(this.qRibbonPage2);
      this.qRibbon1.Cursor = System.Windows.Forms.Cursors.Default;
      this.qRibbon1.Dock = System.Windows.Forms.DockStyle.Top;
      this.qRibbon1.Location = new System.Drawing.Point(0, 24);
      this.qRibbon1.Name = "qRibbon1";
      this.qRibbon1.PersistGuid = new System.Guid("674c053e-6661-40ed-a8ca-47a4d347ee9d");
      this.qRibbon1.Size = new System.Drawing.Size(913, 107);
      this.qRibbon1.TabIndex = 11;
      this.qRibbon1.Text = "qRibbon1";
      // 
      // qRibbonPage1
      // 
      this.qRibbonPage1.ButtonOrder = 0;
      this.qRibbonPage1.Items.Add(this.qRibbonPanel3);
      this.qRibbonPage1.Items.Add(this.qRibbonPanel4);
      this.qRibbonPage1.Items.Add(this.qRibbonPanel5);
      this.qRibbonPage1.Location = new System.Drawing.Point(2, 29);
      this.qRibbonPage1.Name = "qRibbonPage1";
      this.qRibbonPage1.PersistGuid = new System.Guid("446d545b-30dc-40fc-ac6c-8c4d715deecf");
      this.qRibbonPage1.Size = new System.Drawing.Size(907, 74);
      this.qRibbonPage1.Text = "零件";
      // 
      // qRibbonPanel3
      // 
      this.qRibbonPanel3.Items.Add(this.qRibbonItem1);
      this.qRibbonPanel3.Title = "";
      // 
      // qRibbonItem1
      // 
      this.qRibbonItem1.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(40, 40);
      this.qRibbonItem1.ControlSize = new System.Drawing.Size(30, 30);
      this.qRibbonItem1.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItem1.Icon")));
      this.qRibbonItem1.Title = "新建";
      // 
      // qRibbonPanel4
      // 
      this.qRibbonPanel4.Items.Add(this.qRibbonItem2);
      this.qRibbonPanel4.Title = "";
      // 
      // qRibbonItem2
      // 
      this.qRibbonItem2.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(40, 40);
      this.qRibbonItem2.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItem2.Icon")));
      this.qRibbonItem2.Title = "编辑";
      // 
      // qRibbonPanel5
      // 
      this.qRibbonPanel5.Items.Add(this.qRibbonItem3);
      this.qRibbonPanel5.Title = "";
      // 
      // qRibbonItem3
      // 
      this.qRibbonItem3.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(40, 40);
      this.qRibbonItem3.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItem3.Icon")));
      this.qRibbonItem3.Title = "执行";
      // 
      // qRibbonPage2
      // 
      this.qRibbonPage2.ButtonOrder = 0;
      this.qRibbonPage2.Items.Add(this.qRibbonPanel6);
      this.qRibbonPage2.Location = new System.Drawing.Point(2, 29);
      this.qRibbonPage2.Name = "qRibbonPage2";
      this.qRibbonPage2.PersistGuid = new System.Guid("7ec692ff-e11e-4d31-86ab-e44c34130bc3");
      this.qRibbonPage2.Size = new System.Drawing.Size(863, 74);
      this.qRibbonPage2.Text = "模拟";
      // 
      // qRibbonPanel6
      // 
      this.qRibbonPanel6.Items.Add(this.qRibbonItem4);
      this.qRibbonPanel6.Title = "";
      // 
      // qRibbonItem4
      // 
      this.qRibbonItem4.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(40, 40);
      this.qRibbonItem4.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItem4.Icon")));
      this.qRibbonItem4.Title = "量具";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(913, 622);
      this.Controls.Add(this.qDockBarRight);
      this.Controls.Add(this.qDockBarBottom);
      this.Controls.Add(this.qDockBarLeft);
      this.Controls.Add(this.qRibbon1);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.IsMdiContainer = true;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "MainForm";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.qRibbon1)).EndInit();
      this.qRibbon1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.qRibbonPage1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.qRibbonPage2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel LeftStripStatusLabel;

    private ToolStripMenuItem PartToolStripMenuItem;
    private ToolStripMenuItem NewPartStripMenuItem;
    private ToolStripMenuItem SelectPartMenuItem;
    private ToolStripMenuItem editPartMenuItem;
    private ToolStripMenuItem executePartMenuItem;
    private ToolStripMenuItem ReportMenuItem;
    private ToolStripMenuItem BrowseReportMenuItem;
    private ToolStripMenuItem AuditReportMenuItem;
    private ToolStripMenuItem ApproveReportMenuItem;
    private ToolStripMenuItem CadToolStripMenuItem;
    private ToolStripMenuItem FitToWindowToolStripMenuItem;
    private ToolStripMenuItem CadLayoutModeToolStripMenuItem;
    private ToolStripMenuItem mockToolStripMenuItem;
    private ToolStripMenuItem measureToolToolStripMenuItem;
    private MenuStrip menuStrip1;
    private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanel1;
    private Qios.DevSuite.Components.QCompositeMenuItem qCompositeMenuItem3;
    private Qios.DevSuite.Components.QCompositeMenuItem qCompositeMenuItem4;
    private Qios.DevSuite.Components.QDockBar qDockBarLeft;
    private Qios.DevSuite.Components.QDockBar qDockBarBottom;
    private Qios.DevSuite.Components.QDockBar qDockBarRight;
    private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanel2;
    private Qios.DevSuite.Components.Ribbon.QRibbon qRibbon1;
    private Qios.DevSuite.Components.Ribbon.QRibbonPage qRibbonPage1;
    private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanel3;
    private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItem1;
    private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanel4;
    private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItem2;
    private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanel5;
    private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItem3;
    private Qios.DevSuite.Components.Ribbon.QRibbonPage qRibbonPage2;
    private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanel6;
    private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItem4;

  }
}