using System.Collections.Generic;

namespace Core.Model
{
  public class Part
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string CadNumber { get; set; }
    public string SecondNumber { get; set; }
    public string CadFilename { get; set; }
    public List<Dimension> Dimensions { get; set; }
    public Part()
    {
      Dimensions = new List<Dimension>();
      Name = "";
      SecondNumber = "";
      CadFilename = "";
      CadFilename = "";
    }
  }
}
