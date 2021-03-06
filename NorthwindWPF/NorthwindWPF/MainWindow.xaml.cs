﻿using System;
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
            if (!Application.Current.Windows.OfType<customerList>().Any())
            {
                customerList c = new customerList();
                c.Show();
            }
        }

        private void pro_Click(object sender, RoutedEventArgs e)
        {
            if (!Application.Current.Windows.OfType<Products.productList>().Any())
            {
                Products.productList p = new Products.productList();
                p.Show();
            }
        }

        private void sup_Click(object sender, RoutedEventArgs e)
        {
            if (!Application.Current.Windows.OfType<Suppliers.supList>().Any())
            {
                Suppliers.supList s = new Suppliers.supList();
                s.Show();
            }
        }

        private void shi_Click(object sender, RoutedEventArgs e)
        {
            if (!Application.Current.Windows.OfType<Shippers.shipperList>().Any())
            {
                Shippers.shipperList s = new Shippers.shipperList();
                s.Show();
            }
        }

        private void ord_Click(object sender, RoutedEventArgs e)
        {
            if (!Application.Current.Windows.OfType<Orders.orderList>().Any())
            {
                Orders.orderList o = new Orders.orderList();
                o.Show();
            }
        }

        private void overview_Click(object sender, RoutedEventArgs e)
        {
            Overview o = new Overview();
            o.Show();
        }
    }
}
