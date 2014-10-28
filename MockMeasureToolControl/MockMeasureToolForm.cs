using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using Mediator;

namespace MockMeasureToolControl
{
  public partial class MockMeasureToolForm : Form
  {
    public MockMeasureToolForm()
    {
      InitializeComponent();
    }

    private void MockMeasureToolForm_Scroll(object sender, ScrollEventArgs e)
    {
     
    }

    private void trackBar1_Scroll(object sender, EventArgs e)
    {
      var data = trackBar2.Value + (trackBar1.Value/100.0f);
      textBox1.Text = data.ToString("0.00");
      Mediator.Mediator.Instance.NotifyColleaguesAsync(MeasurementTool.OnDataArrived, data);
    }

    private void button1_Click(object sender, EventArgs e)
    {
         st = new SplitterTest();
        st.Show(this);
    }

      private SplitterTest st;
    private void button1_Click_1(object sender, EventArgs e)
    {
        if(st!=null)
            st.ToggleLeftPanel();
    }
  }
}
