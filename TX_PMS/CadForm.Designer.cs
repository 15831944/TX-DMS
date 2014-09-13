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
      this.panel1 = new System.Windows.Forms.Panel();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.saveAsFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.editReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.executeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.CadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.FitToWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.CadLayoutModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this._ExecuteReportControl = new ControlReport.ExecuteReportControl();
      this._EditReportControl = new EditReportControl();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPageExecute = new System.Windows.Forms.TabPage();
      this.tabPageEdit = new System.Windows.Forms.TabPage();

      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPageExecute.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Enabled = false;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(871, 591);
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
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.IsSplitterFixed = true;
      this.splitContainer1.Location = new System.Drawing.Point(0, 24);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.panel1);
      this.splitContainer1.Size = new System.Drawing.Size(1290, 591);
      this.splitContainer1.SplitterDistance = 418;
      this.splitContainer1.SplitterWidth = 1;
      this.splitContainer1.TabIndex = 2;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ReportToolStripMenuItem,
            this.CadToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1290, 24);
      this.menuStrip1.TabIndex = 3;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // FileToolStripMenuItem
      // 
      this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem});
      this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
      this.FileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.FileToolStripMenuItem.Text = "文件";
      // 
      // OpenToolStripMenuItem
      // 
      this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
      this.OpenToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
      this.OpenToolStripMenuItem.Text = "打开";
      this.OpenToolStripMenuItem.Click += new System.EventHandler(this.file_open_handler);
      // 
      // ReportToolStripMenuItem
      // 
      this.ReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editReportToolStripMenuItem,
            this.executeReportToolStripMenuItem});
      this.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem";
      this.ReportToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.ReportToolStripMenuItem.Text = "报告";
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
      this.toolStripMenuItem1.Text = "选择";
      this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
      // 
      // editReportToolStripMenuItem
      // 
      this.editReportToolStripMenuItem.Name = "editReportToolStripMenuItem";
      this.editReportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.editReportToolStripMenuItem.Text = "编辑";
      this.editReportToolStripMenuItem.Click += new System.EventHandler(this.editReportToolStripMenuItem_Click);
      // 
      // executeReportToolStripMenuItem
      // 
      this.executeReportToolStripMenuItem.Name = "executeReportToolStripMenuItem";
      this.executeReportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.executeReportToolStripMenuItem.Text = "执行";
      this.executeReportToolStripMenuItem.Click += new System.EventHandler(this.executeReportToolStripMenuItem_Click);
      // 
      // CadToolStripMenuItem
      // 
      this.CadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FitToWindowToolStripMenuItem,
            this.CadLayoutModeToolStripMenuItem});
      this.CadToolStripMenuItem.Name = "CadToolStripMenuItem";
      this.CadToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
      this.CadToolStripMenuItem.Text = "CAD窗口";
      // 
      // FitToWindowToolStripMenuItem
      // 
      this.FitToWindowToolStripMenuItem.Name = "FitToWindowToolStripMenuItem";
      this.FitToWindowToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
      this.FitToWindowToolStripMenuItem.Text = "适应窗口";
      this.FitToWindowToolStripMenuItem.Click += new System.EventHandler(this.zoom_extents_handler);
      // 
      // CadLayoutModeToolStripMenuItem
      // 
      this.CadLayoutModeToolStripMenuItem.Name = "CadLayoutModeToolStripMenuItem";
      this.CadLayoutModeToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
      this.CadLayoutModeToolStripMenuItem.Text = "显示模式";
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPageExecute);
      this.tabControl1.Controls.Add(this.tabPageEdit);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(418, 591);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPageExecute
      // 
      this.tabPageExecute.Controls.Add(this._ExecuteReportControl);
      this.tabPageExecute.Location = new System.Drawing.Point(4, 22);
      this.tabPageExecute.Name = "tabPageExecute";
      this.tabPageExecute.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageExecute.Size = new System.Drawing.Size(410, 565);
      this.tabPageExecute.TabIndex = 1;
      this.tabPageExecute.Text = "执行";
      this.tabPageExecute.UseVisualStyleBackColor = true;
      // 
      // tabPageEdit
      // 
      this.tabPageEdit.Controls.Add(_EditReportControl);
      this.tabPageEdit.Location = new System.Drawing.Point(4, 22);
      this.tabPageEdit.Name = "tabPageEdit";
      this.tabPageEdit.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageEdit.Size = new System.Drawing.Size(410, 565);
      this.tabPageEdit.TabIndex = 2;
      this.tabPageEdit.Text = "编辑";
      this.tabPageEdit.UseVisualStyleBackColor = true;
      // 
      // _UserControlReport
      // 
      this._ExecuteReportControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this._ExecuteReportControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this._ExecuteReportControl.Location = new System.Drawing.Point(3, 3);
      this._ExecuteReportControl.Name = "_UserControlReport";
      this._ExecuteReportControl.Size = new System.Drawing.Size(404, 559);
      this._ExecuteReportControl.TabIndex = 2;
      // 
      // _UserControlReport
      // 
      this._EditReportControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this._EditReportControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this._EditReportControl.Location = new System.Drawing.Point(3, 3);
      this._ExecuteReportControl.Name = "_ExecuteReportControl";
      this._ExecuteReportControl.Size = new System.Drawing.Size(404, 559);
      this._ExecuteReportControl.TabIndex = 3;
      // 
      // CadForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1290, 615);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.menuStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabPageExecute.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.SaveFileDialog saveAsFileDialog;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem CadToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem FitToWindowToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem CadLayoutModeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ReportToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editReportToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem executeReportToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPageExecute;
    private System.Windows.Forms.TabPage tabPageEdit;
    private ExecuteReportControl _ExecuteReportControl;
    private EditReportControl _EditReportControl;
  }
}

