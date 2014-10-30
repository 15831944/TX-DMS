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
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.partToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newPartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editPartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.executeTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.CadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.measureToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1 = new System.Windows.Forms.Panel();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.saveAsFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.splitter1 = new System.Windows.Forms.Splitter();
      this.DimensionReportContainer = new System.Windows.Forms.Panel();
      this.menuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip
      // 
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partToolStripMenuItem,
            this.taskToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.mockToolStripMenuItem});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new System.Drawing.Size(852, 25);
      this.menuStrip.TabIndex = 0;
      this.menuStrip.Text = "menuStrip1";
      // 
      // partToolStripMenuItem
      // 
      this.partToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPartToolStripMenuItem,
            this.openToolStripMenuItem,
            this.editPartToolStripMenuItem});
      this.partToolStripMenuItem.Name = "partToolStripMenuItem";
      this.partToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
      this.partToolStripMenuItem.Text = "工件";
      // 
      // newPartToolStripMenuItem
      // 
      this.newPartToolStripMenuItem.Name = "newPartToolStripMenuItem";
      this.newPartToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
      this.newPartToolStripMenuItem.Text = "新建";
      this.newPartToolStripMenuItem.Click += new System.EventHandler(this.newPartToolStripMenuItem_Click);
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
      this.openToolStripMenuItem.Text = "打开";
      this.openToolStripMenuItem.Click += new System.EventHandler(this.part_open_handler);
      // 
      // editPartToolStripMenuItem
      // 
      this.editPartToolStripMenuItem.Name = "editPartToolStripMenuItem";
      this.editPartToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
      this.editPartToolStripMenuItem.Text = "编辑";
      // 
      // taskToolStripMenuItem
      // 
      this.taskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTaskToolStripMenuItem,
            this.editTaskToolStripMenuItem,
            this.executeTaskToolStripMenuItem});
      this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
      this.taskToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
      this.taskToolStripMenuItem.Text = "任务";
      // 
      // newTaskToolStripMenuItem
      // 
      this.newTaskToolStripMenuItem.Name = "newTaskToolStripMenuItem";
      this.newTaskToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
      this.newTaskToolStripMenuItem.Text = "新建";
      this.newTaskToolStripMenuItem.Click += new System.EventHandler(this.newTaskToolStripMenuItem_Click);
      // 
      // editTaskToolStripMenuItem
      // 
      this.editTaskToolStripMenuItem.Name = "editTaskToolStripMenuItem";
      this.editTaskToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
      this.editTaskToolStripMenuItem.Text = "编辑";
      // 
      // executeTaskToolStripMenuItem
      // 
      this.executeTaskToolStripMenuItem.Name = "executeTaskToolStripMenuItem";
      this.executeTaskToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
      this.executeTaskToolStripMenuItem.Text = "执行";
      this.executeTaskToolStripMenuItem.Click += new System.EventHandler(this.executeTaskToolStripMenuItem_Click);
      // 
      // viewToolStripMenuItem
      // 
      this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CadToolStripMenuItem,
            this.reportToolStripMenuItem});
      this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
      this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
      this.viewToolStripMenuItem.Text = "窗口";
      // 
      // CadToolStripMenuItem
      // 
      this.CadToolStripMenuItem.Name = "CadToolStripMenuItem";
      this.CadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
      this.CadToolStripMenuItem.Text = "图形";
      // 
      // reportToolStripMenuItem
      // 
      this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
      this.reportToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
      this.reportToolStripMenuItem.Text = "报告";
      // 
      // mockToolStripMenuItem
      // 
      this.mockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.measureToolToolStripMenuItem});
      this.mockToolStripMenuItem.Name = "mockToolStripMenuItem";
      this.mockToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
      this.mockToolStripMenuItem.Text = "模拟";
      // 
      // measureToolToolStripMenuItem
      // 
      this.measureToolToolStripMenuItem.Name = "measureToolToolStripMenuItem";
      this.measureToolToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
      this.measureToolToolStripMenuItem.Text = "量具";
      // 
      // panel1
      // 
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.Enabled = false;
      this.panel1.Location = new System.Drawing.Point(0, 25);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(596, 467);
      this.panel1.TabIndex = 1;
      this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
      this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
      this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
      this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
      this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
      // 
      // openFileDialog
      // 
      this.openFileDialog.DefaultExt = "DWG";
      this.openFileDialog.Filter = "DWG files|*.dwg|DXF files|*.dxf";
      // 
      // saveAsFileDialog
      // 
      this.saveAsFileDialog.DefaultExt = "DWG";
      this.saveAsFileDialog.Filter = "\"DWG files|*.dwg|DXF files|*.dxf\"";
      // 
      // splitter1
      // 
      this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.splitter1.Location = new System.Drawing.Point(596, 25);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(3, 467);
      this.splitter1.TabIndex = 2;
      this.splitter1.TabStop = false;
      // 
      // DimensionReportContainer
      // 
      this.DimensionReportContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DimensionReportContainer.Location = new System.Drawing.Point(599, 25);
      this.DimensionReportContainer.Name = "DimensionReportContainer";
      this.DimensionReportContainer.Size = new System.Drawing.Size(253, 467);
      this.DimensionReportContainer.TabIndex = 3;
      // 
      // CadForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(852, 492);
      this.Controls.Add(this.DimensionReportContainer);
      this.Controls.Add(this.splitter1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.menuStrip);
      this.MainMenuStrip = this.menuStrip;
      this.Name = "CadForm";
      this.Text = "外协件检验系统";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem partToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.SaveFileDialog saveAsFileDialog;
    private Splitter splitter1;
    private ToolStripMenuItem newPartToolStripMenuItem;
    private ToolStripMenuItem editPartToolStripMenuItem;
    private ToolStripMenuItem taskToolStripMenuItem;
    private ToolStripMenuItem newTaskToolStripMenuItem;
    private ToolStripMenuItem editTaskToolStripMenuItem;
    private ToolStripMenuItem executeTaskToolStripMenuItem;
    private ToolStripMenuItem viewToolStripMenuItem;
    private ToolStripMenuItem CadToolStripMenuItem;
    private ToolStripMenuItem reportToolStripMenuItem;
    private ToolStripMenuItem mockToolStripMenuItem;
    private ToolStripMenuItem measureToolToolStripMenuItem;
    private Panel DimensionReportContainer;
  }
}

