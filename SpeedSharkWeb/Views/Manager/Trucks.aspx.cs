using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpeedSharkWeb.Views.Manager
{
    public partial class Trucks : System.Web.UI.Page
    {
        private static TruckServiceReference.ITruckService truckService = new TruckServiceReference.TruckServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RepeaterDataBinding();
            }
        }

        protected void TruckRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch(e.CommandName.ToString())
            {
                case "truckUpdate":
                    int truckId = Convert.ToInt32(e.CommandArgument);
                    Session["truckId"] = truckId;
                    Response.Redirect("~/Views/Manager/UpdateTruck.aspx");
                    break;
                default:
                    break;
            }
        }

        protected void createButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Manager/AddTruck.aspx");
        }

        public void RepeaterDataBinding()
        {
            TruckServiceReference.Truck[] trucks = truckService.getTrucks();

            try
            { 
                this.TruckRepeater.DataSource = trucks;
                this.TruckRepeater.DataBind();
            }
            catch(NullReferenceException){}            
        }
    }
}