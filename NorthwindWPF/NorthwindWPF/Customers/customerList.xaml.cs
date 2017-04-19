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

namespace NorthwindWPF
{
    /// <summary>
    /// Interaction logic for customerList.xaml
    /// </summary>
    public partial class customerList : Window
    {

        NorthwindEntities db = new NorthwindEntities();

        public customerList()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var list = db.Customers;
            list.Load();
            licus.ItemsSource = list.Local.OrderBy(l => l.CompanyName);
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Customer c = new Customer();
            c.CompanyName = "NEW";
            db.Customers.Add(c);
            Window_Loaded(sender, e);
            licus.Items.Refresh();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception e1)
            {

                Console.WriteLine(e1.Source);
            }
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (licus.SelectedItem != null)
                {
                    var eml = (Customer)licus.SelectedItem;

                    db.Customers.Remove(eml);

                    licus.Items.Refresh();
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
