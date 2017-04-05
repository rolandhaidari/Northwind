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
    /// Interaction logic for employeeList.xaml
    /// </summary>
    public partial class employeeList : Window
    {

        NorthwindEntities db = new NorthwindEntities();

        public employeeList()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var list = db.Employees;
            list.Load();
            liemp.ItemsSource = list.Local.OrderBy(l => l.LastName);
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (!Application.Current.Windows.OfType<employeeSubEdit>().Any())
            {
                employeeSubEdit ed = new employeeSubEdit();
                ed.Show();
            }
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (liemp.SelectedItem != null)
                {
                    var eml = (Employee)liemp.SelectedItem;

                    db.Employees.Remove(eml);

                    liemp.Items.Refresh();
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
