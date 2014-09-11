using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace MvvmBase.Converter
{
  public class NumberConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return IsNumber(value);
    }

    public static bool IsNumber(object i_O)
    {
      if (i_O == null)
      {
        return false;
      }
      if (i_O.ToString().Trim() == "")
        return true;
      try
      {
        var f = float.Parse(i_O.ToString());
        return true;
      }
      catch
      {
        return false;
      }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
