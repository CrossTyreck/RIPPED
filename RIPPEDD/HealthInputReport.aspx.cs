using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RIPPEDD.Health_Input;


namespace RIPPEDD
{
    public partial class HealthInputReport : System.Web.UI.Page
    {

        Dictionary<string, int> dictInjury = new Dictionary<string, int>();

        protected void Page_Load(object sender, EventArgs e)
        {
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

        protected void SetInjury(object sender, ImageMapEventArgs e)
        {

            if (dictInjury.ContainsKey(e.PostBackValue))
            {
                dictInjury[e.PostBackValue] = 1;
            }

        }

        protected void ChangeDoctor_Click(object sender, EventArgs e)
        {
            Response.Redirect("HealthProfessionals.aspx");
        }

        protected void SubmitReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("Welcome.aspx");
        }

    }
}