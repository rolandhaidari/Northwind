using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Shapes;

namespace NorthwindWPF.Orders
{
    /// <summary>
    /// Interaction logic for orderList.xaml
    /// </summary>
    public partial class orderList : Window
    {

        NorthwindEntities db = new NorthwindEntities();

        public orderList()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var list = db.Orders;
            list.Load();
            liord.ItemsSource = list.Local.OrderBy(l => l.OrderID);
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (!Application.Current.Windows.OfType<employeeSubEdit>().Any())
            {
                orderSubEdit ed = new orderSubEdit();
                ed.Show();
            }
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (liord.SelectedItem != null)
                {
                    var eml = (Order)liord.SelectedItem;

                    db.Orders.Remove(eml);

                    liord.Items.Refresh();
                    Window_Loaded(sender, e);
                }
            }
            catch (Exception e1)
            {

                Console.WriteLine(e1.Source);
            }
        }
    }
}
