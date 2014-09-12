using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ControlReport
{
  public partial class UserControlReport : UserControl
  {
    public UserControlReport()
    {
      InitializeComponent();
      Load += new EventHandler(UserControlReport_Load);
    }

    void UserControlReport_Load(object sender, EventArgs e)
    {
      int i = dataGridView1.ColumnCount;
    }
  }
}
