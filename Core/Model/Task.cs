using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model
{
  public class Task
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public Part Part { get; set; }
    public DateTime CreateDatetime { get; set; }
    public Supplier Supplier { get; set; }
    public int TotalNumber { get; set; }
    public int SampleNumber { get; set; }
    public string Creator { get; set; }
    public Task()
    {
      Id = -1;
      CreateDatetime = PartReport.InvalidDateTime;
      Supplier = new Supplier();
      Part = new Part(){Id = -1};
    }
  }
}
