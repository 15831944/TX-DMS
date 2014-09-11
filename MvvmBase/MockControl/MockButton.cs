using MvvmBase.Mediator;

namespace MvvmBase.MockControl
{
  public class MockButton
  {
    public string Name { get; set; }

    private bool _Enabled;

    public bool Enabled
    {
      get { return _Enabled; }
      set
      {
        _Enabled = value;
        Mediator.Mediator.Instance.NotifyColleagues(ButtonMessages.OnEnabledChanged, this);
      }
    }

    private string _Text;

    public string Text
    {
      get { return _Text; }
      set
      {
        _Text = value;
        Mediator.Mediator.Instance.NotifyColleagues(ButtonMessages.OnTextChanged, this);
      }
    }

    private object _Image;

    public object Image
    {
      get { return _Image; }
      set
      {
        _Image = value;
        Mediator.Mediator.Instance.NotifyColleagues(ButtonMessages.OnImageChanged, this);
      }
    }

    public void Focus()
    {
      Mediator.Mediator.Instance.NotifyColleagues(ButtonMessages.OnFocus, this);
    }
  }
}
