using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
using System.Text;
using Core.Model;
using Db.db;

namespace Db
{
  public class DbDimension
  {
    public List<Dimension> GetDimensions()
    {
      var result = new List<Dimension>();
      DbHelper db = new DbHelper();
      var selCmd = db.GetSqlStringCommond("Select Id, SerialNumber, Prefix, Symbol, Norminal, MinusTol, PlusTol, Measured, Type, PartID, MeasurementReportID from Dimenstion");
      var reader = db.ExecuteReader(selCmd);
      while (reader.Read())
      {
        result.Add(PopulateADimension(reader));
      }
      selCmd.Connection.Close();
      return result;
    }
    public List<Dimension> GetDimensionsByPart(Part i_Part)
    {
      var result = new List<Dimension>();
      DbHelper db = new DbHelper();
      var selCmd = db.GetSqlStringCommond("Select Id, SerialNumber, Prefix, Symbol, Norminal, MinusTol, PlusTol, Measured, Type, PartID, MeasurementReportID from Dimenstion");
      var reader = db.ExecuteReader(selCmd);
      while (reader.Read())
      {
        if(reader.IsDBNull(9)|| reader.GetInt32(9) != i_Part.Id)
          continue;
        result.Add(PopulateADimension(reader));
      }
      selCmd.Connection.Close();
      return result;
    }

    public List<Dimension> GetDimensionsByMeasureMentReport(PartReport i_PartReport)
    {
      var result = new List<Dimension>();
      DbHelper db = new DbHelper();
      var selCmd = db.GetSqlStringCommond("Select Id, SerialNumber, Prefix, Symbol, Norminal, MinusTol, PlusTol, Measured, Type, PartID, MeasurementReportID from Dimenstion");
      var reader = db.ExecuteReader(selCmd);
      while (reader.Read())
      {
        if (reader.IsDBNull(10) || reader.GetInt32(10) != i_PartReport.Id)
          continue;
        result.Add(PopulateADimension(reader));
      }
      selCmd.Connection.Close();
      return result;
    }

    private Dimension PopulateADimension(DbDataReader i_Reader)
    {

        var id = i_Reader.GetInt32(0);
          var serialNumber = i_Reader.GetInt16(1);
          var preFix = i_Reader.IsDBNull(2)?"":i_Reader.GetString(2).Trim();
          var symbol = i_Reader.IsDBNull(3) ? ' ' : (char)i_Reader.GetInt16(3);
          var nominal = i_Reader.GetDouble(4);
          var minusTol = i_Reader.IsDBNull(5) ? float.NaN : i_Reader.GetDouble(5);
          var plusTol = i_Reader.GetDouble(6);
          var measured = i_Reader.IsDBNull(7) ? float.NaN : i_Reader.GetDouble(7);
        var dimensiontype =i_Reader.IsDBNull(8) ? "": i_Reader.GetString(8).Trim();
        return new Dimension()
          {
            Id = id,
            SerialNumber = serialNumber,
            PreFix = preFix,
            Symbol = symbol,
            Nominal = (float)nominal,
            MinusTol = (float)minusTol,
            PlusTol = (float)plusTol,
            Measured = (float)measured,
            Dimensiontype = dimensiontype
          };
      }

    
  }
}
