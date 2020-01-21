using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CheckBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void allCheckedChanged(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbAllLang.IsChecked == true);
            cbCSharp.IsChecked = newVal;
            cbPython.IsChecked = newVal;
            cbJava.IsChecked = newVal;
            cbJavascript.IsChecked = newVal;
        }

        private void singleCheckedChanged(object sender, RoutedEventArgs e)
        {
            cbAllLang.IsChecked = null;
            if ((cbCSharp.IsChecked == true) && (cbPython.IsChecked == true) && (cbJava.IsChecked == true))
            {
                cbAllLang.IsChecked = true;
            }
            if ((cbCSharp.IsChecked == false) && (cbPython.IsChecked == false) && (cbJava.IsChecked == false))
            {
                cbAllLang.IsChecked = false;
            }
        }
    }
}
