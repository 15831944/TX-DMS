using System.Collections.Generic;

namespace Core.Model
{
  public class Part
  {
    public string Operator { get; set; }
    public string Supplier { get; set; }
    public string PartName { get; set; }
    public string PartCadNumber { get; set; }
    public int TotalCount { get; set; }
    public int SampleCount { get; set; }
    public List<DimensionEntity> DimensionEntitys { get; set; }
  }
}
