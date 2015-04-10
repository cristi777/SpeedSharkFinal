using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpeedSharkWeb.Views.Manager
{
    public partial class Employee : System.Web.UI.Page
    {
        private static EmployeeServiceReference.IEmployeeService employeeService = new EmployeeServiceReference.EmployeeServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RepeaterDataBinding();
            }
        }

        protected void EmployeeRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName.ToString())
            {
                case "updateEmployee":
                    String username = Convert.ToString(e.CommandArgument);
                    Session["username"] = username;
                    Response.Redirect("~/Views/Manager/UpdateEmployee.aspx");
                    break;
                default:
                    break;
            }
        }

        protected void createButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Manager/AddEmployee.aspx");
        }

        public void RepeaterDataBinding()
        {
            EmployeeServiceReference.Employee[] employees = employeeService.getEmployees();

            try
            {
                this.EmployeeRepeater.DataSource = employees;
                this.EmployeeRepeater.DataBind();
            }
            catch (NullReferenceException) { }
        }
    }
}