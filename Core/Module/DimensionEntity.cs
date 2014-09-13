using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Module
{
  public class DimensionEntity
  {
    public int Index;
    public DimensionType Dimensiontype;
    /// <summary>
    /// 符号之前的字符串
    /// </summary>
    public string PreFix="";
    /// <summary>
    /// 直径符号
    /// </summary>
    public char Symbol;
    public double Nominal;
    public double PlusTol;
    public double MinusTol;

    public override string ToString()
    {
      return string.Format("{0}{1}{2} {3}-{4}", PreFix, Symbol, Nominal, PlusTol, MinusTol);
    }
  }
}
