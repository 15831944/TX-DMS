using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Text;
using System.Threading;

namespace Mediator
{
  public enum Options
  {
    Default,
    RecieveMissedNotifies
  }
  public sealed class Mediator
  {


    //private static readonly NLog.Logger _Logger = NLog.LogManager.GetCurrentClassLogger();
    public bool DoBreakOnWarnings { get; set; }
    private static readonly Object _LockObject = new Object(); //UXP-169 (UXP-363) Alberto 02-July-2012

    private readonly Dictionary<object, object> _HoldingPen = new Dictionary<object, object>();


    #region Data

    private static readonly Mediator _Instance = new Mediator();

    //readonly MultiDictionary<Type, object> Types = new MultiDictionary<Type, object>();
    private readonly MultiDictionary<object, Action<Object>> _InternalList = new MultiDictionary<object, Action<Object>>();
    #endregion

    #region Ctor

    private Mediator()
    {

    }

    #endregion

    #region Public Properties


    public static Mediator Instance
    {
      get { return _Instance; }
    }

    #endregion

    #region Public Methods

    private static object GetTypeValueKey(object i_Message)
    {
      if (i_Message is string)
      {
        return i_Message.ToString().ToUpper();
      }

      if (i_Message.GetType().IsValueType)
      {
        return i_Message;
      }

      return i_Message.GetType();
    }

    /// <summary>
    /// Registers a Colleague to a specific message
    /// </summary>
    /// <param name="i_Message">The message to 
    ///   register to</param>
    /// <param name="i_Callback">The callback to use 
    ///   when the message it seen</param>
    /// <param name="i_Option"> </param>
    public void Register(object i_Message, Action<object> i_Callback, Options i_Option = Options.Default)
    {
      var key = GetTypeValueKey(i_Message);

      //UXP-169 (UXP-363) Alberto 02-July-2012
      lock (_LockObject)
      {
#if AUDIT_Register
        _Logger.Trace("Mediator.Register(Message {0}, callback {1})", GetTypeValueKey(i_Message).ToString(), i_Callback.Target.GetHashCode());
#endif
        _InternalList.AddValue(key, i_Callback);
      }

      // Notify the new registration of items in the holding pen
      if (i_Option == Options.RecieveMissedNotifies && _HoldingPen.ContainsKey(key))
      {
        i_Callback(_HoldingPen[key]);
      }
    }

    public int GetKeyCallbackCount(object i_Key)
    {
      //UXP-169 (UXP-363) Alberto 02-July-2012
      int retVal = 0;
      lock (_LockObject)
      {
        var key = GetTypeValueKey(i_Key);
        if (_InternalList.ContainsKey(key))
        {
          retVal = _InternalList[key].Count;
        }
      }

      return retVal;
    }

    /// <summary>
    /// Notify all colleagues that are registered to the 
    /// specific message
    /// </summary>
    /// <param name="i_Message">The message for the notify by</param>
    /// <param name="i_Args">The arguments for the message</param>
    public void NotifyColleagues(object i_Message,
                                 object i_Args)
    {
      var key = GetTypeValueKey(i_Message);
      var listToBeNotified = new MultiDictionary<object, Action<object>>();

      //UXP-169 (UXP-363) Alberto 02-July-2012
      lock (_LockObject)
      {
        _HoldingPen[key] = i_Args;

        if (_InternalList.ContainsKey(key))
        {
          listToBeNotified.AddValues(key, _InternalList[key]);
        }
        else
        {
#if AUDIT_NotifyColleagues_WarnWhenNoOneListening
              _Logger.Warn("Mediator.NotifyCollegues() Message({0}) sent but no one was registered to recieve it", key);
#endif
          if (DoBreakOnWarnings) throw new InstanceNotFoundException(string.Format("Message({0}) sent but no one was registered to recieve it", key));
        }
      }

