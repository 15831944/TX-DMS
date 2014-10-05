using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using Core.Model;
using Db.db;

namespace Db
{
  public class DbUser
  {
    private const string TableName = "[User]";
    private const string AllColumns = "Id, Name, PassWord,  GroupId";
    private const string InsertColumns = "Name, PassWord,  GroupId";
    private const string UserGroupColumns = "Id, Name";
    private const string UserGroupTableName = "UserGroup";
    public List<User> GetUsers()
    {
      var result = new List<User>();

      DbHelper db = new DbHelper();
      var selCmd = db.GetSqlStringCommond(string.Format("select {0} from {1} ", AllColumns, TableName));
      try
      {
        var reader = db.ExecuteReader(selCmd);
        while (reader.Read())
        {
          result.Add(PopulateUser(reader));
        }
      }
      catch (Exception)
      {
        //todo add log
      }
      finally
      {
        selCmd.Connection.Close();
      }
      return result;
    }

    private User PopulateUser(DbDataReader i_Reader)
    {
      var result = new User()
      {
        Id = i_Reader.GetInt32(0),
        Name = i_Reader.IsDBNull(1) ? "" : i_Reader.GetString(1),
        Password = i_Reader.IsDBNull(2) ? "" : i_Reader.GetString(2),
      };
      var groupId = i_Reader.IsDBNull(3) ? 0 : i_Reader.GetInt32(3);
      var group = GetUserGroup(groupId);
      if (group.Count > 0)
      {
        result.Group = group[0];
      }
      else
      {
        result.Group = new UserGroup();
      }
      return result;
    }

    private UserGroup PopulateUserGroup(DbDataReader i_Reader)
    {
      return new UserGroup() {Id = i_Reader.IsDBNull(0) ? 0 : i_Reader.GetInt32(0),Name = i_Reader.IsDBNull(1)?"":i_Reader.GetString(1)};
    }
    public List<User> GetUsers(string i_Name)
    {
      var result = new List<User>();
      DbHelper db = new DbHelper();
      var selCmd = db.GetSqlStringCommond(string.Format("select {0} from {1} where Name='{2}'", AllColumns, TableName, i_Name));

      try
      {
        var reader = db.ExecuteReader(selCmd);
        while (reader.Read())
        {
          result.Add(PopulateUser(reader));
        }
        selCmd.Connection.Close();
      }
      catch (Exception ex)
      {
        //Todo add log
      }
      finally
      {
        selCmd.Connection.Close();
      }
      return result;
    }

    private List<UserGroup> GetUserGroup(int i_Id)
    {
      var result = new List<UserGroup>();
      DbHelper db = new DbHelper();
      var selCmd = db.GetSqlStringCommond(string.Format("select {0} from {1} where Id='{2}'", UserGroupColumns, UserGroupTableName, i_Id));

      try
      {
        var reader = db.ExecuteReader(selCmd);
        while (reader.Read())
        {
          result.Add(PopulateUserGroup(reader));
        }
        selCmd.Connection.Close();
      }
      catch (Exception ex)
      {
        //Todo add log
      }
      finally
      {
        selCmd.Connection.Close();
      }
      return result;
    }
  }
}
