using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
// ReSharper disable InconsistentNaming
  public enum UI
// ReSharper restore InconsistentNaming
  {
    EditReport,
    ExecuteReport,
    SelectPartTemplate,
    CreatePartTemplate,
    OpenCadFile,
    SavePartTemplate
  }

  public enum Cad
  {
    OnDimensionSelected,
    OnTextSelected,
  }
  public enum MeasurementTool
  {
    OnDataArrived
  }
}
