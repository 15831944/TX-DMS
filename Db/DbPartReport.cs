using System;
using System.Collections.Generic;
using System.Data.Common;
using Core.Model;
using Db.db;

namespace Db
{
  public class DbPartReport
  {
    private const string TableName="MeasuremntReport";
    private const string AllColumns = "Id, SampleCount, TotalCount, Supplier,  Operator,MeasureDatetime, OperatorComment, Auditor, AuditDatetime, AuditComment, Approver, ApproveDatetime, ApproveComment, PartID";
    private const string InsertColumns = "SampleCount, TotalCount, Supplier,  Operator,MeasureDatetime, OperatorComment, Auditor, AuditDatetime, AuditComment, Approver, ApproveDatetime, ApproveComment, PartID";
    public List<PartReport> GetPartReports()
    {
      var result = new List<PartReport>();
      DbHelper db = new DbHelper();
      var selCmd = db.GetSqlStringCommond(string.Format("select {0} from {1} ", AllColumns, TableName));

      var reader = db.ExecuteReader(selCmd);
      while (reader.Read())
      {
        result.Add(PopulatePartReport(reader));
      }
      selCmd.Connection.Close();
      return result;
    }

    public List<PartReport> GetPartReportsByPart(Part i_Part)
    {
      var result = new List<PartReport>();
      DbHelper db = new DbHelper();
      var selCmd = db.GetSqlStringCommond(string.Format("select {0} from {1} where PartID={2}", AllColumns, TableName,i_Part.Id));

      var reader = db.ExecuteReader(selCmd);
      while (reader.Read())
      {
        result.Add(PopulatePartReport(reader));
      }
      selCmd.Connection.Close();
      return result;
    }

    public void InsertPartReport(PartReport i_PartReport)
    {
      DbHelper db = new DbHelper();
      var updateCmd = db.GetSqlStringCommond(
        //"SampleCount, TotalCount, Supplier,  Operator,MeasureDatetime, OperatorComment, Auditor, AuditDatetime, AuditComment, Approver, ApproveDatetime, ApproveComment, PartID";
        string.Format(
          "insert into {0} ({1}) values({2},{3},'{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}',{14})",TableName,InsertColumns,
          i_PartReport.SampleCount,i_PartReport.TotalCount,i_PartReport.Supplier,i_PartReport.Operator,i_PartReport.MeasurementDatetime
          ,i_PartReport.OperatorComment,i_PartReport.Auditor,i_PartReport.AuditDatetime, i_PartReport.AuditComment,
          i_PartReport.Approver,i_PartReport.ApproveDatetime,i_PartReport.ApproveComment,i_PartReport.Part.Id));
      db.ExecuteNonQuery(updateCmd);
      var selectCmd = db.GetSqlStringCommond(string.Format("select MAX(ID) from {0}", TableName));
      selectCmd.Connection.Open();
      var reader = selectCmd.ExecuteReader();
      if (reader.Read())
      {
        i_PartReport.Id = reader.GetInt32(0);
      }
      selectCmd.Connection.Close();
    }

    private PartReport PopulatePartReport(DbDataReader i_Reader)
    {
      return new PartReport()
        {
          Id = i_Reader.GetInt32(0),
          SampleCount = i_Reader.IsDBNull(1) ? 0 : i_Reader.GetInt32(1),
          TotalCount = i_Reader.IsDBNull(2) ? 0 : i_Reader.GetInt32(2),
          Supplier = i_Reader.IsDBNull(3) ? "" : i_Reader.GetString(3),
          Operator = i_Reader.IsDBNull(4) ? "" : i_Reader.GetString(4),
          MeasurementDatetime = i_Reader.IsDBNull(5) ? DateTime.Now : i_Reader.GetDateTime(5),
          OperatorComment = i_Reader.IsDBNull(6) ? "" : i_Reader.GetString(6),
          Auditor = i_Reader.IsDBNull(7) ? "" : i_Reader.GetString(7),
          AuditDatetime = i_Reader.IsDBNull(8) ? DateTime.Now : i_Reader.GetDateTime(8),
          AuditComment = i_Reader.IsDBNull(9) ? "" : i_Reader.GetString(9),
          Approver = i_Reader.IsDBNull(10) ? "" : i_Reader.GetString(10),
          ApproveDatetime = i_Reader.IsDBNull(11) ? DateTime.Now : i_Reader.GetDateTime(11),
          ApproveComment = i_Reader.IsDBNull(12) ? "" : i_Reader.GetString(12),
          Part = new Part() {Id = i_Reader.IsDBNull(13) ? 0 : i_Reader.GetInt32(13),}
        };
    }
  }
}
