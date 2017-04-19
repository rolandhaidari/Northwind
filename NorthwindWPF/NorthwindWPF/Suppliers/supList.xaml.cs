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

namespace NorthwindWPF.Suppliers
{
    /// <summary>
    /// Interaction logic for supList.xaml
    /// </summary>
    public partial class supList : Window
    {

        NorthwindEntities db = new NorthwindEntities();

        public supList()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var list = db.Suppliers;
            list.Load();
            lisup.ItemsSource = list.Local.OrderBy(l => l.SupplierID);
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Supplier s = new Supplier();
            db.Suppliers.Add(s);
            Window_Loaded(sender, e);
            lisup.Items.Refresh();
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
                if (lisup.SelectedItem != null)
                {
                    var eml = (Supplier)lisup.SelectedItem;

                    db.Suppliers.Remove(eml);

                    lisup.Items.Refresh();
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
