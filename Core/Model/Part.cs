using System.Collections.Generic;

namespace Core.Model
{
  public class Part
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string CadNumber { get; set; }
    public string SecondNumber { get; set; }
    public int TotalCount { get; set; }
    public int SampleCount { get; set; }
    public string CadFilename { get; set; }
    private List<Dimension> _Dimensions = new List<Dimension>();
    public List<Dimension> Dimensions { get { return _Dimensions; } set { _Dimensions = value; } }
  }
}
