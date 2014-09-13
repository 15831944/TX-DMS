﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Model;

namespace ControlReport
{
  class EditPartTemplateViewModel
  {
    private readonly Part _PartTemplate;
    public EditPartTemplateViewModel(Part i_PartTemplate)
    {
      _PartTemplate = i_PartTemplate;
    }

    //public string Operator { get{_PartTemplate.}; set; }
    public string Supplier
    {
      get { return _PartTemplate.Supplier; }
      set { _PartTemplate.Supplier = value; }
    }

    public string PartName
    {
      get { return _PartTemplate.PartName; }
      set { _PartTemplate.PartName = value; }
    }
    public string PartCadNumber
    {
      get { return _PartTemplate.PartCadNumber; }
      set { _PartTemplate.PartCadNumber = value; }
    }
    public int TotalCount
    {
      get { return _PartTemplate.TotalCount; }
      set { _PartTemplate.TotalCount = value; }
    }
    public int SampleCount
    {
      get { return _PartTemplate.SampleCount; }
      set { _PartTemplate.SampleCount = value; }
    }
  }

  class EditDimensionEntityViewModel
  {
    private readonly DimensionEntity _DimensionEntity;
    public EditDimensionEntityViewModel(DimensionEntity i_DimensionEntity)
    {
      _DimensionEntity = i_DimensionEntity;
    }
    public int Index { get; set; }

    public string Dimensiontype
    {
      get { return _DimensionEntity.Dimensiontype.Text;  }
      set
      {
        foreach (var type in Core.Model.DimensionType.DimensionTypes)
        {
          if (type.Text == value)
          {
            _DimensionEntity.Dimensiontype = type;
            break;
          }
        }        
      }
    }

    /// <summary>
    /// 直径符号
    /// </summary>
    
    public double Nominal
    {
      get { return _DimensionEntity.Nominal; }
      set { _DimensionEntity.Nominal = value; }
    }

    public double PlusTol { get { return _DimensionEntity.PlusTol; } set { _DimensionEntity.PlusTol = value; } }
    public double MinusTol { get { return _DimensionEntity.MinusTol; } set { _DimensionEntity.MinusTol = value; } }


  }
}
