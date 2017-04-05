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

namespace NorthwindWPF.Products
{
    /// <summary>
    /// Interaction logic for productList.xaml
    /// </summary>
    public partial class productList : Window
    {

        NorthwindEntities db = new NorthwindEntities();

        public productList()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var list = db.Products;
            list.Load();
            lipro.ItemsSource = list.Local.OrderBy(l => l.ProductID);
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (!Application.Current.Windows.OfType<employeeSubEdit>().Any())
            {
                productSubEdit ed = new productSubEdit();
                ed.Show();
            }
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lipro.SelectedItem != null)
                {
                    var eml = (Product)lipro.SelectedItem;

                    db.Products.Remove(eml);

                    lipro.Items.Refresh();
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
