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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Topings_Checked(object sender, RoutedEventArgs e)
        {
            bool newVal = (Topings.IsChecked == true);
            Salami.IsChecked = newVal;
            Mushrooms.IsChecked = newVal;
            Mozzarella.IsChecked = newVal;
        }

        private void One_Toping_Checked(object sender, RoutedEventArgs e)
        {
            Topings.IsChecked = null;

            if (Salami.IsChecked == true && Mushrooms.IsChecked == true && Mozzarella.IsChecked == true)
            {
                Topings.IsChecked = true;
            }

            if (Salami.IsChecked == false && Mushrooms.IsChecked == false && Mozzarella.IsChecked == false)
            {
                Topings.IsChecked = false;
            }
        }
    }
}
