﻿namespace TxPms
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
      this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cadWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.zoomFitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.viewToolStripMenuItem1});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1107, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // viewToolStripMenuItem
      // 
      this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadWindowToolStripMenuItem,
            this.zoomFitToolStripMenuItem});
      this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
      this.viewToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.viewToolStripMenuItem.Text = "File";
      // 
      // cadWindowToolStripMenuItem
      // 
      this.cadWindowToolStripMenuItem.Name = "cadWindowToolStripMenuItem";
      this.cadWindowToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
      this.cadWindowToolStripMenuItem.Text = "Open";
      this.cadWindowToolStripMenuItem.Click += new System.EventHandler(this.cadWindowToolStripMenuItem_Click);
      // 
      // zoomFitToolStripMenuItem
      // 
      this.zoomFitToolStripMenuItem.Name = "zoomFitToolStripMenuItem";
      this.zoomFitToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
      this.zoomFitToolStripMenuItem.Text = "ZoomFit";
      this.zoomFitToolStripMenuItem.Click += new System.EventHandler(this.zoomFitToolStripMenuItem_Click);
      // 
      // viewToolStripMenuItem1
      // 
      this.viewToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verticalToolStripMenuItem});
      this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
      this.viewToolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
      this.viewToolStripMenuItem1.Text = "Layout";
      // 
      // verticalToolStripMenuItem
      // 
      this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
      this.verticalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.verticalToolStripMenuItem.Text = "vertical";
      this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1107, 688);
      this.Controls.Add(this.menuStrip1);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.Text = "MainForm";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cadWindowToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem zoomFitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
  }
}