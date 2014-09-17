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

    private const string SelectColums =
      "Id, SerialNumber, Prefix, Symbol, Norminal, MinusTol, PlusTol, Measured, Type, PartID, MeasurementReportID, CadHandle";

    private const string TableName = "Dimenstion";
    public List<Dimension> GetDimensions()
    {
      var result = new List<Dimension>();
      DbHelper db = new DbHelper();
      var selCmd = db.GetSqlStringCommond(string.Format("Select {0} from {1}", SelectColums, TableName));
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
      var selCmd = db.GetSqlStringCommond(string.Format("Select {0} from {2} where PartID = {1}", SelectColums, i_Part.Id, TableName));
      var reader = db.ExecuteReader(selCmd);
      while (reader.Read())
      {
        result.Add(PopulateADimension(reader));
      }
      selCmd.Connection.Close();
      return result;
    }

    public List<Dimension> GetDimensionsByMeasureMentReport(PartReport i_PartReport)
    {
      var result = new List<Dimension>();
      DbHelper db = new DbHelper();
      var selCmd =
        db.GetSqlStringCommond(
          string.Format(
            "Select {0} from {2} where MeasurementReportID = {1}", SelectColums
            , i_PartReport.Id, TableName));
      var reader = db.ExecuteReader(selCmd);
      while (reader.Read())
      {
        result.Add(PopulateADimension(reader));
      }
      selCmd.Connection.Close();
      return result;
    }

    public void CommitDimensions(List<Dimension> i_Dimensions)
    {
      DbHelper db = new DbHelper();
      // "Id, SerialNumber, Prefix, Symbol, Norminal, MinusTol, PlusTol, Measured, Type, PartID, MeasurementReportID, CadHandle";
      foreach (var dimension in i_Dimensions)
      {
        var updateCmd = db.GetSqlStringCommond(
          string.Format(
            "update {0} set SerialNumber={2}, Prefix='{3}', Symbol={4},Norminal={5}, MinusTol={6}, PlusTol={7}, Measured={8}, Type='{9}', CadHandle='{10}' where Id = {1}",
            TableName, dimension.Id, dimension.SerialNumber, dimension.PreFix, (int)dimension.Symbol, dimension.Nominal,
            dimension.MinusTol, dimension.PlusTol, float.IsNaN(dimension.Measured) ? "null" : dimension.Measured.ToString("0.00"),
            dimension.Dimensiontype, dimension.CadHandle));
        db.ExecuteNonQuery(updateCmd);
      }
    }

    public void CommitDimension(Dimension i_Dimension)
    {
      DbHelper db = new DbHelper();
        var updateCmd = db.GetSqlStringCommond(
          string.Format(
            "update {0} set SerialNumber={2}, Prefix='{3}', Symbol={4},Norminal={5}, MinusTol={6}, PlusTol={7}, Measured={8}, Type='{9}', CadHandle='{10}' where Id = {1}",
            TableName, i_Dimension.Id, i_Dimension.SerialNumber, i_Dimension.PreFix, (int)i_Dimension.Symbol, i_Dimension.Nominal,
            i_Dimension.MinusTol, i_Dimension.PlusTol, float.IsNaN(i_Dimension.Measured) ? "null" : i_Dimension.Measured.ToString("0.00"),
            i_Dimension.Dimensiontype, i_Dimension.CadHandle));
        db.ExecuteNonQuery(updateCmd);
    }

    private Dimension PopulateADimension(DbDataReader i_Reader)
    {

      var id = i_Reader.GetInt32(0);
      var serialNumber = i_Reader.GetInt16(1);
      var preFix = i_Reader.IsDBNull(2) ? "" : i_Reader.GetString(2).Trim();
      var symbol = i_Reader.IsDBNull(3) ? ' ' : (char) i_Reader.GetInt16(3);
      var nominal = i_Reader.GetDouble(4);
      var minusTol = i_Reader.GetDouble(5);
      var plusTol = i_Reader.GetDouble(6);
      var measured = i_Reader.IsDBNull(7) ? float.NaN : i_Reader.GetDouble(7);
      var dimensiontype = i_Reader.IsDBNull(8) ? "" : i_Reader.GetString(8).Trim();
      var cadHandle = i_Reader.IsDBNull(11) ? "" : i_Reader.GetString(11).Trim();
      return new Dimension()
        {
          Id = id,
          SerialNumber = serialNumber,
          PreFix = preFix,
          Symbol = symbol,
          Nominal = (float) nominal,
          MinusTol = (float) minusTol,
          PlusTol = (float) plusTol,
          Measured = (float) measured,
          Dimensiontype = dimensiontype,
          CadHandle = cadHandle
        };
    }
  }
}
