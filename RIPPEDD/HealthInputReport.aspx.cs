using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using RIPPEDD.Health_Input;
using RIPPEDD.Controllers;
using RIPPEDD.Entities;
using WebSupergoo.ABCpdf9;


namespace RIPPEDD
{
    public partial class HealthInputReport : System.Web.UI.Page
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

        Dictionary<string, int> dictInjury = new Dictionary<string, int>();

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



            if (!IsPostBack)
            {
                dictInjury.Add("Head", 0);
                dictInjury.Add("Right Shoulder", 0);
                dictInjury.Add("Right Elbow", 0);
                dictInjury.Add("Right Hand", 0);
                dictInjury.Add("Right Knee", 0);
                dictInjury.Add("Right Foot", 0);
                dictInjury.Add("Abdomen", 0);
                dictInjury.Add("Left Shoulder", 0);
                dictInjury.Add("Left Elbow", 0);
                dictInjury.Add("Left Knee", 0);
                dictInjury.Add("Left Foot", 0);
                dictInjury.Add("Neck", 0);
                dictInjury.Add("Left Shoulder Blade", 0);
                dictInjury.Add("Left Forearm", 0);
                dictInjury.Add("Lumbar", 0);
                dictInjury.Add("Thoracic", 0);
                dictInjury.Add("Left Heel", 0);
                dictInjury.Add("Right Heel", 0);
                dictInjury.Add("Right Shoulder Blade", 0);
                dictInjury.Add("Right Forearm", 0);
                dictInjury.Add("Left Hand", 0);
            }

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
            //fifthInjury.Text = userID.ToString();//KC testing
            
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
                return s.Substring(at+2);
            }
            return "";

        }
        
        protected void ChangeDoctor_Click(object sender, EventArgs e)
        {
            Response.Redirect("HealthProfessionals.aspx");
        }

        protected void PrintReport_Click(object sender, EventArgs e)
        {
            Doc theDoc = new Doc();
            //HttpCookie cookie = new HttpCookie("userID", userID.ToString());//kc testing
            //theDoc.HtmlOptions.HttpAdditionalHeaders = "Cookie: userID=" + userID;
            //theDoc.HtmlOptions.NoCookie = true;
            theDoc.AddImageUrl("http://"+Request.Url.Authority+"/PrintableReport.aspx?userID=" + userID);
            byte[] theData = theDoc.GetData();
            Response.Clear();
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "inline; filename=MyPDF.PDF");
            Response.AddHeader("content-length", theData.Length.ToString());
            Response.BinaryWrite(theData);
            Response.End();
        }
    }
}