using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindWPF.context
{
    class viewmodel
    {

        NorthwindEntities db = new NorthwindEntities();

        public List<Employee> AllEmp {
            get { return db.Employees.ToList(); }
        }

        public List<Customer> AllCus
        {
            get { return db.Customers.ToList(); }
        }

        public List<Product> AllPro
        {
            get { return db.Products.ToList(); }
        }

        public List<Supplier> AllSup
        {
            get { return db.Suppliers.ToList(); }
        }

        public List<Shipper> AllShi
        {
            get { return db.Shippers.ToList(); }
        }

        public List<Order> AllOrd
        {
            get { return db.Orders.ToList(); }
        }
    }
}
