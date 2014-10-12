using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using Core.Model;
using Db.db;

namespace Db
{
  public class DbSupplier
  {
    private const string TableName = "Suppplier";
    private const string AllColumns = "Id, Name";
    private const string InsertColumns = " Name";

    public List<Supplier> GetSuppliers()
    {
      var result = new List<Supplier>();
      DbHelper db = new DbHelper();
      var selCmd = db.GetSqlStringCommond(string.Format("select {0} from {1} ", AllColumns, TableName));

      var reader = db.ExecuteReader(selCmd);
      while (reader.Read())
      {
        result.Add(PopulateSupplier(reader));
      }
      selCmd.Connection.Close();
      return result;
    }

    public Supplier GetSupplier(int i_Id)
    {
      var result = new List<Supplier>();
      DbHelper db = new DbHelper();
      var selCmd = db.GetSqlStringCommond(string.Format("select {0} from {1} where Id={2} ", AllColumns, TableName, i_Id));

      var reader = db.ExecuteReader(selCmd);
      while (reader.Read())
      {
        result.Add(PopulateSupplier(reader));
      }
      selCmd.Connection.Close();
      if(result.Count==0) return new Supplier(){Id = -1};
      return result[0];
    }

    public void InsertSupplier(Supplier i_Supplier)
    {
      DbHelper db = new DbHelper();
      var updateCmd = db.GetSqlStringCommond(
        //Name";
        string.Format(
          "insert into {0} ({1}) values('{2}')", TableName, InsertColumns,
         i_Supplier.Name));
      db.ExecuteNonQuery(updateCmd);
      var selectCmd = db.GetSqlStringCommond(string.Format("select MAX(ID) from {0}", TableName));
      selectCmd.Connection.Open();
      var reader = selectCmd.ExecuteReader();
      if (reader.Read())
      {
        i_Supplier.Id = reader.GetInt32(0);
      }
      selectCmd.Connection.Close();
    }
    public void UpdateSupplier(Supplier i_Supplier)
    {
      DbHelper db = new DbHelper();
      var updateCmd = db.GetSqlStringCommond(
        //Name";
        string.Format(
          "update {0} set Name='{1}' where ID={2}",
         TableName, i_Supplier.Name, i_Supplier.Id));
      db.ExecuteNonQuery(updateCmd);
    }
    private Supplier PopulateSupplier(DbDataReader i_Reader)
    {
      //"Id, TaskID, MeasureDatetime, Operator, OperatorComment, Auditor, AuditDatetime, AuditComment, Approver, ApproveDatetime, ApproveComment";
      int i = 0;
      return new Supplier()
      {
        Id = i_Reader.GetInt32(i),
        Name = i_Reader.IsDBNull(++i) ? "" : i_Reader.GetString(i),
      };
    }
  }
}
