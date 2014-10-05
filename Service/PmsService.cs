﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Exception;
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

    public Part CurrentTemplate { get; set; }

    public void CreatePart(Part i_Part)
    {

    }

    public List<Part> GetParts()
    {
      var part = new DbPart();
      return part.GetParts();
    }

    public List<Part> GetParts(string i_CadNumber)
    {
      var part = new DbPart();
      return part.GetPartsByCadNumber(i_CadNumber);
    }

    public void GetDimensionsByPart(Part i_Part)
    {
      var dimension = new DbDimension();
      i_Part.Dimensions = dimension.GetDimensionsByPart(i_Part);
      i_Part.Dimensions.Sort((i_Dimension, i_Dimension1) => i_Dimension.SerialNumber - i_Dimension1.SerialNumber);
    }

    public void SaveDimesinos(List<Dimension> i_Dimensions)
    {
      foreach (var dimension in i_Dimensions)
      {
        SaveDimesino(dimension);
      }
    }

    public string CurrentCadHandle { get; set; }

    public void SaveDimesino(Dimension i_GetDimension)
    {
      var dbDimension = new DbDimension();
      int ret = dbDimension.UpdateDimension(i_GetDimension);
      if (ret == 0)
        dbDimension.InsertDimension(i_GetDimension);
    }
    public void DeleteDimension(Dimension i_Dimension)
    {
      var dbDimension = new DbDimension();
      if (i_Dimension.Id > 0)
        dbDimension.DeleteDimension(i_Dimension);
    }
    public void SavePart(Part i_Part)
    {
      var dbPart = new DbPart();
      int ret = dbPart.UpdatePart(i_Part);
      if (ret == 0)
        dbPart.InsertPart(i_Part);
    }

    public void InsertDimension(Dimension i_Dimension)
    {
      var dbDimension = new DbDimension();
      dbDimension.InsertDimension(i_Dimension);
    }

    public List<PartReport> GetPartReports()
    {
      var dbPartReport = new DbPartReport();
      return dbPartReport.GetPartReports();
    }
    public List<PartReport> GetPartReports(Part i_Part)
    {
      var dbPartReport = new DbPartReport();
      return dbPartReport.GetPartReportsByPart(i_Part);
    }
    public void SaveReport(PartReport i_PartReport)
    {
      var dbPartReport = new DbPartReport();
      dbPartReport.InsertPartReport(i_PartReport);
    }

    public void CheckUser(string i_UserName, string i_Password)
    {
      var dbUser = new DbUser();
      var users = dbUser.GetUsers(i_UserName);
      if(users.Count==0)
        throw new PmsUserNotFondException(i_UserName);
      var u = users[0];
      if (u.Password.Trim() != i_Password.Trim())
        throw new PmsIncorrectPasswordException(i_UserName);
    }
  }
}
