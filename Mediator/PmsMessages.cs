using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
  public enum InterfaceCommand
  {
    EditReport,
    ExecuteReport,
    SelectPartTemplate
  }

  public enum CadEvent
  {
    OnDimensionSelected,
    OnTextSelected,
  }

  public enum ModelEvent
  {
    DimensionReportChanged
  }
}
