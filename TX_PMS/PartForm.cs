using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ControlReport;
using Core.Model;
using Mediator;

namespace TxPms
{
  public partial class PartForm : Qios.DevSuite.Components.QDockingWindow
  {
    private EditReportControl _EditReportControl = new EditReportControl();
    private ExecuteReportControl _ExecuteReportControl = new ExecuteReportControl();

    public PartForm()
    {
      InitializeComponent();
      _EditReportControl.Dock = DockStyle.Fill;
      _ExecuteReportControl.Dock = DockStyle.Fill;
      Mediator.Mediator.Instance.Register(UI.EditReport, OnEdit);
      Mediator.Mediator.Instance.Register(UI.ExecuteReport, ShowExecuteControl);
      Mediator.Mediator.Instance.Register(UI.SelectPartReport, i_O =>
        {
          var report = i_O as PartReport;
          if (report == null) return;
          ShowExecuteControl(null);
        });
      Mediator.Mediator.Instance.Register(UI.CreatePart, OnCreate);
      Mediator.Mediator.Instance.Register(UI.SelectTask, ShowExecuteControl);
    }

    private void OnEdit(object i_Obj)
    {
      ShowEditControl(i_Obj);
    }

    private void OnCreate(object i_O)
    {
      ShowEditControl(i_O);
    }

    private void ShowEditControl(object i_O)
    {
      if (Controls.Contains(_EditReportControl))
        return;
      Controls.Clear();
      Controls.Add(_EditReportControl);

    }

    private void ShowExecuteControl(object i_O)
    {
      if (Controls.Contains(_ExecuteReportControl))
        return;
      Controls.Clear();
      Controls.Add(_ExecuteReportControl);
    }
  }
}
