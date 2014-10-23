﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ControlReport;
using Core.Model;
using Core.Service;
using Dwglib;
using Mediator;
using Teigha.DatabaseServices;

namespace TxPms
{
  partial class  CadForm
  {
    void Initialize()
    {
      Mediator.Mediator.Instance.Register(UI.SelectPart, i_O =>
      {
        var part = i_O as Part;
        if (part == null) return;
        OpenDwgFile(part,false);
        OnRefreshCad(null);
      });
      Mediator.Mediator.Instance.Register(UI.SelectTask, i_O =>
        {
          var task = i_O as Task;
          if (task == null) return;
          OpenDwgFile(task.Part);
          OnRefreshCad(null);
        });
      Mediator.Mediator.Instance.Register(UI.SelectPartReport, i_O =>
        {
          var report = i_O as PartReport;
          if (report == null) return;
          OpenDwgFile(report.Task.Part);
          OnRefreshCad(null);
        });
     Mediator.Mediator.Instance.Register(UI.SavePart, OnSavePart);

     Mediator.Mediator.Instance.Register(Cad.OnReFresh, OnRefreshCad);
     Mediator.Mediator.Instance.Register(Cad.OnDimensionSelectedInControl, OnDimensionSelectedInControl);
    }

    private void OnDimensionSelectedInControl(object i_Obj)
    {
      string cadHandle = i_Obj as string;
      if (cadHandle == null) return;
      var dbObj = CadSelectionManager.Instance.GetObjectByHandle(cadHandle);
      if (dbObj == null) return;
      
      ClearSelection();
      selected.Add(dbObj.Id);
      gripManager.updateSelection(selected);
    }

    private void OnRefreshCad(object i_Obj)
    {
      Thread t = new Thread(() =>
      {
        Thread.Sleep(1000);
        if (panel1.IsDisposed)
          return;
        panel1.Invoke(new VoidDelegate2(Update1),1000);

      });
      t.Start();
    }


    private void UpdateCadAsync(int i_Delayed)
    {
      Thread t = new Thread(() =>
      {
        Thread.Sleep(800);
        if (panel1.IsDisposed)
          return;
        panel1.Invoke(new VoidDelegate2(Update1),i_Delayed);

      });
      t.Start();
    }

    private void Update1(int i_Delayed)
    {
      Invalidate();
    }

    private void OpenDwgFile(Part i_Part, bool i_IsParse = true)
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