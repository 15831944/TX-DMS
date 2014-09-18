using System.Drawing;
using Core.Model;
using Core.Service;

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
    public override int GetHashCode()
    {
      return (_Dimension != null ? _Dimension.GetHashCode() : 0);
    }

    private readonly Dimension _Dimension;
    public Dimension GetDimension()
    {
      return _Dimension;
    }
    public EditDimensionEntityViewModel(Dimension i_Dimension)
    {
      _Dimension = i_Dimension;
    }
    public int SerialNumber {
      get { return _Dimension.SerialNumber; }
      set { _Dimension.SerialNumber = value; }
    }

    public string Dimensiontype
    {
      get { return _Dimension.Dimensiontype;  }
      set { _Dimension.Dimensiontype = value; }
    }
    public Bitmap CanHandleStatus
    {
      get { return string.IsNullOrEmpty(_Dimension.CadHandle) ? Resource.PROCESS_PROCESSING : Resource.PROCESS_RIGHT; }
    }
    /// <summary>
    /// 直径符号
    /// </summary>

    public float Nominal
    {
      get { return _Dimension.Nominal; }
      set { _Dimension.Nominal = value; }
    }

    public override bool Equals(object i_Obj)
    {
      var mv = i_Obj as EditDimensionEntityViewModel;
      if (mv == null) return false;
      if (_Dimension == null || mv._Dimension == null)
        return false;
      return mv._Dimension.SerialNumber == _Dimension.SerialNumber;
    }

    public float PlusTol { get { return _Dimension.PlusTol; } set { _Dimension.PlusTol = value; } }
    public float MinusTol { get { return _Dimension.MinusTol; } set { _Dimension.MinusTol = value; } }
  }
}
