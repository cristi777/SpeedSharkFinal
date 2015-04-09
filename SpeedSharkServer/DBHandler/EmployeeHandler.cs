using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeedSharkServer.Model;

namespace SpeedSharkServer.DBHandler
{
    public static class EmployeeHandler
    {
        //create employee
        public static void CreateEmployee(string fName, string lName, string username, string password, string type)
        {
            using (var db = new SpeedSharkModelDataContext())
            {
                var emp = new Employee();
                emp.fName = fName;
                emp.lName = lName;
                emp.username = username;
                emp.password = password;
                emp.type = type;
                db.Employees.InsertOnSubmit(emp);

                db.SubmitChanges();
            }
        }

        //update employee
        public static void UpdateEmployee(string fName, string lName, string username, string password, string type)
        {
            var employee = new Employee();
            using (var db = new SpeedSharkModelDataContext())
            {
                employee = db.Employees.SingleOrDefault(emp => emp.username == username);

                if (employee != null)
                {
                    employee.fName = fName;
                    employee.lName = lName;
                    employee.username = username;
                    employee.password = password;
                    employee.type = type;

                    db.SubmitChanges();
                }
            }
        }
        
        //get an employee
        public static Employee GetEmployee(string username)
        {
            var employee = new Employee();
            using (var db = new SpeedSharkModelDataContext())
            {
                var query = db.Employees.SingleOrDefault(emp => emp.username == username);
                employee = query;
            }
            return employee;
        }
        
        //get all employees
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            using (var db = new SpeedSharkModelDataContext())
            {
                var query = db.Employees.ToList();
                employees = query;
            }

            return employees;
        }

        //login
        public static string EmployeeLogin(string username, string password)
        {
            var employee = new Employee();
            string employeeType = "";

            using(var db = new SpeedSharkModelDataContext())
            {
                employee = db.Employees.SingleOrDefault(emp => emp.username == username && emp.password == password);

                if(employee == null)
                {
                    employeeType = "Fail";
                }
                else
                {
                    employeeType = employee.type;
                }
            }

            return employeeType;
        }
    }
}
