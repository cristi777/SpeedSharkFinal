using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text;

namespace SpeedSharkWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICustomerService" in both code and config file together.
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        void insertCustomer(string cvr, string fName, string lName, string city, string address,
            string phoneNo, string email);

        [OperationContract]
        Customer getCustomer(string cvr);

        [OperationContract]
        void updateCustomer(string cvr, string fName, string lName, string city, string address,
            string phoneNo, string email);

        [OperationContract]
        List<Customer> getCustomers();
    }

    [DataContract]
    public class Customer
    {
        private string cvr;
        private string fName;
        private string lName;
        private string city;
        private string address;
        private string phoneNo;
        private string email;

        [DataMemberAttribute]
        public string Cvr
        {
            get { return cvr; }
            set { cvr = value; }
        }

        [DataMemberAttribute]
        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }

        [DataMemberAttribute]
        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }

        [DataMemberAttribute]
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        [DataMemberAttribute]
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        [DataMemberAttribute]
        public string PhoneNo
        {
            get { return phoneNo; }
            set { phoneNo = value; }
        }

        [DataMemberAttribute]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
