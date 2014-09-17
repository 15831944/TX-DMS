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

    public void SaveDimesinos(List<Dimension> i_Dimensions)
    {
      DbDimension dbDimension = new DbDimension();
      dbDimension.CommitDimensions(i_Dimensions);
    }

    public string CurrentCadHandle { get; set; }

    public void SaveDimesino(Dimension i_GetDimension)
    {
          DbDimension dbDimension = new DbDimension();
          dbDimension.CommitDimension(i_GetDimension);
    }

    public void SavePart(Part i_Part)
    {
      DbPart dbPart = new DbPart();
      dbPart.CommitPart(i_Part);
    }
  }
}
