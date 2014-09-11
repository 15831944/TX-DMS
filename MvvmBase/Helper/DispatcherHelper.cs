using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;

namespace MvvmBase.Helper
{
  /// <summary>
  /// Helper class for dispatcher operations on the UI thread.
  /// </summary>
  //// [ClassInfo(typeof(DispatcherHelper),
  ////  VersionString = "4.0.0.0/BL0002",
  ////  DateString = "201109042117",
  ////  Description = "Helper class for dispatcher operations on the UI thread.",
  ////  UrlContacts = "http://www.galasoft.ch/contact_en.html",
  ////  Email = "laurent@galasoft.ch")]
  public static class DispatcherHelper
  {
    /// <summary>
    /// Gets a reference to the UI thread's dispatcher, after the
    /// <see cref="Initialize" /> method has been called on the UI thread.
    /// </summary>
    public static Dispatcher UIDispatcher { get; private set; }

    /// <summary>
    /// Executes an action on the UI thread. If this method is called
    /// from the UI thread, the action is executed immendiately. If the
    /// method is called from another thread, the action will be enqueued
    /// on the UI thread's dispatcher and executed asynchronously.
    /// <para>For additional operations on the UI thread, you can get a
    /// reference to the UI thread's dispatcher thanks to the property
    /// <see cref="UIDispatcher" /></para>.
    /// </summary>
    /// <param name="action">The action that will be executed on the UI
    /// thread.</param>
    public static void CheckBeginInvokeOnUI(Action action)
    {
      if (UIDispatcher.CheckAccess())
      {
        action();
      }
      else
      {
        UIDispatcher.BeginInvoke(action);
      }
    }

    //UXP-169 (UXP-181) Alberto 26-June-2012
    /// <summary>
    /// Executes an action on the UI thread. If this method is called
    /// from the UI thread, the action is executed immendiately. If the
    /// method is called from another thread, the action will be enqueued
    /// on the UI thread's dispatcher and executed synchronously.
    /// <para>For additional operations on the UI thread, you can get a
    /// reference to the UI thread's dispatcher thanks to the property
    /// <see cref="UIDispatcher" /></para>.
    /// </summary>
    /// <param name="action">The action that will be executed on the UI
    /// thread.</param>
    public static void CheckInvokeOnUI(Action action)
    {
      if (UIDispatcher.CheckAccess())
      {
        action();
      }
      else
      {
        UIDispatcher.Invoke(action, DispatcherPriority.Send);
      }
    }

    /// <summary>
    /// This method should be called once on the UI thread to ensure that
    /// the <see cref="UIDispatcher" /> property is initialized.
    /// <para>In a Silverlight application, call this method in the
    /// Application_Startup event handler, after the MainPage is constructed.</para>
    /// <para>In WPF, call this method on the static App() constructor.</para>
    /// </summary>
    public static void Initialize()
    {
      if (UIDispatcher != null)
      {
        return;
      }

#if SILVERLIGHT
      UIDispatcher = Deployment.Current.Dispatcher;
#else
      UIDispatcher = Dispatcher.CurrentDispatcher;
#endif
    }
  }
}
