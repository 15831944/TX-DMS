using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ControlCad;

namespace DMS
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private CadForm _CadForm;
    public MainWindow()
    {
      _CadForm = new CadForm();
      InitializeComponent();
      CadHost.Child = _CadForm;
      this.Closing += MainWindow_Closing;
      CadHost.MouseWheel += MainWindow_MouseWheel;
    }

    void MainWindow_MouseWheel(object sender, MouseWheelEventArgs e)
    {
      _CadForm.Form1_MouseWheel(sender,new System.Windows.Forms. MouseEventArgs(MouseButtons.Middle, 0,(int)e.GetPosition(this).X,(int)e.GetPosition(this).Y,e.Delta));

    }

    void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
    {
      _CadForm.Form1_FormClosing(null,null);
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      FileDialog fd = new OpenFileDialog();
      fd.ShowDialog();
      _CadForm.OpenDwgFile(fd.FileName);
    }
  }
}
