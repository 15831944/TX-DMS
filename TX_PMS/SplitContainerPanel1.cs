using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ControlReport;
using Core.Model;
using Core.Service;
using Mediator;
using Teigha.DatabaseServices;

namespace TxPms
{
  partial class  CadForm
  {
    void Initialize()
    {
      this.Load += CadForm_Load;
      editReportToolStripMenuItem.Enabled = false;
      Mediator.Mediator.Instance.Register(UI.EditReport, OnEdit);
      Mediator.Mediator.Instance.Register(UI.ExecuteReport, ShowExecuteControl);
      Mediator.Mediator.Instance.Register(UI.SelectPartTemplate, i_O =>
        {
          editReportToolStripMenuItem.Enabled = true;
          ShowExecuteControl(null);
          var part = i_O as Part;
          if (part == null)
            return;
          if (string.IsNullOrEmpty(part.CadFile)) return;

          var filePath = string.Format(@"{0}\CADResources\{1}", Application.StartupPath,part.CadFile);
          if (!File.Exists(filePath)) return;
          OpenDwgFile(filePath);
        });
      Mediator.Mediator.Instance.Register(UI.CreatePartTemplate, OnCreate);
      Mediator.Mediator.Instance.Register(UI.OpenCadFile, file_open_handler);
      Mediator.Mediator.Instance.Register(UI.SavePartTemplate, OnSavePart);
    }

    private void OnSavePart(object i_Obj)
    {
      var part = i_Obj as Part;
      if (part == null)
        return;
      var destinyDir = string.Format(@"{0}\CADResources", Application.StartupPath);
      if (!Directory.Exists(destinyDir))
        Directory.CreateDirectory(destinyDir);
      if (database != null)
      {
        var path = string.Format(@"{0}\{1}.dwg", destinyDir, part.CadNumber);
        database.SaveAs(path, DwgVersion.Current);
        part.CadFile = part.CadNumber+".dwg";
        PmsService.Instance.SavePart(part);
      }
    }

    private void OnEdit(object i_Obj)
    {
      LeftStripStatusLabel.Text = @"正在编辑外协件";
      ShowEditControl(i_Obj);
    }

    void OnCreate(object i_O)
    {
      LeftStripStatusLabel.Text = @"正在创建外协件";
      ShowEditControl(i_O);
    }
    void ShowEditControl(object i_O)
    {
      if (splitContainer1.Panel1.Controls.Contains(editReportControl1))
        return;
      splitContainer1.Panel1.Controls.Clear();
      splitContainer1.Panel1.Controls.Add(editReportControl1);
    }

    void ShowExecuteControl(object i_O)
    {
      if (splitContainer1.Panel1.Controls.Contains(executeReportControl1))
        return;
      splitContainer1.Panel1.Controls.Clear();
      splitContainer1.Panel1.Controls.Add(executeReportControl1);
      LeftStripStatusLabel.Text = @"正在执行外协件";
    }

    void CadForm_Load(object sender, EventArgs e)
    {
      splitContainer1.Panel1.Controls.Clear();
      LeftStripStatusLabel.Text = @"请选择或新建外协件";
     
    }
  }

  

}
