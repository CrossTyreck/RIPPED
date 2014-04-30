using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using RIPPEDD.Health_Input;
using RIPPEDD.Controllers;
using RIPPEDD.Entities;

namespace RIPPEDD
{
    public partial class PrintableReport : System.Web.UI.Page
    {
        private int userID;
        HealthInputReportController dbObject = new HealthInputReportController();

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            //Needs to be in the login function
            try
            {
                userID = ((SessionData)Session["User_Data"])._loginID;
            }
            catch (NullReferenceException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                Response.Redirect("Login.aspx");
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Chart.Series["Series1"].YValueMembers = "# of Activities";
            Chart.Series["Series1"].XValueMember = "# of Weeks";
            Chart1.Series["Series1"].YValueMembers = "# of Activities";
            Chart1.Series["Series1"].XValueMember = "# of Weeks";
            Chart2.Series["Series1"].YValueMembers = "# of Activities";
            Chart2.Series["Series1"].XValueMember = "# of Weeks";
            Chart3.Series["Series1"].YValueMembers = "# of Activities";
            Chart3.Series["Series1"].XValueMember = "# of Weeks";
            try
            {
                Chart.DataSource = dbObject.GetActivityData(((SessionData)Session["User_Data"])._loginID, 1, "strength");
                Chart1.DataSource = dbObject.GetActivityData(((SessionData)Session["User_Data"])._loginID, 1, "cardio");
                Chart2.DataSource = dbObject.GetActivityData(((SessionData)Session["User_Data"])._loginID, 1, "health");
                Chart3.DataSource = dbObject.GetActivityData(((SessionData)Session["User_Data"])._loginID, 1, "sleep");
            }
            catch (NullReferenceException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                Response.Redirect("Login.aspx");
            }
            Chart.DataBind();
            Chart1.DataBind();
            Chart2.DataBind();
            Chart3.DataBind();

            showInjuries();
            showWorkout();
            foreach (string name in HealthInputSessionVariables.Activity.Keys)
            {
                foreach (float value in HealthInputSessionVariables.Activity.Values)
                {
                    Label myLabel = new Label();
                    myLabel.ID = "lbl" + name;
                    myLabel.Text = value.ToString();
                }

            }
        }
        protected void showInjuries()
        {
            System.Diagnostics.Debug.WriteLine("working");
            HealthInputReportController controller = new HealthInputReportController(userID);
            string[] injuries = controller.ReturnInjuries(5);
            aLabel.Text = firsthalf(injuries[0]);
            firstInjury.Text = lasthalf(injuries[0]);
            bLabel.Text = firsthalf(injuries[1]);
            secondInjury.Text = lasthalf(injuries[1]);
            cLabel.Text = firsthalf(injuries[2]);
            thirdInjury.Text = lasthalf(injuries[2]);
            dLabel.Text = firsthalf(injuries[3]);
            fourthInjury.Text = lasthalf(injuries[3]);
            eLabel.Text = firsthalf(injuries[4]);
            fifthInjury.Text = lasthalf(injuries[4]);
        }
        protected void showWorkout()
        {
            HealthInputReportController controller = new HealthInputReportController(userID);
            workout.Text = controller.Returnworkout();
        }
        public static string firsthalf(string s)
        {
            if (String.IsNullOrEmpty(s))
                return "";
            int at = s.IndexOf(":");
            if (at > 0)
            {
                return s.Substring(0, at);
            }
            return "";
        }
        public static string lasthalf(string s)
        {
            if (String.IsNullOrEmpty(s))
                return "";
            int at = s.IndexOf(":");
            if (at > 0)
            {
                return s.Substring(at + 2);
            }
            return "";
        }
    }
}