using System;
using System.Collections.Generic;
using System.Text;
using Core.Model;
using Db;

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
    private static List<Dimension> _dimensionEntities;

    static PmsService()
    {
      // CreateMockData();
    }

    private static void CreateMockData()
    {
      _dimensionEntities = new List<Dimension>();
      _partTemplates = new List<Part>();

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

    public List<Part> GetParts()
    {
      DbPart part = new DbPart();
      return part.GetParts();
    }

    public List<Part> GetParts(string i_CadNumber)
    {
      DbPart part = new DbPart();
      return part.GetPartsByCadNumber(i_CadNumber);
    }

    public void GetDimensionsByPart(Part i_Part)
    {
      DbDimension dimension = new DbDimension();
      i_Part.Dimensions = dimension.GetDimensionsByPart(i_Part);
      i_Part.Dimensions.Sort((i_Dimension, i_Dimension1) => i_Dimension.SerialNumber - i_Dimension1.SerialNumber);
    }


  }
}
