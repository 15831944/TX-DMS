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
      this.editReportControl1 = new ControlReport.EditReportControl();
      this.executeReportControl1 = new ControlReport.ExecuteReportControl();
      this.panel1 = new System.Windows.Forms.Panel();
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
      // panel1
      // 
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Enabled = false;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1282, 534);
      this.panel1.TabIndex = 5;
      this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
      this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
      this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
      this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
      this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
      // 
      // CadForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1282, 534);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
      this.Name = "CadForm";
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.SaveFileDialog saveAsFileDialog;
    private EditReportControl editReportControl1;
    private ExecuteReportControl executeReportControl1;
    private Panel panel1;
  }
}

