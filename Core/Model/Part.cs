using System.Collections.Generic;

namespace Core.Model
{
  public class Part
  {
    public string Name { get; set; }
    public string CadNumber { get; set; }
    public int TotalCount { get; set; }
    public int SampleCount { get; set; }
    public string CadFile { get; set; }
    public List<DimensionEntity> DimensionEntitys { get; set; }
  }
}
