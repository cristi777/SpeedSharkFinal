using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeedSharkServer.Model;

namespace SpeedSharkServer.DBHandler
{
    public static class CustomerHandler
    {
        //create customer
        public static void CreateCustomer(string cvr, string fName, string lName, string city, string address,
            string phoneNo,
            string email)
        {
            using (var db = new SpeedSharkModelDataContext())
            {
                var cust = new Customer();
                cust.CVR = cvr;
                cust.fName = fName;
                cust.lName = lName;
                cust.city = city;
                cust.address = address;
                cust.phoneNo = phoneNo;
                db.Customers.InsertOnSubmit(cust);

                db.SubmitChanges();
            }
        }

        //update customer
        public static void UpdateCustomer(string cvr, string fName, string lName, string city, string address,
            string phoneNo, string email)
        {
            var customer = new Customer();
            using (var db = new SpeedSharkModelDataContext())
            {
                customer = db.Customers.SingleOrDefault(cust => cust.CVR == cvr);

                if (customer != null)
                {
                    customer.fName = fName;
                    customer.lName = lName;
                    customer.city = city;
                    customer.address = address;
                    customer.phoneNo = phoneNo;
                    customer.email = email;

                    db.SubmitChanges();
                }
            }
        }

        //get a customer
        public static Customer GetCustomer(string cvr)
        {
            var customer = new Customer();
            using (var db = new SpeedSharkModelDataContext())
            {
                var query = db.Customers.SingleOrDefault(cust => cust.CVR == cvr);
                customer = query;
            }
            return customer;
        }

        //get all customers
        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            using (var db = new SpeedSharkModelDataContext())
            {
                var query = db.Customers.ToList();
                customers = query;
            }

            return customers;
        }
    }
}
