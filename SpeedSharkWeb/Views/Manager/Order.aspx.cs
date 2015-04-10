using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

namespace SpeedSharkWeb.Views.Manager
{
    public partial class Order : System.Web.UI.Page
    {
        private static SessionServiceReference.ISessionService sessionService = new SessionServiceReference.SessionServiceClient();
        private static TruckServiceReference.ITruckService truckService = new TruckServiceReference.TruckServiceClient();
        private static OrderServiceReference.IOrderService orderService = new OrderServiceReference.OrderServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropBoxDataBinding();
            }
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            double cargoWeight = Convert.ToDouble(weightTxt.Text);

            int truckNumber = Convert.ToInt32(this.AvailableTrucksDropDown.SelectedValue);

            string cvr = Convert.ToString(this.cvrTxt.Text);
            double price = Convert.ToDouble(this.priceTxt.Text);
            string status = "Created";

            string destinationCity = Convert.ToString(this.destCityTxt.Text);
            string destinationAddress = Convert.ToString(this.destAddressTxt.Text);
            string departureTime = Convert.ToString(this.depTimeTxt.Text);
            string arrivalTime = Convert.ToString(this.arrTimeTxt.Text);

            //cargo insert here

            //get max cargo id
            Thread.Sleep(1000);
            int maxCargoId = 0;

            
            sessionService.insertSession(maxCargoId, departureTime, arrivalTime, truckNumber, destinationAddress, destinationCity);
            Thread.Sleep(1000);
            int maxSessionId = sessionService.getMaxId();

            orderService.insertOrder(cvr, price, maxSessionId, maxCargoId, status);

            Response.Redirect("~/Views/Manager/Order.aspx");



        }

        public void DropBoxDataBinding()
        {
            int[] availableTrucks = truckService.getAvailableTrucks();
            int[] functionalTrucks = truckService.getFunctionalTrucks();

            if(availableTrucks.Count() !=0)
            {
                this.AvailableTrucksDropDown.DataSource = availableTrucks;
                this.AvailableTrucksDropDown.DataBind();
            }
            else
            {
                this.AvailableTrucksDropDown.DataSource = functionalTrucks;
                this.AvailableTrucksDropDown.DataBind();
            }
            
        }        
    }
}