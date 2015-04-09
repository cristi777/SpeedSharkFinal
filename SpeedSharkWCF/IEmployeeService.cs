using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SpeedSharkServer.Model;

namespace SpeedSharkWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeService" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        void insertEmployee(string fName, string lName, string username, string password);

        [OperationContract]
        Employee getEmployee(string username);

        [OperationContract]
        void UpdateEmployee(string fName, string lName, string username, string password);

        [OperationContract]
        List<Employee> getEmployees();

    }

    [DataContract]
    public class Employee
    {
        private string fName;
        private string lName;
        private string username;
        private string password;

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
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        [DataMemberAttribute]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }

}
