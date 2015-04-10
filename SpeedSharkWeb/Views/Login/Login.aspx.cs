using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpeedSharkWeb.Views.Login
{
    public partial class Login1 : System.Web.UI.Page
    {
        private static EmployeeServiceReference.IEmployeeService employeeService = new EmployeeServiceReference.EmployeeServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string givenUsername = Convert.ToString(this.usernameTxt.Text);
            string givenPassword = Convert.ToString(this.passwordTxt.Text);

            string result = employeeService.employeeLogin(givenUsername, givenPassword);

            switch(result)
            {
                case "Fail":
                    {
                        Response.Redirect("~/Views/Login/Error.aspx");
                        break;
                    }
                case "Manager":
                    {
                        Response.Redirect("~/Views/Manager/Home.aspx");
                        break;
                    }
                case "Driver":
                    {
                        Response.Redirect("");
                        break;
                    }
                default:
                    {
                        Response.Redirect("~/Views/Login/Error.aspx");
                        break;
                    }
            }
        }

        
    }
}