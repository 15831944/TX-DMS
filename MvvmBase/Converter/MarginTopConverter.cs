﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace MvvmBase.Converter
{
  public class MarginTopConverter : IValueConverter 
  {

    public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      return new Thickness(0, System.Convert.ToDouble(value), 0, 0);
    }

    public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      return null;
    }
  }
}
