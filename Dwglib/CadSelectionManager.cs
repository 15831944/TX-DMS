using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public bool IsInitializing = false;
    public void Initialize(Database pDb)
    {
      _IsInitialized = false;
      Dispose();
      Mediator.Mediator.Instance.NotifyColleagues(Mediator.Cad.Parsing, CadParseStatus.Started);
      _ValidDbObjects.Clear();
        try
          {
            /****************************************************************/
            /* Display the File Version                                     */
            /****************************************************************/
            Debug.WriteLine(string.Format("File Version: {0}", pDb.OriginalFileVersion));
            /****************************************************************/
            /* Dump the database                                            */
            /****************************************************************/
            IsInitializing = true;
            _Dumper = new DbDumper();
            _Dumper.dump(pDb, 0);
            Debug.WriteLine(string.Format("Dump is completed", pDb.OriginalFileVersion));
        }
        /********************************************************************/
        /* Display the error                                                */
        /********************************************************************/
        catch (System.Exception e)
        {
          Debug.WriteLine(@"Teigha?NET for .dwg files Error: " + e.Message);
          Mediator.Mediator.Instance.NotifyColleagues(Mediator.Cad.Parsing, CadParseStatus.Error);
        }
        Mediator.Mediator.Instance.NotifyColleagues(Mediator.Cad.Parsing, CadParseStatus.Finished);
      IsInitializing = false;
      _IsInitialized = true;
    }

    private DbDumper _Dumper;
    public void Dispose()
    {
      if (_Dumper != null)
      {
        _Dumper.Dispose();
      }
    }
  }
}
