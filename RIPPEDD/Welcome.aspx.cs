using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using RIPPEDD.Controllers;
using RIPPEDD.Entities;

namespace RIPPEDD
{
    public partial class Welcome : System.Web.UI.Page
    {
        WelcomeController dbObject = new WelcomeController();

        protected void Page_Load(object sender, System.EventArgs e)
        {

            NumberOfActivitesByDate.Series["ActivitiesSeries1"].YValueMembers = "# of Activities";
            NumberOfActivitesByDate.Series["ActivitiesSeries1"].XValueMember = "# of Weeks";


            try
            {
                NumberOfActivitesByDate.DataSource = dbObject.GetActivityData(((SessionData)Session["User_Data"])._loginID, 1);
            }
            catch (NullReferenceException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                Response.Redirect("Login.aspx");
            }
            NumberOfActivitesByDate.DataBind();

        }
        protected void InputHealth_Click(object sender, EventArgs e)
        {
            Response.Redirect("HealthInput.aspx");
        }

        protected void HealthProfessionals_Click(object sender, EventArgs e)
        {
            Response.Redirect("HealthProfessionals.aspx");
        }

        protected void GenerateHealthReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("HealthInputReport.aspx");
        }


    }
}