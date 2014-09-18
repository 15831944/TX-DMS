///////////////////////////////////////////////////////////////////////////////
// Copyright © 2009-2010, Open Design Alliance (the "Alliance") 
// 
// This software is owned by the Alliance, and may only be incorporated into 
// application programs owned by members of the Alliance subject to a signed 
// Membership Agreement and Supplemental Software License Agreement with the
// Alliance. The structure and organization of this software are the valuable 
// trade secrets of the Alliance and its suppliers. The software is also 
// protected by copyright law and international treaty provisions. Application 
// programs incorporating this software must include the following statement 
// with their copyright notices:
//
// Teigha™.NET for .dwg files 2009-2010 by Open Design Alliance. All rights reserved.
//
// By use of this software, you acknowledge and accept these terms.
//
//
// *DWG is the native and proprietary file format for AutoCAD® and a trademark 
// of Autodesk, Inc. The Open Design Alliance is not associated with Autodesk.
///////////////////////////////////////////////////////////////////////////////

using System.Windows.Forms;
using ControlReport;

namespace TxPms
{
  partial class CadForm
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
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.saveAsFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.panelReportContainer = new System.Windows.Forms.Panel();
      this.panelGraphicContainer = new System.Windows.Forms.Panel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.LeftStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.ReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.NewPartStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.editReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.executeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.CadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.FitToWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.CadLayoutModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.measureToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editReportControl1 = new ControlReport.EditReportControl();
      this.executeReportControl1 = new ControlReport.ExecuteReportControl();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.panelGraphicContainer.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // openFileDialog
      // 
      this.openFileDialog.DefaultExt = "DWG";
      this.openFileDialog.Filter = "DWG files|*.dwg";
      // 
      // saveAsFileDialog
      // 
      this.saveAsFileDialog.DefaultExt = "DWG";
      this.saveAsFileDialog.Filter = "\"DWG files|*.dwg\"";
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.IsSplitterFixed = true;
      this.splitContainer1.Location = new System.Drawing.Point(0, 24);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.panelReportContainer);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.panelGraphicContainer);
      this.splitContainer1.Size = new System.Drawing.Size(1290, 522);
      this.splitContainer1.SplitterDistance = 418;
      this.splitContainer1.SplitterWidth = 1;
      this.splitContainer1.TabIndex = 2;
      // 
      // panelReportContainer
      // 
      this.panelReportContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panelReportContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelReportContainer.Location = new System.Drawing.Point(0, 0);
      this.panelReportContainer.Name = "panelReportContainer";
      this.panelReportContainer.Size = new System.Drawing.Size(418, 522);
      this.panelReportContainer.TabIndex = 0;
      // 
      // panelGraphicContainer
      // 
      this.panelGraphicContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panelGraphicContainer.Controls.Add(this.panel1);
      this.panelGraphicContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelGraphicContainer.Location = new System.Drawing.Point(0, 0);
      this.panelGraphicContainer.Name = "panelGraphicContainer";
      this.panelGraphicContainer.Size = new System.Drawing.Size(871, 522);
      this.panelGraphicContainer.TabIndex = 2;
      // 
      // panel1
      // 
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Enabled = false;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(867, 518);
      this.panel1.TabIndex = 1;
      this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
      this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
      this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
      this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
      this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LeftStripStatusLabel});
      this.statusStrip1.Location = new System.Drawing.Point(0, 546);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(1290, 22);
      this.statusStrip1.TabIndex = 0;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // LeftStripStatusLabel
      // 
      this.LeftStripStatusLabel.Name = "LeftStripStatusLabel";
      this.LeftStripStatusLabel.Size = new System.Drawing.Size(0, 17);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReportToolStripMenuItem,
            this.CadToolStripMenuItem,
            this.mockToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1290, 24);
      this.menuStrip1.TabIndex = 3;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // ReportToolStripMenuItem
      // 
      this.ReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewPartStripMenuItem,
            this.toolStripMenuItem1,
            this.editReportToolStripMenuItem,
            this.executeReportToolStripMenuItem});
      this.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem";
      this.ReportToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
      this.ReportToolStripMenuItem.Text = "报告";
      // 
      // NewPartStripMenuItem
      // 
      this.NewPartStripMenuItem.Name = "NewPartStripMenuItem";
      this.NewPartStripMenuItem.Size = new System.Drawing.Size(94, 22);
      this.NewPartStripMenuItem.Text = "新建";
      this.NewPartStripMenuItem.Click += new System.EventHandler(this.NewPartStripMenuItem_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 22);
      this.toolStripMenuItem1.Text = "选择";
      this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
      // 
      // editReportToolStripMenuItem
      // 
      this.editReportToolStripMenuItem.Name = "editReportToolStripMenuItem";
      this.editReportToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
      this.editReportToolStripMenuItem.Text = "编辑";
      this.editReportToolStripMenuItem.Click += new System.EventHandler(this.editReportToolStripMenuItem_Click);
      // 
      // executeReportToolStripMenuItem
      // 
      this.executeReportToolStripMenuItem.Name = "executeReportToolStripMenuItem";
      this.executeReportToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
      this.executeReportToolStripMenuItem.Text = "执行";
      this.executeReportToolStripMenuItem.Click += new System.EventHandler(this.executeReportToolStripMenuItem_Click);
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
      this.FitToWindowToolStripMenuItem.Click += new System.EventHandler(this.zoom_extents_handler);
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
      this.measureToolToolStripMenuItem.Click += new System.EventHandler(this.measureToolToolStripMenuItem_Click);
      // 
      // editReportControl1
      // 
      this.editReportControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.editReportControl1.Location = new System.Drawing.Point(1, 0);
      this.editReportControl1.Margin = new System.Windows.Forms.Padding(1, 8, 1, 1);
      this.editReportControl1.Name = "editReportControl1";
      this.editReportControl1.Size = new System.Drawing.Size(414, 610);
      this.editReportControl1.TabIndex = 0;
      // 
      // executeReportControl1
      // 
      this.executeReportControl1.AutoScroll = true;
      this.executeReportControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.executeReportControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.executeReportControl1.Location = new System.Drawing.Point(3, 5);
      this.executeReportControl1.Margin = new System.Windows.Forms.Padding(1);
      this.executeReportControl1.Name = "executeReportControl1";
      this.executeReportControl1.Size = new System.Drawing.Size(412, 600);
      this.executeReportControl1.TabIndex = 0;
      // 
      // CadForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1290, 568);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.statusStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "CadForm";
      this.Text = "外协件检验系统";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.ResumeLayout(false);
      this.panelGraphicContainer.ResumeLayout(false);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.SaveFileDialog saveAsFileDialog;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem CadToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem FitToWindowToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem CadLayoutModeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ReportToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editReportToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem executeReportToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private EditReportControl editReportControl1;
    private ExecuteReportControl executeReportControl1;
    private ToolStripMenuItem NewPartStripMenuItem;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel LeftStripStatusLabel;
    private ToolStripMenuItem mockToolStripMenuItem;
    private ToolStripMenuItem measureToolToolStripMenuItem;
    private Panel panelGraphicContainer;
    private Panel panel1;
    private Panel panelReportContainer;
  }
}

