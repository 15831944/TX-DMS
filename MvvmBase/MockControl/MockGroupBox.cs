using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvvmBase.Mediator;

namespace MvvmBase.MockControl
{
  public class MockGroupBox
  {
    public string Name { get; set; }
    private string _Content;

    public string Content
    {
      get { return _Content; }
      set
      {
        _Content = value;
        Mediator.Mediator.Instance.NotifyColleagues(GroupBoxMessages.OnContentChanged, this);
      }
    }

    private bool _Visible;

    public bool Visible
    {
      get { return _Visible; }
      set
      {
        _Visible = value;
        //Mediator.Mediator.Instance.NotifyColleagues(GroupBoxMessages.OnVisibilityChanged, this);
      }
    }
  }
}