      if (listToBeNotified.Count > 0)
      {
        //forward the message to all listeners
        foreach (Action<object> callback in
          listToBeNotified[key])
        {
          if (_InternalList[key].Contains(callback))
          {
#if AUDIT_NotifyColleagues
                var start = DateTime.Now;
#endif

            callback(i_Args);

#if AUDIT_NotifyColleagues
                var duration = DateTime.Now - start;
                _Logger.Trace("NotifyColleagues: {0} {1} took {2} ms ({3})", start.Ticks, i_Message, duration.Milliseconds, callback.Target.ToString());
#endif
          }
        }
        listToBeNotified.Clear();
      }
    }

    public void NotifyColleaguesAsync(object i_Message, object i_Args)
    {
      ThreadPool.QueueUserWorkItem(delegate { NotifyColleagues(i_Message, i_Args); });
    }

    /// <summary>
    /// Notify only last colleague that is registered to the 
    /// specific message.
    /// This method should be used to notify messages that can be only by single object
    /// </summary>
    /// <param name="i_Message">The message for the notify by</param>
    /// <param name="i_Args">The arguments for the message</param>
    public void NotifyLastColleague(object i_Message, object i_Args)
    {
      var key = GetTypeValueKey(i_Message);
      var listToBeNotified = new MultiDictionary<object, Action<object>>();

      //UXP-169 (UXP-363) Alberto 02-July-2012
      lock (_LockObject)
      {
        if (_InternalList.ContainsKey(key))
        {
          listToBeNotified.AddValues(key, _InternalList[key]);
        }
        else
        {
#if AUDIT_NotifyColleagues_WarnWhenNoOneListening
              _Logger.Warn("Mediator.NotifyCollegues() Message({0}) sent but no one was registered to recieve it", key);
#endif
          if (DoBreakOnWarnings) throw new InstanceNotFoundException(string.Format("Message({0}) sent but no one was registered to recieve it", key));
        }
      }

      if (listToBeNotified.Count > 0)
      {
        Action<object> LastCallBack = null;
        //forward the message to all listeners
        foreach (Action<object> callback in listToBeNotified[key])
        {
          if (_InternalList[key].Contains(callback))
          {
            LastCallBack = callback;
          }
        }

        if (LastCallBack != null)
        {
#if AUDIT_NotifyColleagues
          var start = DateTime.Now;
#endif
          LastCallBack(i_Args);

#if AUDIT_NotifyColleagues
          var duration = DateTime.Now - start;
          _Logger.Trace("NotifyColleagues: {0} {1} took {2} ({3})", start.Ticks, i_Message, duration.Ticks, LastCallBack.Target.ToString());
#endif
        }
      }
      listToBeNotified.Clear();
    }

    //UXP-3609 Alberto 27-Mar-2013
    /// <summary>
    /// Asynchronously notify only last colleague that is registered to the 
    /// specific message.
    /// This method should be used to notify messages that can be only by single object.
    /// </summary>
    /// <param name="i_Message">The message for the notify by</param>
    /// <param name="i_Args">The arguments for the message</param>
    public void NotifyLastColleagueAsync(object i_Message, object i_Args)
    {
      ThreadPool.QueueUserWorkItem(delegate { NotifyLastColleague(i_Message, i_Args); });
    }


    public static T Cast<T>(object i_Target, T i_Example)
    {
      return (T)i_Target;
    }

    #endregion

    public void UnRegister()
    {
      //UXP-169 (UXP-363) Alberto 02-July-2012
      lock (_LockObject)
      {
#if AUDIT_Register
          _Logger.Trace("Mediator.UnRegister()");
#endif
        _InternalList.Clear();
        _HoldingPen.Clear();
      }
    }

    // No longer thought safe - KLK
    //public void UnRegister(object i_Key)
    //{
    //  //UXP-169 (UXP-363) Alberto 02-July-2012
    //  lock(mLockObject)
    //  {
    //    var key = GetTypeValueKey(i_Key);
    //    if (mInternalList.ContainsKey(key))
    //    {
    //      //_Logger.Trace("Mediator.UnRegister() RemoveKey({0})", key.ToString());
    //      mInternalList.Remove(key);
    //    }

    //    if (_HoldingPen.ContainsKey(key))
    //    {
    //      _HoldingPen.Remove(key);
    //    }
    //  }
    //}

