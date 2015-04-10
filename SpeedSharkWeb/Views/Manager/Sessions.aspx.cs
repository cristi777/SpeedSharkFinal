using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpeedSharkWeb.Views.Manager
{
    public partial class Sessions : System.Web.UI.Page
    {
        private static SessionServiceReference.ISessionService sessionService = new SessionServiceReference.SessionServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RepeaterDataBinding();
            }
        }

        protected void SessionRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName.ToString())
            {
                case "sessionUpdate":
                    int sessionId = Convert.ToInt32(e.CommandArgument);
                    Session["sessionId"] = sessionId;
                    Response.Redirect("~/Views/Manager/UpdateSession.aspx");
                    break;
                default:
                    break;
            }
        }


        public void RepeaterDataBinding()
        {
            SessionServiceReference.Session[] ongoingSessions = sessionService.getOngoingSessions();

            try
            {
                this.SessionRepeater.DataSource = ongoingSessions;
                this.SessionRepeater.DataBind();
            }
            catch (NullReferenceException) { }
        }

    }
}