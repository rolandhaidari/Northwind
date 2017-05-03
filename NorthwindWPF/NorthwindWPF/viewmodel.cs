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
       
        public List<string> Alltits
        {
            get { return AllEmp.Select(e => e.Title).Distinct().ToList(); } 
        }

        public List<string> AllTcs
        {
            get { return AllEmp.Select(e => e.TitleOfCourtesy).Distinct().ToList(); }
        }

        public List<string> AllCts
        {
            get { return AllEmp.Select(e => e.City).Distinct().ToList(); }
        }

        public List<string> AllRgn
        {
            get { return AllEmp.Select(e => e.Region).Distinct().ToList(); }
        }

        public List<string> AllPsc
        {
            get { return AllEmp.Select(e => e.PostalCode).Distinct().ToList(); }
        }

        public List<string> AllCtr
        {
            get { return AllEmp.Select(e => e.Country).Distinct().ToList(); }
        }

        public List<string> AllCont
        {
            get { return AllCus.Select(e => e.ContactTitle).Distinct().ToList(); }
        }

        public List<string> AllEcit
        {
            get { return AllCus.Select(e => e.City).Distinct().ToList(); }
        }

        public List<string> AllEreg
        {
            get { return AllCus.Select(e => e.Region).Distinct().ToList(); }
        }

        public List<string> AllEpos
        {
            get { return AllCus.Select(e => e.PostalCode).Distinct().ToList(); }
        }

        public List<string> AllEcon
        {
            get { return AllCus.Select(e => e.Country).Distinct().ToList(); }
        }

        public List<string> AllCt
        {
            get { return AllSup.Select(e => e.ContactTitle).Distinct().ToList(); }
        }

        public List<string> AllSct
        {
            get { return AllSup.Select(e => e.City).Distinct().ToList(); }
        }

        public List<string> AllSReg
        {
            get { return AllSup.Select(e => e.Region).Distinct().ToList(); }
        }

        public List<string> AllSps
        {
            get { return AllSup.Select(e => e.PostalCode).Distinct().ToList(); }
        }

        public List<string> AllSCtry
        {
            get { return AllSup.Select(e => e.Country).Distinct().ToList(); }
        }

        public List<string> AllScty
        {
            get { return AllOrd.Select(e => e.ShipCity).Distinct().ToList(); }
        }

        public List<string> AllOsr
        {
            get { return AllOrd.Select(e => e.ShipRegion).Distinct().ToList(); }
        }

        public List<string> AllOhs
        {
            get { return AllOrd.Select(e => e.ShipPostalCode).Distinct().ToList(); }
        }

        public List<string> AllOctry
        {
            get { return AllOrd.Select(e => e.ShipCountry).Distinct().ToList(); }
        }

        public List<Category> AllCat
        {
            get { return db.Categories.ToList(); }
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
