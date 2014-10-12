using System;
using System.Collections.Generic;
using System.Data.Common;
using Core.Model;
using Db.db;

namespace Db
{
  public class DbPartReport
  {
    private const string TableName="Report";
    private const string AllColumns = "Id, TaskID, MeasureDatetime, Operator, OperatorComment, Auditor, AuditDatetime, AuditComment, Approver, ApproveDatetime, ApproveComment";
    private const string InsertColumns = " TaskID, MeasureDatetime, Operator, OperatorComment, Auditor, AuditDatetime, AuditComment, Approver, ApproveDatetime, ApproveComment";
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

    /// <summary>
    /// 
    /// </summary>
    /// <param name="i_Task"></param>
    /// <returns></returns>
    public List<PartReport> GetPartReports(Task i_Task)
    {
      var result = new List<PartReport>();
      DbHelper db = new DbHelper();
      var selCmd =
        db.GetSqlStringCommond(string.Format("select {0} from {1} where TaskId={2}", AllColumns, TableName, i_Task.Id));

      var reader = db.ExecuteReader(selCmd);
      while (reader.Read())
      {
        result.Add(PopulatePartReport(reader));
      }
      selCmd.Connection.Close();
      return result;
    }

    public void UpdatePartReport(PartReport i_PartReport)
    {
      DbHelper db = new DbHelper();
      var updateCmd = db.GetSqlStringCommond(
        //" TaskID, MeasureDatetime, Operator, OperatorComment, Auditor, AuditDatetime, AuditComment, Approver, ApproveDatetime, ApproveComment";
        string.Format(
          "update {0} set Operator='{1}',MeasureDatetime='{2}',OperatorComment='{3}',Auditor='{4}', AuditDatetime='{5}',AuditComment='{6}',Approver='{7}',ApproveDatetime='{8}',ApproveComment='{9}', TaskId={10} where ID={11}", 
         TableName, i_PartReport.Operator, i_PartReport.MeasurementDatetime
          , i_PartReport.OperatorComment, i_PartReport.Auditor, i_PartReport.AuditDatetime, i_PartReport.AuditComment,
          i_PartReport.Approver, i_PartReport.ApproveDatetime, i_PartReport.ApproveComment, i_PartReport.Task.Id, i_PartReport.Id));
      db.ExecuteNonQuery(updateCmd);
    }
    public void InsertPartReport(PartReport i_PartReport)
    {
      DbHelper db = new DbHelper();
      var updateCmd = db.GetSqlStringCommond(
        //TaskID, MeasureDatetime, Operator, OperatorComment, Auditor, AuditDatetime, AuditComment, Approver, ApproveDatetime, ApproveComment";
        string.Format(
          "insert into {0} ({1}) values({2},'{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')",TableName,InsertColumns,
         i_PartReport.Task.Id, i_PartReport.MeasurementDatetime, i_PartReport.Operator
          ,i_PartReport.OperatorComment,i_PartReport.Auditor,i_PartReport.AuditDatetime, i_PartReport.AuditComment,
          i_PartReport.Approver,i_PartReport.ApproveDatetime,i_PartReport.ApproveComment));
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
      //"Id, TaskID, MeasureDatetime, Operator, OperatorComment, Auditor, AuditDatetime, AuditComment, Approver, ApproveDatetime, ApproveComment";
      int i = 0;
      return new PartReport()
        {
          Id = i_Reader.GetInt32(i),
          Task = new Task() { Id = i_Reader.IsDBNull(++i) ? 0 : i_Reader.GetInt32(i) },
          MeasurementDatetime = i_Reader.IsDBNull(++i) ? PartReport.InvalidDateTime : i_Reader.GetDateTime(i),
          Operator = i_Reader.IsDBNull(++i) ? "" : i_Reader.GetString(i),
          OperatorComment = i_Reader.IsDBNull(++i) ? "" : i_Reader.GetString(i),
          Auditor = i_Reader.IsDBNull(++i) ? "" : i_Reader.GetString(i),
          AuditDatetime = i_Reader.IsDBNull(++i) ? PartReport.InvalidDateTime : i_Reader.GetDateTime(i),
          AuditComment = i_Reader.IsDBNull(++i) ? "" : i_Reader.GetString(i),
          Approver = i_Reader.IsDBNull(++i) ? "" : i_Reader.GetString(i),
          ApproveDatetime = i_Reader.IsDBNull(++i) ? PartReport.InvalidDateTime : i_Reader.GetDateTime(i),
          ApproveComment = i_Reader.IsDBNull(++i) ? "" : i_Reader.GetString(i),
        };
    }
  }
}
