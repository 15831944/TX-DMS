using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using Core.Model;
using Mediator;

namespace ControlReport
{
  public class ExecuteDimensionEntityViewModel 
  {
    private readonly Dimension _Dimension;
    public ExecuteDimensionEntityViewModel(Dimension i_Dimension)
    {
      _Dimension = i_Dimension;
    }
    public int SerialNumber{
      get { return _Dimension.SerialNumber; }
      set { _Dimension.SerialNumber = value; }
    }

    public string Dimensiontype
    {
      get { return _Dimension.Dimensiontype; }
    }

    /// <summary>
    /// 直径符号
    /// </summary>

    public string Nominal
    {
      get { return _Dimension.ToString(); }
    }

    public float Measured
    {
      get { return float.IsNaN(_Dimension.Measured) ? 0 : _Dimension.Measured; }
      set { _Dimension.Measured = value;
      }
    }

    public Bitmap StatusBitmap
    {
      get
      {
        if (float.IsNaN(_Dimension.Measured))
        {
          return Resource.PROCESS_READY;
        }
        else
        {
          if (_Dimension.Measured >= _Dimension.Nominal - _Dimension.MinusTol && _Dimension.Measured <= _Dimension.Nominal + _Dimension.PlusTol)
          {
            return Resource.PROCESS_RIGHT;
          }
          else
          {
            return Resource.PROCESS_WRONG;
          }
        }
      }
    }
  }
}
