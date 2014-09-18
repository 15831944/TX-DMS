using System;
using System.Collections.Generic;
using System.Text;
using Core.Model;
using Db.db;

namespace Db
{
  public class DbPart
  {
    private const string Columns = "Id, Name, CadNumber, CadK3Number, CAdFileName";
    private const string InsertColumns ="Name, CadNumber, CadK3Number, CAdFileName";
    private const string TableName = "Part";
    public List<Part> GetParts()
    {
      var result = new List<Part>();
      DbHelper db = new DbHelper();
      var selCmd = db.GetSqlStringCommond(string.Format("Select {0} from Part", Columns));
      var reader = db.ExecuteReader(selCmd);
      while (reader.Read())
      {
        result.Add(new Part()
          {
            Id = reader.GetInt32(0),
            Name = reader.IsDBNull(1) ? "" : reader.GetString(1),
            CadNumber = reader.IsDBNull(2) ? "" : reader.GetString(2),
            SecondNumber = reader.IsDBNull(3) ? "" : reader.GetString(3),
            CadFilename = reader.IsDBNull(4) ? "" : reader.GetString(4),
          });
      }
      selCmd.Connection.Close();
      return result;
    }

    public List<Part> GetPartsByCadNumber(string i_CadNumber)
    {
      var result = new List<Part>();
      DbHelper db = new DbHelper();
      var selCmd =
        db.GetSqlStringCommond(string.Format("Select {1} from Part where CadNumber={0}", i_CadNumber, Columns));
      var reader = db.ExecuteReader(selCmd);
      while (reader.Read())
      {
        result.Add(new Part()
          {
            Name = reader.IsDBNull(1)?"": reader.GetString(1),
            CadNumber = reader.IsDBNull(2) ? "" : reader.GetString(2),
            SecondNumber = reader.IsDBNull(3) ? "" : reader.GetString(3),
            CadFilename = reader.IsDBNull(4) ? "" : reader.GetString(4),
          });
      }
      selCmd.Connection.Close();
      return result;
    }

    public int UpdatePart(Part i_Part)
    {
      DbHelper db = new DbHelper();
      var updateCmd =
        db.GetSqlStringCommond(
          string.Format("update {0} set Name='{1}', CadNumber='{2}', CadK3Number='{3}', CAdFileName='{4}' where ID ={5}",
                        TableName, i_Part.Name, i_Part.CadNumber, i_Part.SecondNumber, i_Part.CadFilename, i_Part.Id));
     return db.ExecuteNonQuery(updateCmd);
    }

    public void InsertPart(Part i_Part)
    {
      DbHelper db = new DbHelper();
      var updateCmd =
        db.GetSqlStringCommond(
          string.Format("insert into {0} ({1}) values('{2}','{3}', '{4}', '{5}')",
                        TableName, InsertColumns,i_Part.Name, i_Part.CadNumber, i_Part.SecondNumber, i_Part.CadFilename));
      db.ExecuteNonQuery(updateCmd);
      db = new DbHelper();
      var selectCmd = db.GetSqlStringCommond(string.Format("select MAX(ID) from {0}", TableName));
      var reader = selectCmd.ExecuteReader();
      if (reader.Read())
      {
        i_Part.Id = reader.GetInt32(0);
      }
      selectCmd.Connection.Close();
    }
  }
}
