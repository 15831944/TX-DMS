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
    public string PartName
    {
      get { return _PartTemplate.Name; }
      set { _PartTemplate.Name = value; }
    }
    public string PartCadNumber
    {
      get { return _PartTemplate.CadNumber; }
      set { _PartTemplate.CadNumber = value; }
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
        foreach (var type in DimensionType.DimensionTypes)
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

    public float Nominal
    {
      get { return _DimensionEntity.Nominal; }
      set { _DimensionEntity.Nominal = value; }
    }

    public float PlusTol { get { return _DimensionEntity.PlusTol; } set { _DimensionEntity.PlusTol = value; } }
    public float MinusTol { get { return _DimensionEntity.MinusTol; } set { _DimensionEntity.MinusTol = value; } }
  }
}
