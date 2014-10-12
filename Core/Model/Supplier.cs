using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model
{
  public class Supplier
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public Supplier()
    {
      Id = -1;
      Name = "";
    }
  }
}
