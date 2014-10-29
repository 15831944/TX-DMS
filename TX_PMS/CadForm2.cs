using System;
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
        if (!DimensionReportContainer.Controls.Contains(_EditReportControl))
        {
          DimensionReportContainer.Controls.Clear();
          DimensionReportContainer.Controls.Add(_EditReportControl);
        }
        OpenDwgFile(part);
      });
      Mediator.Mediator.Instance.Register(UI.SelectTask, i_O =>
        {
          var task = i_O as Task;
          if (task == null) return;
         // OpenDwgFile(task.Part);
        });
      Mediator.Mediator.Instance.Register(UI.SelectPartReport, i_O =>
        {
          var report = i_O as PartReport;
          if (report == null) return;
          OpenDwgFile(report.Task.Part);
        });
     Mediator.Mediator.Instance.Register(UI.SavePart, OnSavePart);
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

    

    private void OnDwgFileOpened()
    {
      if (database == null) return;
      using (DBDictionary layoutDict = (DBDictionary)database.LayoutDictionaryId.GetObject(OpenMode.ForRead))
      {
        CadToolStripMenuItem.DropDownItems.Clear();
        foreach (DBDictionaryEntry dicEntry in layoutDict)
        {
          ToolStripItem item = new ToolStripButton(dicEntry.Key);
          item.Click+=item_Click;
          CadToolStripMenuItem.DropDownItems.Add(item);
        }
      }
    }

    void item_Click(object sender, EventArgs e)
    {
      var item = sender as ToolStripItem;
      if (item != null)
        SetLayout(item.Text);
    }

    bool IsMouseEventNeeded(int i_MouseX, int i_MouseY)
    {
      if (i_MouseX > panel1.Location.X && i_MouseY > panel1.Location.Y
          && i_MouseX < (panel1.Location.X + panel1.Size.Width) && i_MouseY < (panel1.Location.Y + panel1.Size.Height))
        return true;
      return false;
    }
  }
}
