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
            try
            {
                Chart.DataSource = dbObject.GetActivityData(((SessionData)Session["User_Data"])._loginID, 1);
            }
            catch (NullReferenceException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                Response.Redirect("Login.aspx");
            }
            Chart.DataBind();

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

        protected void btnTest_OnClick(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("working");
            HealthInputReportController controller = new HealthInputReportController(userID);
            string[] injuries = controller.ReturnInjuries();
            firstInjury.Text = injuries[0];
            secondInjury.Text = injuries[1];
            thirdInjury.Text = injuries[2];
            fourthInjury.Text = injuries[3];
            fifthInjury.Text = injuries[4];
        }

        protected void workoutSelect(object sender, EventArgs e)
        {
        var text = ddlist.SelectedItem.Text;
            
        }
        

        protected void ChangeDoctor_Click(object sender, EventArgs e)
        {
            Response.Redirect("HealthProfessionals.aspx");
        }

        protected void PrintReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("Welcome.aspx");
        }

    }
}