using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MvvmBase
{
  public class RelayCommand<T> : ICommand
  {
    private readonly Action<T> _Execute;

    private readonly Func<T, bool> _CanExecute;

    /// <summary>
    /// Initializes a new instance of the RelayCommand class that 
    /// can always execute.
    /// </summary>
    /// <param name="i_Execute">The execution logic.</param>
    /// <exception cref="ArgumentNullException">If the execute argument is null.</exception>
    public RelayCommand(Action<T> i_Execute)
      : this(i_Execute, null)
    {
    }

    /// <summary>
    /// Initializes a new instance of the RelayCommand class.
    /// </summary>
    /// <param name="i_Execute">The execution logic.</param>
    /// <param name="i_CanExecute">The execution status logic.</param>
    /// <exception cref="ArgumentNullException">If the execute argument is null.</exception>
    public RelayCommand(Action<T> i_Execute, Func<T, bool> i_CanExecute)
    {
      if (i_Execute == null)
      {
        throw new ArgumentNullException("i_Execute");
      }

      _Execute = i_Execute;
      _CanExecute = i_CanExecute;
    }

    /// <summary>
    /// Occurs when changes occur that affect whether the command should execute.
    /// </summary>
    public event EventHandler CanExecuteChanged;

    /// <summary>
    /// Raises the <see cref="CanExecuteChanged" /> event.
    /// </summary>
    [SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate",
        Justification = "This cannot be an event")]
    public void RaiseCanExecuteChanged()
    {
      var handler = CanExecuteChanged;
      if (handler != null)
      {
        handler(this, EventArgs.Empty);
      }
    }

    /// <summary>
    /// Defines the method that determines whether the command can execute in its current state.
    /// </summary>
    /// <param name="i_Parameter">Data used by the command. If the command does not require data 
    /// to be passed, this object can be set to a null reference</param>
    /// <returns>true if this command can be executed; otherwise, false.</returns>
    public bool CanExecute(object i_Parameter)
    {
      return _CanExecute == null || _CanExecute((T)i_Parameter);
    }

    /// <summary>
    /// Defines the method to be called when the command is invoked. 
    /// </summary>
    /// <param name="i_Parameter">Data used by the command. If the command does not require data 
    /// to be passed, this object can be set to a null reference</param>
    public void Execute(object i_Parameter)
    {
      if (CanExecute(i_Parameter))
      {
        _Execute((T)i_Parameter);
      }
    }
  }
}
