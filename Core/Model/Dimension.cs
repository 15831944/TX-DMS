namespace Core.Model
{
  public class Dimension
  {
    /// <summary>
    /// 为了简便期间，讲dimension的理论模型与报告模型使用同一个类，Part和PartReport必须有有一个的ID为-1，因为程序中通过PartID,或PartReportID来过滤dimensions
    /// </summary>
    public Part Part { get; set; }
    public PartReport PartReport { get; set; }
    public Dimension()
    {
      Part= new Part(){Id = -1};
      PartReport = new PartReport(){Id = -1};
      Dimensiontype = "";
      PreFix = "";
      CadHandle = "";
    }


    public int Id { get; set; }
    public int SerialNumber { get; set; }

    public string Dimensiontype { get; set; }
    /// <summary>
    /// 符号之前的字符串
    /// </summary>
    public string PreFix{ get; set; }
    /// <summary>
    /// 直径符号
    /// </summary>
    public char Symbol { get; set; }
    public float Nominal { get; set; }
    public float PlusTol { get; set; }
    public float MinusTol { get; set; }
    public float Measured { get; set; }
    public string CadHandle { get; set; }

    public override bool Equals(object i_Obj)
    {
      var other = i_Obj as Dimension;
      if (other == null) return false;
      return other.Id == Id;
    }

    public override int GetHashCode()
    {
      return Id+CadHandle.GetHashCode();
    }

    public override string ToString()
    {
      return string.Format("{0}{1}{2} {3}-{4}", PreFix, Symbol, Nominal, MinusTol, PlusTol);
    }

    /// <summary>
    /// 重新创建一个dimension，在数据库中没有任何信息，因为所有的ID都为-1
    /// </summary>
    /// <returns></returns>
    public Dimension Clone()
    {
      var result = new Dimension()
        {
          CadHandle = CadHandle,
          Dimensiontype = Dimensiontype,
          Id = -1,
          Measured = Measured,
          MinusTol = MinusTol,
          Nominal = Nominal,
          Part = Part,
          PartReport = PartReport          ,
          PlusTol = PlusTol,
          PreFix = PreFix, SerialNumber = SerialNumber, Symbol = Symbol
        };
      result.Part.Id = -1;
      result.PartReport.Id = -1;
      return result;
    }
  }

}
