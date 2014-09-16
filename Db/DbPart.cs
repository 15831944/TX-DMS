using System;
using System.Collections.Generic;
using System.Text;
using Core.Model;
using Db.db;

namespace Db
{
    public class DbPart
    {
        public List<Part> GetParts()
        {
            var result = new List<Part>();
            DbHelper db = new DbHelper();
            var selCmd = db.GetSqlStringCommond("Select * from Part");
            var reader = db.ExecuteReader(selCmd);
            while (reader.Read())
            {
              result.Add(new Part() { Id = reader.GetInt32(0), Name = reader.GetString(1), CadNumber = reader.GetString(2) });
            }
            selCmd.Connection.Close();
            return result;
        }
        public List<Part> GetPartsByCadNumber(string i_CadNumber)
        {
            var result = new List<Part>();
            DbHelper db = new DbHelper();
            var selCmd = db.GetSqlStringCommond(string.Format("Select * from Part where CadNumber={0}", i_CadNumber));
            var reader = db.ExecuteReader(selCmd);
            while (reader.Read())
            {
              result.Add(new Part() { Name = reader.GetString(1), CadNumber = reader.GetString(2), SecondNumber = reader.GetString(3)});
            }
            selCmd.Connection.Close();
            return result;
        }
    }
}
