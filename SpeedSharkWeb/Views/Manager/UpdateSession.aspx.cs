using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpeedSharkWeb.Views.Manager
{
    public partial class UpdateSession : System.Web.UI.Page
    {
        private int sessionId = 0;

        private static SessionServiceReference.ISessionService sessionService = new SessionServiceReference.SessionServiceClient();
        private static OrderServiceReference.IOrderService orderService = new OrderServiceReference.OrderServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            sessionId = Convert.ToInt32(Session["sessionId"]);
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            string destinationCity = Convert.ToString(this.destCityTxt.Text);
            string destinationAddress = Convert.ToString(this.destAddTxt.Text);
            string departureTime = Convert.ToString(this.depTimeTxt.Text);
            string arrivalTime = Convert.ToString(this.arrTimeTxt.Text);

            SessionServiceReference.Session session = new SessionServiceReference.Session();
            session = sessionService.getSession(sessionId);
            sessionService.updateSession(sessionId, session.CargoId, departureTime, arrivalTime, session.TruckId, destinationAddress, destinationCity);

            Response.Redirect("~/Views/Manager/Sessions.aspx");
        }

        protected void cancelSession_Click(object sender, EventArgs e)
        {
            string arrivalTime = "1900-01-01 00:00:00";
            SessionServiceReference.Session session = new SessionServiceReference.Session();
            session = sessionService.getSession(sessionId);
            sessionService.updateSession(sessionId, session.CargoId, Convert.ToString(session.DepartureTime), arrivalTime, session.TruckId, session.DestAddress, session.DestCity);
            orderService.cancelOrder(sessionId);

            Response.Redirect("~/Views/Manager/Sessions.aspx");

        }

        protected void cancelAll_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Manager/Sessions.aspx");
        }
    }
}