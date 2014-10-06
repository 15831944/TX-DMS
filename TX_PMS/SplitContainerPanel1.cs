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
      Load += CadForm_Load;
      editPartMenuItem.Enabled = false;
      Mediator.Mediator.Instance.Register(UI.EditReport, OnEdit);
      Mediator.Mediator.Instance.Register(UI.ExecuteReport, ShowExecuteControl);
      Mediator.Mediator.Instance.Register(UI.SelectPart, i_O => OpenDwgFile(i_O as Part));
      Mediator.Mediator.Instance.Register(UI.SelectPartReport, i_O =>
        {
          var report = i_O as PartReport;
          if (report == null) return;
          OpenDwgFile(report.Part);
        });
      Mediator.Mediator.Instance.Register(UI.CreatePart, OnCreate);
      Mediator.Mediator.Instance.Register(UI.OpenCadFile, file_open_handler);
      Mediator.Mediator.Instance.Register(UI.SavePart, OnSavePart);
    }

    private void OpenDwgFile(Part i_Part)
    {
      editPartMenuItem.Enabled = true;
      ShowExecuteControl(null);
      if (i_Part == null)
      {
        CloseDwgFile();
        return;
      }
      if (string.IsNullOrEmpty(i_Part.CadFilename))
      {
        CloseDwgFile();
        return;
      }

      var filePath = string.Format(@"{0}\CADResources\{1}", Application.StartupPath, i_Part.CadFilename);
      if (!File.Exists(filePath))
      {
        CloseDwgFile();
        return;
      }
      OpenDwgFile(filePath);
      if (!panelGraphicContainer.Controls.Contains(panel1))
        panelGraphicContainer.Controls.Add(panel1);
    }
    private void CloseDwgFile()
    {
      panelGraphicContainer.Controls.Clear();
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
        var fileName = part.CadNumber.Replace('/', '_');
        var path = string.Format(@"{0}\{1}.dwg", destinyDir, fileName);
        database.SaveAs(path, DwgVersion.Current);
        part.CadFilename = fileName+".dwg";
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
      CloseDwgFile();
    }
    void ShowEditControl(object i_O)
    {
      if (panelReportContainer.Controls.Contains(editReportControl1))
        return;
      panelReportContainer.Controls.Clear();
      panelReportContainer.Controls.Add(editReportControl1);
    }

    void ShowExecuteControl(object i_O)
    {
      if (panelReportContainer.Controls.Contains(executeReportControl1))
        return;
      panelReportContainer.Controls.Clear(); 
      panelReportContainer.Controls.Add(executeReportControl1);
      LeftStripStatusLabel.Text = @"正在执行外协件";
    }

    void CadForm_Load(object i_Sender, EventArgs e)
    {
      panelReportContainer.Controls.Clear();
      LeftStripStatusLabel.Text = @"请选择或新建外协件";
    }
  }
}
