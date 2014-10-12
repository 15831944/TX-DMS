using System;
using System.Collections.Generic;
using System.Text;
using Core.Model;
using Core.Service;
using Mediator;

namespace Service
{
  public class ExecutionManager
  {
    private readonly Task _Task;
    //public static ExecutionManager Instance = new ExecutionManager();
    public ExecutionManager(Task i_Task)
    {
      _Task = i_Task;
    }

    public void Start(PartReport i_PartReport)
    {
      var executed = PmsService.Instance.GetPartReports(_Task);
      Mediator.Mediator.Instance.NotifyColleagues(App.ExecutionProgress, string.Format("{0}/{1}", _Task.SampleNumber, executed.Count));

    }
    public void Finish(PartReport i_PartReport)
    {
      PmsService.Instance.SaveReport(i_PartReport);
      Mediator.Mediator.Instance.NotifyColleagues(Execution.OneCompleted, i_PartReport);
      var executed = PmsService.Instance.GetPartReports(_Task);
      Mediator.Mediator.Instance.NotifyColleagues(App.ExecutionProgress,string.Format("{0}/{1}",_Task.SampleNumber,executed.Count));
    }
  }
}
