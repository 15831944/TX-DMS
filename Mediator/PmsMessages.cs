using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
  public enum InterfaceCommand
  {
    EditReport,
    ExecuteReport,
  }

  public enum CadEvent
  {
    OnDimensionSelected,
    OnTextSelected
  }
}
