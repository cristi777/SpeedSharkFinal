using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SpeedSharkServer.Controller;



namespace SpeedSharkWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in both code and config file together.
    public class EmployeeService : IEmployeeService
    {
        private static EmployeeController employeeCtr = EmployeeController.EmployeeControllerInstance;

        private static readonly System.Object obj1 = new System.Object();
        private static readonly System.Object obj2 = new System.Object();
        private static readonly System.Object obj3 = new System.Object();
        private static readonly System.Object obj4 = new System.Object();

        public Employee getEmployee(string username)
        {
            Employee servicEmployee = new Employee();
            if (System.Threading.Monitor.TryEnter(obj2, 45000))
            {
                try
                {
                    servicEmployee.FName = employeeCtr.getEmployee(username).fName;
                    servicEmployee.LName = employeeCtr.getEmployee(username).lName;
                    servicEmployee.Username = employeeCtr.getEmployee(username).username;
                    servicEmployee.Password = employeeCtr.getEmployee(username).password;
                }
                catch (NullReferenceException)
                {


                }
                finally
                {
                    System.Threading.Monitor.Exit(obj2);
                }

            }
          
            return servicEmployee;
        }


        public void UpdateEmployee(string fName, string lName, string username, string password)
        {
            if (System.Threading.Monitor.TryEnter(obj3, 45000))
            {
                try
                {
                    employeeCtr.UpdateEmployee(fName, lName, username, password);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj3); 
                }
            }
        }

        public List<Employee> getEmployees()
        {
            List<Employee> employees = new List<Employee>();

            if (System.Threading.Monitor.TryEnter(obj4, 45000))
            {
                try
                {
                    List<SpeedSharkServer.Model.Employee> returnList = new List<SpeedSharkServer.Model.Employee>();

                    if (returnList.Count != 0)
                    {
                        foreach (SpeedSharkServer.Model.Employee hostEmployee in returnList)
                        {
                            Employee serviceEmployee = new Employee();

                            serviceEmployee.fName = hostEmployee.fName;
                            serviceEmployee.LName = hostEmployee.lName;
                            serviceEmployee.Username = hostEmployee.username;
                            serviceEmployee.Password = hostEmployee.password;
                            
                            employees.Add(serviceEmployee);
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

            return employees;
        }

        public void insertEmployee(string fName, string lName, string username, string password)
        {
            if (System.Threading.Monitor.TryEnter(obj1, 45000))
            {
                try
                {
                    employeeCtr.insertEmployee(fName, lName, username, password);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj1);
                }
            }
        }
    }
}
