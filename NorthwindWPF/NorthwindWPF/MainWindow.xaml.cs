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

namespace NorthwindWPF
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

        private void emp_Click(object sender, RoutedEventArgs e)
        {
            if (!Application.Current.Windows.OfType<employeeList>().Any())
            {
                employeeList l = new employeeList();
                l.Show();
            }
        }

        private void cus_Click(object sender, RoutedEventArgs e)
        {
            if (!Application.Current.Windows.OfType<employeeList>().Any())
            {
            }
        }

        private void pro_Click(object sender, RoutedEventArgs e)
        {
            if (!Application.Current.Windows.OfType<employeeList>().Any())
            {
            }
        }

        private void sup_Click(object sender, RoutedEventArgs e)
        {
            if (!Application.Current.Windows.OfType<employeeList>().Any())
            {
            }
        }

        private void shi_Click(object sender, RoutedEventArgs e)
        {
            if (!Application.Current.Windows.OfType<employeeList>().Any())
            {
            }
        }

        private void ord_Click(object sender, RoutedEventArgs e)
        {
            if (!Application.Current.Windows.OfType<employeeList>().Any())
            {
            }
        }
    }
}
