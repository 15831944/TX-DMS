namespace MvvmBase.Mediator
{
  public enum ApplicationMessages
  {
    OnUserPriorityChecking,
    OnSetLastLampNameShow,
    OnSetLastLampDetailInfoShow,
    OnTabChanging,
    OnTestFinished,
    OnCDBoxCorrectionFinished,
    OnShowCdTestResult,
    OnTestingLampsChanged,  //用户重新选择灯具
    OnTestStarted,
    OnTestSettingChanged,
    OnColorReportPrint,
    OnTimerRemaining,
  }

  public enum MotorMessages
  {
    ConnectingFinished,
    ResetFinished,
    SampleDataFinished,
    ArrivedWhere,
    GetLocationFinished,
    DirectionChanged
  }

  public enum CommandMessages
  {
    UserSetting,
    About,
    SystemSetting,
    OnLampSelection,
    OnTestDistanceAdjust,
    OnCDBoxCorrection,
    OnQualificationParaCommand,
    OnReLoginCommand,

    LampNameChanged,
    OnLampDetailsChanged,
    OnLampSpecified,
    OnConsoleTabActiveChanged,
    OnLampPropertiesTabActiveChanged,
    OnDatabaseTabActiveChanged,

    
    OnConsoleClicked,
    OnIntegrityTest,
    OnColorTest,
    OnTestPausedResumed,
    OnTestExit,
    OnRangeModify,
    OnInstallStyleChanged,
    OnMotorTest,
    OnReset,
    OnStandStyleInstall,
    OnManuallyControl,

    OnReFind,
    OnCDAnalysis,
    OnColorAnalysis,
    OnShowImage,
    OncdReport,
    OnColorReport,
    OnIntegrateReport,
    OnShowResult,

    OnStatistic,
    OnExport,
    OnImport,   
    OnDelete,

    OnCdNoteModified,
    OnColorNoteModified,
    OnComprehensiveReportFormClosed,


    OnLampFiltered
  }

  public enum ButtonMessages
  {
    OnEnabledChanged,
    OnTextChanged,
    OnImageChanged,
    OnCheckChanged,
    OnFocus
  }

  public enum ControlMessages
  {
    ControlMenuLoaded,
    RichTextBoxLoaded
  }

  public enum GroupBoxMessages
  {
    OnVisibilityChanged,
    OnContentChanged
  }
  public enum TextBoxMessages
  {
    OnTextChanged,
    OnEnableChanged
  }
  /// <summary>
  /// Start->PrepareForIntegrateTest->TestOnGoing->PrepareForReTest->TestOnGoing
  /// </summary>
  public enum IntegrityTestState
  {
    Start,
    PrepareForIntegrateTest,
    TestOnGoing,
    PrepareForReTest
  }

  public class IntegrityTestStateTransition
  {
    public IntegrityTestState State { get; set; }
    public bool IsSucceed { get; set; }
  }
}
