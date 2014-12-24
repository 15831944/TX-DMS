using System.Windows.Forms;
using Mediator;

namespace ControlCad
{
  public partial class CadParseProgressForm : Form
  {
   
    public CadParseProgressForm()
    {
      Register();
      InitializeComponent();

    }

    private void Register()
    {
      Mediator.Mediator.Instance.Register(Cad.Parsing, OnParsing);
    }

    private void OnParsing(object i_Obj)
    {
//      this.BeginInvoke(new MessageHanlderDelegate(i_O =>
//        {
//          var parseStatus = (CadParseStatus)i_O;
//          if (parseStatus == CadParseStatus.Started)
//          {
//            progressBar1.Value = 0;
//          }
//          else if (parseStatus == CadParseStatus.Finished)
//          {
//            //_CadParseProgressForm.Close();
//          }
//        }), i_Obj);
    }
  }
}
