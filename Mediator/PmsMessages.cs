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
    OnValidDimensionParsed,
    OnDimensionSelectedInCad,
    OnDimensionSelectedInControl,
    OnOpened,
    OnReFresh,
    Parsing
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
  public enum CadParseStatus
  {
    Started,
    Finished,
    Error
  }
}
