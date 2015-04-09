using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.PeerResolvers;
using System.Text;
using SpeedSharkServer.Controller;

namespace SpeedSharkWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CustomerService" in both code and config file together.
    public class CustomerService : ICustomerService
    {
        private static CustomerController customerCtr = CustomerController.CustomerControllerInstance;

        private static readonly System.Object obj1 = new System.Object();
        private static readonly System.Object obj2 = new System.Object();
        private static readonly System.Object obj3 = new System.Object();
        private static readonly System.Object obj4 = new System.Object();

        public void insertCustomer(string cvr, string fName, string lName, string city, string address, string phoneNo, string email)
        {
            if (System.Threading.Monitor.TryEnter(obj1, 45000))
            {
                try
                {
                    customerCtr.insertCustomer(cvr, fName, lName, city, address, phoneNo, email);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj1);
                }
            }
        }

        public Customer getCustomer(string cvr)
        {
            Customer serviceCustomer = new Customer();

            if (System.Threading.Monitor.TryEnter(obj2, 45000))
            {
                try
                {
                    serviceCustomer.Cvr = customerCtr.getCustomer(cvr).CVR;
                    serviceCustomer.City = customerCtr.getCustomer(cvr).city;
                    serviceCustomer.Address = customerCtr.getCustomer(cvr).address;
                    serviceCustomer.Email = customerCtr.getCustomer(cvr).email;
                    serviceCustomer.FName = customerCtr.getCustomer(cvr).fName;
                    serviceCustomer.LName = customerCtr.getCustomer(cvr).lName;
                    serviceCustomer.PhoneNo = customerCtr.getCustomer(cvr).phoneNo;
                }
                catch (NullReferenceException)
                {
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj2);
                }
            }

            return serviceCustomer;
        }

        public void updateCustomer(string cvr, string fName, string lName, string city, string address, string phoneNo, string email)
        {
            if (System.Threading.Monitor.TryEnter(obj3, 45000))
            {
                try
                {
                    customerCtr.updateCustomer(cvr, fName, lName, city, address, phoneNo,email);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj3);
                }
            }
        }

        public List<Customer> getCustomers()
        {
            List<Customer> customers = new List<Customer>();

            if (System.Threading.Monitor.TryEnter(obj4, 45000))
            {
                try
                {
                    List<SpeedSharkServer.Model.Customer> returnList = new List<SpeedSharkServer.Model.Customer>();

                    if (returnList.Count != 0)
                    {
                        foreach (SpeedSharkServer.Model.Customer hostCustomer in returnList)
                        {
                            Customer serviceCustomer = new Customer();

                            serviceCustomer.Cvr = hostCustomer.CVR;
                            serviceCustomer.City = hostCustomer.city;
                            serviceCustomer.Address = hostCustomer.address;
                            serviceCustomer.Email = hostCustomer.email;
                            serviceCustomer.FName = hostCustomer.fName;
                            serviceCustomer.LName = hostCustomer.lName;
                            serviceCustomer.PhoneNo = hostCustomer.phoneNo;

                            customers.Add(serviceCustomer);
                        }
                    }
                }
                catch (NullReferenceException)
                {
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj4);
                }
            }

            return customers;
        }
    }
}