    public void UnRegisterObject(object i_Obj)
    {
      var listToBeRemoved = new MultiDictionary<object, Action<object>>();

      //UXP-169 (UXP-363) Alberto 02-July-2012
      lock (_LockObject)
      {
        // Loop through all the methods of this object
        foreach (var method in i_Obj.GetType().GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static))
        {
          // Try to find if this method is registered in the mediator anywhere
          foreach (var keyPair in _InternalList)
          {
            var thisMethod = method;
            foreach (var callback in keyPair.Value.Where(i_Callback => (i_Callback.Method == thisMethod && i_Callback.Target == i_Obj)))
            {
#if AUDIT_Register
                _Logger.Trace("Mediator.UnRegisterObject(HashCode={0}) callback.Target={1})", i_Obj.GetHashCode(), callback.Target.GetHashCode());
#endif
              // Check to see if this is a child object
              if (_ParentChildRelationships.Any(i_X => i_X.Child == i_Obj) == false)
              {
                // Add it to the list to be removed
                listToBeRemoved.AddValue(keyPair.Key, callback);
              }

              // If this is the last registration of this key and we have an item in the holding pen, remove it as well
              if (_HoldingPen.ContainsKey(keyPair.Key) && _InternalList[keyPair.Key].Count == 1)
              {
                _HoldingPen.Remove(keyPair.Key);
              }
              break;
            }
          }
        }

        // Now remove all the items in the remove lists
        foreach (var pair in listToBeRemoved)
        {
          foreach (var action in pair.Value)
          {
#if AUDIT_Register
              _Logger.Trace("Mediator.UnRegisterObject(HashCode={0}) RemoveValue({1},{2})", i_Obj.GetHashCode(), pair.Key.ToString(), action.Target.GetHashCode());
#endif
            _InternalList.RemoveValue(pair.Key, action);
          }
        }
      }
    }

    /// <summary>
    /// Only unregister a particular callback
    /// </summary>
    /// <param name="i_Callback"></param>
    public void UnRegister(Action<object> i_Callback)
    {
      //UXP-169 (UXP-363) Alberto 02-July-2012
      lock (_LockObject)
      {
        object key = null;
        foreach (var variable in _InternalList.Where(i_Variable => i_Variable.Value.Any(i_Action => i_Action == i_Callback)))
        {
          key = variable.Key;
        }

        //UXP-169 (UXP-181) Alberto 13-June-2012
        // To avoid exception in case the key is null.
        if (key != null)
        {
#if AUDIT_Register
          _Logger.Trace("Mediator.UnRegister() RemoveValue({0},{1})", key.ToString(), i_Callback.Target.GetHashCode());
#endif
          // If this is the last registration of this key and we have an item in the holding pen, remove it as well
          if (_HoldingPen.ContainsKey(key) && _InternalList[key].Count == 1)
          {
            _HoldingPen.Remove(key);
          }

          _InternalList.RemoveValue(key, i_Callback);
        }
      }
    }

