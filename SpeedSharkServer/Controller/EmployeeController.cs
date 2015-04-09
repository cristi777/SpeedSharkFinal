using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeedSharkServer.Model;
using SpeedSharkServer.DBHandler;

namespace SpeedSharkServer.Controller
{
    public class EmployeeController
    {
        private static EmployeeController instance;

        private EmployeeController() { }

        public static EmployeeController EmployeeControllerInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmployeeController();
                }
                return instance;
            }
        }

        public void insertEmployee(string fName, string lName, string username, string password, string type)
        {
            EmployeeHandler.CreateEmployee(fName, lName, username, password, type);
        }

        public Employee getEmployee(string username)
        {
            return EmployeeHandler.GetEmployee(username);
        }

        public void UpdateEmployee(string fName, string lName, string username, string password, string type)
        {
            EmployeeHandler.UpdateEmployee(fName, lName, username, password, type);
        }

        public List<Employee> getEmployees()
        {
            return EmployeeHandler.GetEmployees();
        }

        public string employeeLogin(string username, string password)
        {
            return EmployeeHandler.EmployeeLogin(username, password);
        }
    }
}
