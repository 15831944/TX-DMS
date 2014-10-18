using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
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
    }

    private void OnRefreshCad(object i_Obj)
    {
      Thread t = new Thread(() =>
      {
        Thread.Sleep(1000);
        if (panel1.IsDisposed)
          return;
        panel1.Invoke(new VoidDelegate2(Update1));

      });
      t.Start();
    }


    public void Update1()
    {
      //this.Focus();
      //panel1.Focus();
      Invalidate();
      //panel1.Focus();
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
