namespace Core.Model
{
  public class DimensionEntity
  {
    public int Index { get; set; }
    public DimensionType Dimensiontype { get; set; }
    /// <summary>
    /// 符号之前的字符串
    /// </summary>
    public string PreFix{ get; set; }
    /// <summary>
    /// 直径符号
    /// </summary>
    public char Symbol { get; set; }
    public double Nominal { get; set; }
    public double PlusTol { get; set; }
    public double MinusTol { get; set; }
    public double Measured { get; set; }
    public DimensionEntity()
    {
      Measured = double.NaN;
    }
    public override string ToString()
    {
      return string.Format("{0}{1}{2} {3}-{4}", PreFix, Symbol, Nominal, PlusTol, MinusTol);
    }
  }
}
