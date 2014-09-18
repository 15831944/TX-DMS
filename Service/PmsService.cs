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
//      DbDimension dbDimension = new DbDimension();
//      dbDimension.CommitDimensions(i_Dimensions);
      foreach (var dimension in i_Dimensions)
      {
        SaveDimesino(dimension);
      }
    }

    public string CurrentCadHandle { get; set; }

    public void SaveDimesino(Dimension i_GetDimension)
    {
      DbDimension dbDimension = new DbDimension();
      int ret = dbDimension.UpdateDimension(i_GetDimension);
      if (ret == 0)
        dbDimension.InsertDimension(i_GetDimension);
    }
    public void DeleteDimension(Dimension i_Dimension)
    {
      DbDimension dbDimension = new DbDimension();
      if (i_Dimension.Id > 0)
        dbDimension.DeleteDimension(i_Dimension);
    }
    public void SavePart(Part i_Part)
    {
      DbPart dbPart = new DbPart();
      int ret = dbPart.UpdatePart(i_Part);
      if (ret == 0)
        dbPart.InsertPart(i_Part);
    }

    public void InsertDimension(Dimension i_Dimension)
    {
      DbDimension dbDimension = new DbDimension();
      dbDimension.InsertDimension(i_Dimension);
    }
  }
}
