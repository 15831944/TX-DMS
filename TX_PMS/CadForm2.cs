﻿using System;
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
      Mediator.Mediator.Instance.Register(UI.SelectPart, i_O => OpenDwgFile(i_O as Part));
      Mediator.Mediator.Instance.Register(UI.SelectPartReport, i_O =>
        {
          var report = i_O as PartReport;
          if (report == null) return;
          OpenDwgFile(report.Task.Part);
        });
     Mediator.Mediator.Instance.Register(UI.SavePart, OnSavePart);
    }

    private void OpenDwgFile(Part i_Part)
    {
      if (i_Part == null)
      {
        return;
      }
      if (string.IsNullOrEmpty(i_Part.CadFilename))
      {
        return;
      }

      var filePath = string.Format(@"{0}\CADResources\{1}", Application.StartupPath, i_Part.CadFilename);
      if (!File.Exists(filePath))
      {
        return;
      }
      OpenDwgFile(filePath);
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
  }
}
