using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model
{
  public class PartReport
  {
    public int Id { get; set; }
    public string Operator { get; set; }
    public string Supplier { get; set; }

    public Part Part { get; set; }

  }
}
