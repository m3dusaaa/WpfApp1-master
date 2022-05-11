using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using WpfApp1.Add;

namespace WpfApp1
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


        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            ViewClient V = new ViewClient();
            V.Show();
        }

        private void ButtonClick2(object sender, RoutedEventArgs e)
        {
             AddClient M = new AddClient();
                M.Show();
            
        }
        private void ButtonClick3(object sender, RoutedEventArgs e)
        {
            ViewOperator N = new ViewOperator();
            N.Show();

        }
        private void ButtonClick4(object sender, RoutedEventArgs e)
        {
            AddOperator Q = new AddOperator();
            Q.Show();

        }
        private void ButtonClick5(object sender, RoutedEventArgs e)
        {
            ViewTour Z = new ViewTour();
            Z.Show();

        }
        private void ButtonClick6(object sender, RoutedEventArgs e)
        {
            AddTour X = new AddTour();
            X.Show();

        }
        private void ButtonClick7(object sender, RoutedEventArgs e)
        {
            ViewOplata G = new ViewOplata();
            G.Show();

        }
        private void ButtonClick8(object sender, RoutedEventArgs e)
        {
            AddOplata L = new AddOplata();
            L.Show();

        }
    }
}
