using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeedSharkServer.Model;
using SpeedSharkServer.DBHandler;

namespace SpeedSharkServer.Controller
{
    public class CustomerController
    {
        //Singleton - all controllers
        private static CustomerController instance;

        private CustomerController() {}

        public static CustomerController CustomerControllerInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerController();
                }
                return instance;
            }
        }

        public void insertCustomer(string cvr, string fName, string lName, string city, string address,
            string phoneNo, string email)
        {
            CustomerHandler.CreateCustomer(cvr, fName, lName, city, address, phoneNo, email);
        }

        public Customer getCustomer(string cvr)
        {
            return CustomerHandler.GetCustomer(cvr);
        }

        public void updateCustomer(string cvr, string fName, string lName, string city, string address,
            string phoneNo, string email)
        {
            CustomerHandler.UpdateCustomer(cvr, fName, lName, city, address, phoneNo, email);
        }

        public List<Customer> getCustomers()
        {
            return CustomerHandler.GetCustomers();
        }
    }
}
