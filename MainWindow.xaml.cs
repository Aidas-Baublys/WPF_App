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

namespace WPF_App
{
    public class Match
    {
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Completion { get; set; }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Match> matches = new List<Match>();
            matches.Add(new Match() { Team1 = "Duchai", Team2 = "Pydarai", Score1 = 4, Score2 = 4, Completion = 85 });
            matches.Add(new Match() { Team1 = "Pizdos", Team2 = "Sukos", Score1 = 0, Score2 = 2, Completion = 15 });
            matches.Add(new Match() { Team1 = "Kiausai", Team2 = "Bybiai", Score1 = 6, Score2 = 10, Completion = 50 });
            matches.Add(new Match() { Team1 = "Lochai", Team2 = "Daunai", Score1 = 2, Score2 = 4, Completion = 3 });
            matches.Add(new Match() { Team1 = "Pedikai", Team2 = "Kurwos", Score1 = 1, Score2 = 5, Completion = 98 });

            Matches.ItemsSource = matches;
        }

        private void Show_me(object sender, RoutedEventArgs e)
        {
            if (Matches.SelectedItem != null)
            {
                MessageBox.Show("Here you go: " +
                    $"{(Matches.SelectedItem as Match).Team1} {(Matches.SelectedItem as Match).Score1}" +
                    $" : {(Matches.SelectedItem as Match).Score2} {(Matches.SelectedItem as Match).Team2}",
                    "Selected match");
            }
        }
    }
}
