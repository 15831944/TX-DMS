using System;
using System.Collections.Generic;
using System.Text;
using Core.Model;

namespace Core.Service
{
  public class PmsService
  {
    private static PmsService _pmsService;

    public static PmsService Instance
    {
      get { return _pmsService ?? (_pmsService = new PmsService()); }
    }

    public List<Part> GetPartTemplates()
    {
      return _partTemplates;
    }

    public Part CurrentTemplate { get; set; }
  
    private static List<Part> _partTemplates;
    private static List<DimensionEntity> _dimensionEntities;
    static PmsService ()
    {
      CreateMockData();
    }

    static void CreateMockData()
    {
      _dimensionEntities = new List<DimensionEntity>();
      _partTemplates = new List<Part>();
//      for (int i = 0; i < 10; i++)
//      {
//        var dimensionTemplate = new Part()
//        {
//          PartName = string.Format("PartName {0}", i + 1),
//          PartCadNumber = string.Format("PartNumber {0}", i + 1),
//        };
//        _partTemplates.Add(dimensionTemplate);
//
//        for (int j = 0; j < 20; j++)
//        {
//          var dimensionEntity = new DimensionEntity()
//          {
//            Dimensiontype = DimensionType.GetDimension(i),
//            Index = 0,
//            MinusTol = 0.1,
//            PlusTol = 0.1,
//            Nominal = j + 5,
//            Measured = j + 5,
//            Symbol = (char)0x0424,
//          };
//          _dimensionEntities.Add(dimensionEntity);
//          dimensionTemplate.DimensionEntitys = _dimensionEntities;
//        }
//      }

      var partCadNumber = "NML1/2B.02.01-1";
      var name = "前外壳";
      var part = new Part();
      part.CadNumber = partCadNumber;
      part.Name = name;

      var index = 1;
      var dimensionType = DimensionType.GetDimension(0);
      


    }


    


    public void CreatePart(Part i_Part)
    {
      
    }
  }
}
