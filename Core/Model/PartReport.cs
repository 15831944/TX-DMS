using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model
{
  public class PartReport
  {
    public readonly static DateTime InvalidDateTime = new DateTime(1900,1,1,0,0,0);
    public int Id { get; set; }
    public int SampleCount { get; set; }
    public int TotalCount { get; set; }
    public string Operator { get; set; }
    public string Supplier { get; set; }
    public DateTime MeasurementDatetime { get; set; }
    public string OperatorComment { get; set; }
    public string Auditor{ get; set; }
    public DateTime AuditDatetime{ get; set; }
    public string AuditComment{ get; set; }
    public string Approver{ get; set; }
    public DateTime ApproveDatetime{ get; set; }
    public string ApproveComment { get; set; }
    public Part Part { get; set; }

    public List<Dimension> Dimensions { get; set; }
    public PartReport()
    {
      Id = -1;
      Dimensions = new List<Dimension>();
      Part= new Part(){Id = -1};
      MeasurementDatetime = InvalidDateTime;
      AuditDatetime = InvalidDateTime;
      ApproveDatetime = InvalidDateTime;
    }
  }
}
