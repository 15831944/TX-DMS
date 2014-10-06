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
    SelectPart,
    CreatePart,
    OpenCadFile,
    SavePart,
    SelectPartReport
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

  public enum App
  {
    OnLogin
  }
}
