using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Exception
{
  public class PmsUserNotFondException : System.Exception
  {
    public PmsUserNotFondException(string i_Username)
      : base(string.Format("{0}不存在", i_Username))
    {

    }
  }

  public class PmsIncorrectPasswordException : System.Exception
  {
    public PmsIncorrectPasswordException(string i_Username)
      : base(string.Format("{0}密码不正确", i_Username))
    {
    }
  }
}
