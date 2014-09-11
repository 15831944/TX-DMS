using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvvmBase.Converter;

namespace MvvmBase
{

  public class BoxEntity : NotifyPropertyObject
  {
    private string _Index;
    public string Index
    {
      get { return _Index; }
      set
      {
        if (_Index != value)
        {
          _Index = value;
          RaisePropertyChanged(() => Index);
        }
      }
    }

    private string _NominalEV;
    public string NominalEV
    {
      get { return _NominalEV; }
      set
      {
        if (_NominalEV != value)
        {
          _NominalEV = value;
          RaisePropertyChanged(() => NominalEV);
        }
      }
    }

    private string _NominalX;
    public string NominalX
    {
      get { return _NominalX; }
      set
      {
        if (_NominalX != value)
        {
          _NominalX = value;
          RaisePropertyChanged(() => NominalX);
        }
      }
    }

    private string _NominalY;
    public string NominalY
    {
      get { return _NominalY; }
      set
      {
        if (_NominalY != value)
        {
          _NominalY = value;
          RaisePropertyChanged(() => NominalY);
        }
      }
    }

    private string _MeasuredEV;
    public string MeasuredEV
    {
      get { return _MeasuredEV; }
      set
      {
        if (_MeasuredEV != value)
        {
          _MeasuredEV = value;
          RaisePropertyChanged(() => MeasuredEV);
        }
      }
    }

    private string _MeasuredX;
    public string MeasuredX
    {
      get { return _MeasuredX; }
      set
      {
        if (_MeasuredX != value)
        {
          _MeasuredX = value;
          RaisePropertyChanged(() => MeasuredX);
        }
      }
    }

    private string _MeasuredY;
    public string MeasuredY
    {
      get { return _MeasuredY; }
      set
      {
        if (_MeasuredY != value)
        {
          _MeasuredY = value;
          RaisePropertyChanged(() => MeasuredY);
        }
      }
    }


    public bool IsValid
    {
      get
      {
        return
          NumberConverter.IsNumber(NominalEV)
          && NumberConverter.IsNumber(NominalX)
          && NumberConverter.IsNumber(NominalY)
          && NumberConverter.IsNumber(MeasuredEV)
          && NumberConverter.IsNumber(MeasuredX)
          && NumberConverter.IsNumber(MeasuredY);
      }
    }
  }
}
