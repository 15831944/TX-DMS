using System;
using System.Collections.Generic;
using System.Text;
using ControlReport;
using Mediator;

namespace TxPms
{
  partial class  CadForm
  {
    void Initialize()
    {
      this.Load += new EventHandler(CadForm_Load);
      editReportToolStripMenuItem.Enabled = false;
      Mediator.Mediator.Instance.Register(InterfaceCommand.EditReport, ShowEditControl);
      Mediator.Mediator.Instance.Register(InterfaceCommand.ExecuteReport, ShowExecuteControl);
      Mediator.Mediator.Instance.Register(InterfaceCommand.SelectPartTemplate, i_O =>
        {
          editReportToolStripMenuItem.Enabled = true;
          ShowExecuteControl(null);
        });
      Mediator.Mediator.Instance.Register(InterfaceCommand.CreatePartTemplate, ShowEditControl);
      Mediator.Mediator.Instance.Register(InterfaceCommand.OpenCadFile, file_open_handler);
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
    }

    void CadForm_Load(object sender, EventArgs e)
    {
      splitContainer1.Panel1.Controls.Add(executeReportControl1);
    }
  }

  

}
