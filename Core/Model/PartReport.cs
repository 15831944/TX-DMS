using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model
{
  public class PartReport
  {
    public int Id { get; set; }
    public int SampleCount { get; set; }
    public int TotalCount { get; set; }
    public string Operator { get; set; }
    public string Supplier { get; set; }
    public DateTime MeasurementDatetime { get; set; }
    public string OperatorComment { get; set; }
    public string Approver1{ get; set; }
    public DateTime Approve1Datetime{ get; set; }
    public string Approve1Comment{ get; set; }
    public string Approver2{ get; set; }
    public DateTime Approve2Datetime{ get; set; }
    public string Approve2Comment { get; set; }
    public Part Part { get; set; }
    public PartReport()
    {
      Part= new Part(){Id = -1};
    }
  }
}
