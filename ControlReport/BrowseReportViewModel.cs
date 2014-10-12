using System;
using System.Collections.Generic;
using System.Text;
using Core.Model;

namespace ControlReport
{
  public class BrowseReportViewModel
  {
    public string Partname
    {
      get { return _PartReport.Task.Part.Name; }
    }

    public string PartCadNumber
    {
      get { return _PartReport.Task.Part.CadNumber; }
    }

//    public string Supplier
//    {
//      get { return _PartReport.Supplier; }
//    }

    public string MeasurementResult
    {
      get { return _PartReport.OperatorComment; }
    }

    public string AuditResult
    {
      get { return _PartReport.AuditComment; }
    }

    public string ApproveResult
    {
      get { return _PartReport.ApproveComment; }
    }

    public BrowseReportViewModel(PartReport i_PartReport)
    {
      _PartReport = i_PartReport;
    }

    private readonly PartReport _PartReport;
    public PartReport GetPartReport()
    {
      return _PartReport;
    }
  }
}
