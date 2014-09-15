using System.Collections.Generic;

namespace Core.Model
{
  public class DimensionType
  {
    public int Id;
    public string Text;

    public static List<DimensionType> DimensionTypes = new List<DimensionType>();
    public DimensionType(int i_Id, string i_Text)
    {
      Id = i_Id;
      Text = i_Text;
    }
    static DimensionType()
    {
      DimensionTypes.Add(new DimensionType(0, "外观"));
      DimensionTypes.Add(new DimensionType(1, "外径"));
      DimensionTypes.Add(new DimensionType(2, "内径"));
      DimensionTypes.Add(new DimensionType(3, "长度"));
      DimensionTypes.Add(new DimensionType(4, "深度"));
      DimensionTypes.Add(new DimensionType(5, "槽宽"));
      DimensionTypes.Add(new DimensionType(6, "槽深"));
      DimensionTypes.Add(new DimensionType(7, "角度"));
      DimensionTypes.Add(new DimensionType(8, "圆角"));
      DimensionTypes.Add(new DimensionType(9, "倒角"));
    }
    public static DimensionType GetDimension(string  i_Text)
    {
      DimensionType result = new DimensionType(0, "无效");
      foreach (var dimensionType in DimensionTypes)
      {
        if (dimensionType.Text == i_Text.Trim())
        {
          result = dimensionType;
          break;
        }
      }
      return result;
    }
    public static DimensionType GetDimension(int i_Id)
    {
      return DimensionTypes[i_Id];
    }
  }
}
