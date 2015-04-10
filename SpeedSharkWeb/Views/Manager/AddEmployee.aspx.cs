using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SpeedSharkWeb.EmployeeServiceReference;

namespace SpeedSharkWeb.Views.Manager
{
    public partial class AddEmployee : System.Web.UI.Page
    {
        private static EmployeeServiceReference.IEmployeeService employeeService = new EmployeeServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddEmployee_OnClick(object sender, EventArgs e)
        {
            string fName = Convert.ToString(txtFirstName.Text);
            string lName = Convert.ToString(txtLastName.Text);
            string username = Convert.ToString(txtUsername.Text);
            string password = Convert.ToString(txtPassword.Text);
            string type = Convert.ToString(txtType.Text);
            
            employeeService.insertEmployee(fName, lName, username, password, type);
            Response.Redirect("~/Views/Manager/Employee.aspx");
        }
    }
}