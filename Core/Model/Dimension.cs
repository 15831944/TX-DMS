namespace Core.Model
{
  public class Dimension
  {
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

    public override string ToString()
    {
      return string.Format("{0}{1}{2} {3}-{4}", PreFix, Symbol, Nominal, MinusTol, PlusTol);
    }
  }

}
