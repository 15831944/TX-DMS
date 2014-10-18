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
    SelectPartReport,
    SelectTask,
    Resize
  }

  public enum Cad
  {
    OnDimensionSelected,
    OnTextSelected,
    OnOpened,
    OnReFresh
  }
  public enum MeasurementTool
  {
    OnDataArrived
  }

  public enum App
  {
    OnLogin,
    ExecutionProgress
  }

  public enum Execution
  {
    TaskStarted,
    TaskCompleted,
    OneStarted,
    OneCompleted
  }
}
