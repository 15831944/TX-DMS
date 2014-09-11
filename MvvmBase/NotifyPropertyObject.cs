using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MvvmBase
{
  public class NotifyPropertyObject : INotifyPropertyChanged
  {
    #region NotifyPropertyChange

    protected void OnPropertyChanged(string i_Name)
    {
      PropertyChangedEventHandler handler = PropertyChanged;
      if (handler != null)
      {
        handler(this, new PropertyChangedEventArgs(i_Name));
      }
    }

    /// <summary>
    /// Provides access to the PropertyChanged event handler to derived classes.
    /// </summary>
    protected PropertyChangedEventHandler PropertyChangedHandler
    {
      get { return PropertyChanged; }
    }

    /// <summary>
    /// Raises the PropertyChanged event if needed.
    /// </summary>
    /// <remarks>If the propertyName parameter
    /// does not correspond to an existing property on the current class, an
    /// exception is thrown in DEBUG configuration only.</remarks>
    /// <param name="i_PropertyName">The name of the property that
    /// changed.</param>
    [SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate",
      Justification = "This cannot be an event")]
    protected virtual void RaisePropertyChanged(string i_PropertyName)
    {
      var handler = PropertyChanged;

      if (handler != null)
      {
        handler(this, new PropertyChangedEventArgs(i_PropertyName));
      }
    }

    /// <summary>
    /// Raises the PropertyChanged event if needed.
    /// </summary>
    /// <typeparam name="T">The type of the property that
    /// changed.</typeparam>
    /// <param name="i_PropertyExpression">An expression identifying the property
    /// that changed.</param>
    [SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate",
      Justification = "This cannot be an event")]
    [SuppressMessage(
      "Microsoft.Design",
      "CA1006:GenericMethodsShouldProvideTypeParameter",
      Justification = "This syntax is more convenient than other alternatives.")]
    protected virtual void RaisePropertyChanged<T>(Expression<Func<T>> i_PropertyExpression)
    {
      if (i_PropertyExpression == null)
      {
        return;
      }

      var handler = PropertyChanged;

      if (handler != null)
      {
        var body = i_PropertyExpression.Body as MemberExpression;
        if (body != null)
        {
          var expression = body.Expression as ConstantExpression;
          if (expression != null) handler(expression.Value, new PropertyChangedEventArgs(body.Member.Name));
        }
      }
    }



    public virtual event PropertyChangedEventHandler PropertyChanged;

    #endregion
  }
}
