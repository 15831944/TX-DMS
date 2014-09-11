using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvvmBase.MockControl
{
  public class MockTextBox
  {
    public string Name { get; set; }
    private string _Text;

    public string Text
    {
      get { return _Text; } 
      set
      {
        //if (_Text!=value)
        //{
          _Text = value;
          Mediator.Mediator.Instance.NotifyColleagues(Mediator.TextBoxMessages.OnTextChanged, this);
        //}
      }
    }

    private bool _Enabled;

    public bool Enabled
    {
      get { return _Enabled; }
      set
      {
        _Enabled = value;
        if (!_Enabled) return;  //Prevent textboc from disabled to show background correctly
        Mediator.Mediator.Instance.NotifyColleagues(Mediator.TextBoxMessages.OnEnableChanged, this);
      }
    }
  }
}
