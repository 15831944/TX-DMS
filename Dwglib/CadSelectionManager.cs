using System;
using System.Collections.Generic;
using System.IO;
using Mediator;
using Teigha.DatabaseServices;

namespace Dwglib
{
  public class CadSelectionManager
  {
    private readonly List<DBObject> _ValidDbObjects = new List<DBObject>();
   
    private CadSelectionManager()
    {
      Mediator.Mediator.Instance.Register(Cad.OnValidDimensionParsed,i_O =>
        {
          var o = i_O as DBObject;
          if(o==null) return;
          _ValidDbObjects.Add(o);
        });
    }

    private static readonly CadSelectionManager _Instance = new CadSelectionManager();
    public static CadSelectionManager Instance{get { return _Instance; }}

    public DBObject GetObjectById(string i_IdStrng)
    {
      if (!_IsInitialized) return null;
      DBObject result = null;
      foreach (var validDbObject in _ValidDbObjects)
      {
        if (validDbObject.Id.ToString() == i_IdStrng)
        {
          result = validDbObject;
          break;
        }
      }
      return result;
    }

    public DBObject GetObjectByHandle(string i_HandleString)
    {
      if (!_IsInitialized) return null;
      DBObject result = null;
      foreach (var validDbObject in _ValidDbObjects)
      {
        if (validDbObject.Handle.ToString() == i_HandleString)
        {
          result = validDbObject;
          break;
        }
      }
      return result;
    }

    private bool _IsInitialized = false;
    public void Initialize(Database pDb)
    {
      _IsInitialized = false;
      _ValidDbObjects.Clear();
        try
          {
            /****************************************************************/
            /* Display the File Version                                     */
            /****************************************************************/
            Console.WriteLine("File Version: {0}", pDb.OriginalFileVersion);
            /****************************************************************/
            /* Dump the database                                            */
            /****************************************************************/
            var dumper = new DbDumper();
            dumper.dump(pDb, 0);
          
        }
        /********************************************************************/
        /* Display the error                                                */
        /********************************************************************/
        catch (System.Exception e)
        {
          Console.WriteLine(@"Teigha?NET for .dwg files Error: " + e.Message);
        }
      _IsInitialized = true;
    }
    
  }
}
