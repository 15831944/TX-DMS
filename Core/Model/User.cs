using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model
{
  public class User
  {
    public int Id { get; set; }
    public UserGroup Group { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
  }
  public class UserGroup
  {
    public int Id { get; set; }
    public string Name { get; set; }
  }
}
