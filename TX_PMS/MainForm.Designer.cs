﻿using System.Windows.Forms;

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
      this.qRibbonPage2 = new Qios.DevSuite.Components.Ribbon.QRibbonPage();
      this.qRibbonPanel6 = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
      this.qRibbonItem4 = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
      this.qRibbon1 = new Qios.DevSuite.Components.Ribbon.QRibbon();
      this.qRibbonPage1 = new Qios.DevSuite.Components.Ribbon.QRibbonPage();
      this.qRibbonPanel3 = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
      this.qRibbonItemNew = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
      this.qRibbonPanel7 = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
      this.qRibbonItemOpen = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
      this.qRibbonPanel4 = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
      this.qRibbonItemEdit = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
      this.qRibbonPanel5 = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
      this.qRibbonItemExecute = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
      this.qDockBarBottom = new Qios.DevSuite.Components.QDockBar();
      this.qDockBarRight = new Qios.DevSuite.Components.QDockBar();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.qDockBarLeft = new Qios.DevSuite.Components.QDockBar();
      this.qRibbonCaption1 = new Qios.DevSuite.Components.Ribbon.QRibbonCaption();
      this.qRibbonPage3 = new Qios.DevSuite.Components.Ribbon.QRibbonPage();
      ((System.ComponentModel.ISupportInitialize)(this.qRibbonPage2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.qRibbon1)).BeginInit();
      this.qRibbon1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.qRibbonPage1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.qRibbonPage3)).BeginInit();
      this.SuspendLayout();
      // 
      // qRibbonPage2
      // 
      this.qRibbonPage2.ButtonOrder = 1;
      this.qRibbonPage2.Items.Add(this.qRibbonPanel6);
      this.qRibbonPage2.Location = new System.Drawing.Point(2, 29);
      this.qRibbonPage2.Name = "qRibbonPage2";
      this.qRibbonPage2.PersistGuid = new System.Guid("7ec692ff-e11e-4d31-86ab-e44c34130bc3");
      this.qRibbonPage2.Size = new System.Drawing.Size(907, 62);
      this.qRibbonPage2.Text = "模拟";
      // 
      // qRibbonPanel6
      // 
      this.qRibbonPanel6.Items.Add(this.qRibbonItem4);
      this.qRibbonPanel6.Title = "";
      // 
      // qRibbonItem4
      // 
      this.qRibbonItem4.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(32, 32);
      this.qRibbonItem4.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItem4.Icon")));
      this.qRibbonItem4.Title = "量具";
      this.qRibbonItem4.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.qRibbonItem4_ItemActivated);
      // 
      // qRibbon1
      // 
      this.qRibbon1.ActiveTabPage = this.qRibbonPage1;
      this.qRibbon1.Controls.Add(this.qRibbonPage1);
      this.qRibbon1.Controls.Add(this.qRibbonPage2);
      this.qRibbon1.Controls.Add(this.qRibbonPage3);
      this.qRibbon1.Cursor = System.Windows.Forms.Cursors.Default;
      this.qRibbon1.Dock = System.Windows.Forms.DockStyle.Top;
      this.qRibbon1.Location = new System.Drawing.Point(0, 28);
      this.qRibbon1.Name = "qRibbon1";
      this.qRibbon1.PersistGuid = new System.Guid("674c053e-6661-40ed-a8ca-47a4d347ee9d");
      this.qRibbon1.Size = new System.Drawing.Size(913, 95);
      this.qRibbon1.TabIndex = 22;
      this.qRibbon1.Text = "qRibbon1";
      // 
      // qRibbonPage1
      // 
      this.qRibbonPage1.ButtonOrder = 0;
      this.qRibbonPage1.Items.Add(this.qRibbonPanel3);
      this.qRibbonPage1.Items.Add(this.qRibbonPanel7);
      this.qRibbonPage1.Items.Add(this.qRibbonPanel4);
      this.qRibbonPage1.Items.Add(this.qRibbonPanel5);
      this.qRibbonPage1.Location = new System.Drawing.Point(2, 29);
      this.qRibbonPage1.Name = "qRibbonPage1";
      this.qRibbonPage1.PersistGuid = new System.Guid("446d545b-30dc-40fc-ac6c-8c4d715deecf");
      this.qRibbonPage1.Size = new System.Drawing.Size(907, 62);
      this.qRibbonPage1.Text = "零件";
      // 
      // qRibbonPanel3
      // 
      this.qRibbonPanel3.Items.Add(this.qRibbonItemNew);
      this.qRibbonPanel3.Title = "";
      // 
      // qRibbonItemNew
      // 
      this.qRibbonItemNew.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(32, 32);
      this.qRibbonItemNew.ControlSize = new System.Drawing.Size(30, 30);
      this.qRibbonItemNew.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItemNew.Icon")));
      this.qRibbonItemNew.Title = "新建";
      this.qRibbonItemNew.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.qRibbonItemNew_ItemActivated);
      // 
      // qRibbonPanel7
      // 
      this.qRibbonPanel7.Items.Add(this.qRibbonItemOpen);
      this.qRibbonPanel7.Title = "";
      // 
      // qRibbonItemOpen
      // 
      this.qRibbonItemOpen.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(32, 32);
      this.qRibbonItemOpen.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItemOpen.Icon")));
      this.qRibbonItemOpen.Title = "打开";
      this.qRibbonItemOpen.ItemActivated += new Qios.DevSuite.Components.QCompositeEventHandler(this.qRibbonItemOpen_ItemActivated);
      // 
      // qRibbonPanel4
      // 
      this.qRibbonPanel4.Items.Add(this.qRibbonItemEdit);
      this.qRibbonPanel4.Title = "";
      // 
      // qRibbonItemEdit
      // 
      this.qRibbonItemEdit.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(32, 32);
      this.qRibbonItemEdit.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItemEdit.Icon")));
      this.qRibbonItemEdit.Title = "编辑";
      // 
      // qRibbonPanel5
      // 
      this.qRibbonPanel5.Items.Add(this.qRibbonItemExecute);
      this.qRibbonPanel5.Title = "";
      // 
      // qRibbonItemExecute
      // 
      this.qRibbonItemExecute.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(32, 32);
      this.qRibbonItemExecute.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItemExecute.Icon")));
      this.qRibbonItemExecute.Title = "执行";
      // 
      // qDockBarBottom
      // 
      this.qDockBarBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.qDockBarBottom.Location = new System.Drawing.Point(0, 578);
      this.qDockBarBottom.Name = "qDockBarBottom";
      this.qDockBarBottom.PersistGuid = new System.Guid("5abadc58-e97d-45c7-a1b5-9162b21d79fc");
      this.qDockBarBottom.Size = new System.Drawing.Size(913, 22);
      this.qDockBarBottom.TabIndex = 20;
      this.qDockBarBottom.Text = "qDockBar2";
      // 
      // qDockBarRight
      // 
      this.qDockBarRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.qDockBarRight.Location = new System.Drawing.Point(891, 123);
      this.qDockBarRight.Name = "qDockBarRight";
      this.qDockBarRight.PersistGuid = new System.Guid("293bc58e-3352-473e-9d1c-dbf044ae5f57");
      this.qDockBarRight.Size = new System.Drawing.Size(22, 455);
      this.qDockBarRight.TabIndex = 21;
      this.qDockBarRight.Text = "qDockBar3";
      // 
      // statusStrip1
      // 
      this.statusStrip1.Location = new System.Drawing.Point(0, 600);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(913, 22);
      this.statusStrip1.TabIndex = 18;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // qDockBarLeft
      // 
      this.qDockBarLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.qDockBarLeft.Location = new System.Drawing.Point(0, 123);
      this.qDockBarLeft.Name = "qDockBarLeft";
      this.qDockBarLeft.PersistGuid = new System.Guid("1ebab76d-f39e-4275-b798-7884460bca14");
      this.qDockBarLeft.Size = new System.Drawing.Size(22, 455);
      this.qDockBarLeft.TabIndex = 19;
      this.qDockBarLeft.Text = "qDockBar1";
      // 
      // qRibbonCaption1
      // 
      this.qRibbonCaption1.Location = new System.Drawing.Point(0, 0);
      this.qRibbonCaption1.Name = "qRibbonCaption1";
      this.qRibbonCaption1.Size = new System.Drawing.Size(913, 28);
      this.qRibbonCaption1.TabIndex = 13;
      this.qRibbonCaption1.Text = null;
      // 
      // qRibbonPage3
      // 
      this.qRibbonPage3.ButtonOrder = 0;
      this.qRibbonPage3.Location = new System.Drawing.Point(2, 29);
      this.qRibbonPage3.Name = "qRibbonPage3";
      this.qRibbonPage3.PersistGuid = new System.Guid("9ac559c7-04fb-4123-b689-b71d255e4135");
      this.qRibbonPage3.Size = new System.Drawing.Size(907, 62);
      this.qRibbonPage3.Text = "窗口";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(913, 622);
      this.Controls.Add(this.qDockBarRight);
      this.Controls.Add(this.qDockBarLeft);
      this.Controls.Add(this.qDockBarBottom);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.qRibbon1);
      this.Controls.Add(this.qRibbonCaption1);
      this.IsMdiContainer = true;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      ((System.ComponentModel.ISupportInitialize)(this.qRibbonPage2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.qRibbon1)).EndInit();
      this.qRibbon1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.qRibbonPage1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.qRibbonPage3)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Qios.DevSuite.Components.Ribbon.QRibbonPage qRibbonPage2;
    private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanel6;
    private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItem4;
    private Qios.DevSuite.Components.Ribbon.QRibbon qRibbon1;
    private Qios.DevSuite.Components.Ribbon.QRibbonPage qRibbonPage1;
    private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanel3;
    private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItemNew;
    private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanel7;
    private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItemOpen;
    private Qios.DevSuite.Components.QDockBar qDockBarBottom;
    private Qios.DevSuite.Components.QDockBar qDockBarRight;
    private StatusStrip statusStrip1;
    private Qios.DevSuite.Components.QDockBar qDockBarLeft;
    private Qios.DevSuite.Components.Ribbon.QRibbonCaption qRibbonCaption1;
    private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanel4;
    private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItemEdit;
    private Qios.DevSuite.Components.Ribbon.QRibbonPanel qRibbonPanel5;
    private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItemExecute;
    private Qios.DevSuite.Components.Ribbon.QRibbonPage qRibbonPage3;


  }
}