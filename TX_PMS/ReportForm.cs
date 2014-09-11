using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace TxPms
{
  public partial class ReportForm : Form
  {
    private ResizeListener _ResizeListener;
    public ReportForm(ResizeListener i_ResizeListener, string i_Name)
    {
      _ResizeListener = i_ResizeListener;
      InitializeComponent();
      Name = i_Name;
      this.ControlBox = false;
      this.SizeChanged += new EventHandler(ReportForm_SizeChanged);
      //this.ResizeBegin += new EventHandler(ReportForm_ResizeBegin);
      //this.ResizeEnd += new EventHandler(ReportForm_ResizeEnd);
      this.Resize += new EventHandler(ReportForm_Resize);
    }

    void ReportForm_Resize(object sender, EventArgs e)
    {
      Debug.WriteLine("Resize" + string.Format(" ReportWindow: Left:{0}, Top:{1}, Right{2}, Bottom{3}", Left, Top, Right, Bottom));
      ResizeArgs args = new ResizeArgs() { Botton = Bottom, Left = Left, Right = Right, Top = Top, FormName = Name };
      _ResizeListener.OnResize(args);
    }

    void ReportForm_ResizeEnd(object sender, EventArgs e)
    {
      Debug.WriteLine("ResizeEnd" + string.Format(" ReportWindow: Left:{0}, Top:{1}, Right{2}, Bottom{3}", Left, Top, Right, Bottom));
    }

    void ReportForm_ResizeBegin(object sender, EventArgs e)
    {
      Debug.WriteLine("ResizeBegin" + string.Format(" ReportWindow: Left:{0}, Top:{1}, Right{2}, Bottom{3}", Left, Top, Right, Bottom));
    }

    void ReportForm_SizeChanged(object sender, EventArgs e)
    {
      Debug.WriteLine("SizeChanged" + string.Format(" ReportWindow: Left:{0}, Top:{1}, Right{2}, Bottom{3}", Left, Top, Right, Bottom));
      textBoxLeft.Text = Left.ToString(CultureInfo.InvariantCulture);
      textBoxRight.Text = Right.ToString(CultureInfo.InvariantCulture);
      textBoxBotton.Text = Bottom.ToString(CultureInfo.InvariantCulture);
      textBoxTop.Text = Top.ToString(CultureInfo.InvariantCulture);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Left++;
      Top++;
    }
  }
}