    public bool IsRegistered(object i_Obj)
    {
      // Check to see if any of this objects methods are reeferenced in our registrations list
      return (i_Obj.GetType()
                   .GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static)
                   .Any(
                     i_Method =>
                     _InternalList.SelectMany(
                       i_KeyPair =>
                       i_KeyPair.Value.Where(i_Callback => (i_Callback.Method == i_Method && i_Callback.Target == i_Obj))).Any()));
    }

    public bool IsKeyRegistered(object i_Message)
    {
      var key = GetTypeValueKey(i_Message);
      return _InternalList.ContainsKey(key);
    }

    /// <summary>
    /// Only used for debugging - make a call to this if you want to know how many messages are registered
    /// </summary>
    public void DumpMessages()
    {
      foreach (var key in _InternalList)
      {
        //_Logger.Warn("****Count {0} of Mediator Message({1})****", _InternalList[key.Key].Count, key);
      }
    }

    public void EmptyHoldingPen(object i_Message)
    {
      var key = GetTypeValueKey(i_Message);
      if (_HoldingPen.ContainsKey(key))
      {
        _HoldingPen.Remove(key);
      }
    }

    private readonly List<MediatorRelationship> _ParentChildRelationships = new List<MediatorRelationship>();

    public void CreateChildRelationship(object i_ParentObject, object i_Vm, Action i_AddAction)
    {
      _ParentChildRelationships.Add(new MediatorRelationship { Parent = i_ParentObject, Child = i_Vm });

      //i_AddAction();
    }

    public void DestroyChildRelationship(object i_Parent, object i_Child, Action i_RemoveAction)
    {
      var relationship = _ParentChildRelationships.FirstOrDefault(i_X => i_X.Parent == i_Parent && i_X.Child == i_Child);
      if (relationship != null)
      {
        _ParentChildRelationships.Remove(relationship);
      }

      //i_RemoveAction();
    }
  }

  internal class MediatorRelationship
  {
    public object Parent { get; set; }
    public object Child { get; set; }
  }

  /// <summary>
  /// The multi dictionary is a dictionary that contains more than one value per key
  /// </summary>
  /// <typeparam name="T">The type of the key</typeparam>
  /// <typeparam name="TK">The type of the list contents</typeparam>
  public class MultiDictionary<T, TK> : Dictionary<T, List<TK>>
  {
    #region Private Methods
    //checks if the key is already present
    private void EnsureKey(T i_Key)
    {
      if (!ContainsKey(i_Key))
      {
        if (i_Key is string)
        {
          foreach (string val in this.Where(set => set.Key is string).Select(set => set.Key as string).Where(val => string.Compare(val, i_Key as string, StringComparison.CurrentCultureIgnoreCase) == 0))
          {
            // warn
            //mLogger.Warn("Warning - Registered same string different case {0},{1}", i_Key, val);
          }
        }

        this[i_Key] = new List<TK>(1);
      }
      else
      {
        if (this[i_Key] == null)
          this[i_Key] = new List<TK>(1);
      }
    }

    #endregion

    #region Public Methods
    /// <summary>
    /// Adds a new value in the Values collection
    /// </summary>
    /// <param name="i_Key">The key where to place the item in the value list</param>
    /// <param name="i_NewItem">The new item to add</param>
    public void AddValue(T i_Key, TK i_NewItem)
    {
      EnsureKey(i_Key);

      if (!this[i_Key].Contains(i_NewItem))
      {
        this[i_Key].Add(i_NewItem);
      }
      else
      {
        //mLogger.Warn("Register Ignored - Message {0} already contained a registration for method {1}", i_Key, i_NewItem);
      }
    }


    /// <summary>
    /// Adds a list of values to append to the value collection
    /// </summary>
    /// <param name="i_Key">The key where to place the item in the value list</param>
    /// <param name="i_NewItems">The new items to add</param>
    public void AddValues(T i_Key, IEnumerable<TK> i_NewItems)
    {
      EnsureKey(i_Key);
      this[i_Key].AddRange(i_NewItems);
    }

    /// <summary>
    /// Removes a specific element from the dict
    /// If the value list is empty the key is removed from the dict
    /// </summary>
    /// <param name="i_Key">The key from where to remove the value</param>
    /// <param name="i_Value">The value to remove</param>
    /// <returns>Returns false if the key was not found</returns>
    public bool RemoveValue(T i_Key, TK i_Value)
    {
      if (!ContainsKey(i_Key))
        return false;

      this[i_Key].Remove(i_Value);

      if (this[i_Key].Count == 0)
        Remove(i_Key);

      return true;
    }

    /// <summary>
    /// Removes all items that match the prediacte
    /// If the value list is empty the key is removed from the dict
    /// </summary>
    /// <param name="i_Key">The key from where to remove the value</param>
    /// <param name="i_Match">The predicate to match the items</param>
    /// <returns>Returns false if the key was not found</returns>
    public bool RemoveAllValue(T i_Key, Predicate<TK> i_Match)
    {
      if (!ContainsKey(i_Key))
        return false;
#if WPF
            this[i_Key].RemoveAll(i_Match);
#endif
      if (this[i_Key].Count == 0)
        Remove(i_Key);

      return true;
    }
    #endregion
  }
}
