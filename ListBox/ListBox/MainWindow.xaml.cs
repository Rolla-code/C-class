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

namespace ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Match> matches = new List<Match>();
            matches.Add(new Match() { Team1 = "Hearts of Oak", Team2 = "Asante Kotoko", Score1 = 1, Score2 = 1, Completion = 65});
            matches.Add(new Match() { Team1 = "Legon Cities FC", Team2 = "WAFA", Score1 = 3, Score2 = 1, Completion = 90 });
            matches.Add(new Match() { Team1 = "Olympics", Team2 = "Karela", Score1 = 2, Score2 = 0, Completion = 75 });
            matches.Add(new Match() { Team1 = "Inter allies", Team2 = "Dreams FC", Score1 = 0, Score2 = 1, Completion = 89 });
            matches.Add(new Match() { Team1 = "Berekum Chelsea", Team2 = "Ashanti Gold", Score1 = 0, Score2 = 0, Completion = 45 });
            lblMatches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lblMatches.SelectedItem != null)
            {
                MessageBox.Show("Selected Match: "
                    + (lblMatches.SelectedItem as Match).Team1 + " " +
                    (lblMatches.SelectedItem as Match).Score1 + " : " +
                    (lblMatches.SelectedItem as Match).Score2 + " " +
                    (lblMatches.SelectedItem as Match).Team2);

            }
        }
    }
    
}
