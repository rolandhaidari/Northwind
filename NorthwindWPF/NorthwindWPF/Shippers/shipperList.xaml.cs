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

namespace NorthwindWPF.Shippers
{
    /// <summary>
    /// Interaction logic for shipperList.xaml
    /// </summary>
    public partial class shipperList : Window
    {

        NorthwindEntities db = new NorthwindEntities();

        public shipperList()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var list = db.Shippers;
            list.Load();
            lishi.ItemsSource = list.Local.OrderBy(l => l.ShipperID);
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (!Application.Current.Windows.OfType<employeeSubEdit>().Any())
            {
                shipperSubEdit ed = new shipperSubEdit();
                ed.Show();
            }
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lishi.SelectedItem != null)
                {
                    var eml = (Shipper)lishi.SelectedItem;

                    db.Shippers.Remove(eml);

                    lishi.Items.Refresh();
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
