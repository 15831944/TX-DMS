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
    private readonly DimensionEntity _DimensionEntity;
    public ExecuteDimensionEntityViewModel(DimensionEntity i_DimensionEntity)
    {
      _DimensionEntity = i_DimensionEntity;
    }
    public int Index { get; set; }

    public string Dimensiontype
    {
      get { return _DimensionEntity.Dimensiontype.Text; }
    }

    /// <summary>
    /// 直径符号
    /// </summary>

    public string Nominal
    {
      get { return _DimensionEntity.ToString(); }
    }

    public double Measured
    {
      get { return _DimensionEntity.Measured; }
      set { _DimensionEntity.Measured = value;
        Mediator.Mediator.Instance.NotifyColleagues(ModelEvent.DimensionReportChanged, this);
      }
    }

    public Bitmap StatusBitmap
    {
      get
      {
        if (double.IsNaN(_DimensionEntity.Measured))
        {
          return Resource.PROCESS_READY;
        }
        else
        {
          if (_DimensionEntity.Measured >= _DimensionEntity.Nominal - _DimensionEntity.MinusTol && _DimensionEntity.Measured <= _DimensionEntity.Nominal + _DimensionEntity.PlusTol)
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
