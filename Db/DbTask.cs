using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using Core.Model;
using Db.db;

namespace Db
{
  public class DbTask
  {
    private const string TableName = "Task";
    private const string AllColumns = "Id, PartID, SupplierId, TotalNumber, SampleNumber, CreateDatetime, Name, Creator";
    private const string InsertColumns = " PartID, SupplierId, TotalNumber, SampleNumber, CreateDatetime, Name, Creator";

    public List<Task> GetTasks()
    {
      var result = new List<Task>();
      DbHelper db = new DbHelper();
      var selCmd = db.GetSqlStringCommond(string.Format("select {0} from {1} ", AllColumns, TableName));

      var reader = db.ExecuteReader(selCmd);
      while (reader.Read())
      {
        result.Add(PopulateTask(reader));
      }
      selCmd.Connection.Close();
      return result;
    }

    public Task GetTask(Task i_Task)
    {
      var result = new List<Task>();
      DbHelper db = new DbHelper();
      var selCmd = db.GetSqlStringCommond(string.Format("select {0} from {1} where Id={2} ", AllColumns, TableName, i_Task.Id));

      var reader = db.ExecuteReader(selCmd);
      while (reader.Read())
      {
        result.Add(PopulateTask(reader));
      }
      selCmd.Connection.Close();
      if(result.Count==0) return new Task(){Id = -1};
      return result[0];
    }

    public int UpdateTask(Task i_Task)
    {
      DbHelper db = new DbHelper();
      var updateCmd = db.GetSqlStringCommond(
        //" PartID, SupplierId, TotalNumber, SampleNumber, CreateDatetime, Name";
        string.Format(
          "update {0} set PartID={1},SupplierId={2},TotalNumber={3},SampleNumber={4}, CreateDatetime='{5}',Name='{6}', Creator='{7}' where ID={8}",
         TableName, i_Task.Part.Id, i_Task.Supplier.Id, i_Task.TotalNumber, i_Task.SampleNumber, i_Task.CreateDatetime, i_Task.Name, i_Task.Creator, i_Task.Id));
      return db.ExecuteNonQuery(updateCmd);
    }

    public void InsertTask(Task i_Task)
    {
      DbHelper db = new DbHelper();
      var updateCmd = db.GetSqlStringCommond(
        //" PartID, SupplierId, TotalNumber, SampleNumber, CreateDatetime, Name, Creator";
        string.Format(
          "insert into {0} ({1}) values({2},{3},{4},{5},'{6}','{7}','{8}')", TableName, InsertColumns,
         i_Task.Part.Id, i_Task.Supplier.Id,i_Task.TotalNumber, i_Task.SampleNumber, i_Task.CreateDatetime, i_Task.Name, i_Task.Creator));
      db.ExecuteNonQuery(updateCmd);
      var selectCmd = db.GetSqlStringCommond(string.Format("select MAX(ID) from {0}", TableName));
      selectCmd.Connection.Open();
      var reader = selectCmd.ExecuteReader();
      if (reader.Read())
      {
        i_Task.Id = reader.GetInt32(0);
      }
      selectCmd.Connection.Close();
    }

    private Task PopulateTask(DbDataReader i_Reader)
    {
      //"Id, PartID, SupplierId, TotalNumber, SampleNumber, CreateDatetime, Name";
      int i = 0;
      return new Task()
        {
          Id = i_Reader.GetInt32(i),
          Part = new Part() {Id = i_Reader.IsDBNull(++i) ? -1 : i_Reader.GetInt32(i)},
          Supplier = new Supplier() {Id = i_Reader.IsDBNull(++i) ? -1 : i_Reader.GetInt32(i)},
          TotalNumber = i_Reader.IsDBNull(++i) ? 0 : i_Reader.GetInt32(i),
          SampleNumber = i_Reader.IsDBNull(++i) ? 0 : i_Reader.GetInt32(i),
          CreateDatetime = i_Reader.IsDBNull(++i) ? PartReport.InvalidDateTime : i_Reader.GetDateTime(i),
          Name = i_Reader.IsDBNull(++i) ? "" : i_Reader.GetString(i),
          Creator = i_Reader.IsDBNull(++i) ? "" : i_Reader.GetString(i),
        };
    }
  }
}
