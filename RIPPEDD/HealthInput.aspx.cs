using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using RIPPEDD.Health_Input;

namespace RIPPEDD
{
    public partial class HealthInput : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblSubmissionInfo.Visible = false;

            if (ddlWorkoutChoices.Items.Count < 1)
            {
                foreach (View view in WorkoutChoices.Views)
                {
                    ddlWorkoutChoices.Items.Add(view.ID.ToString());
                }
            }


            WorkoutChoices_SetView(sender, e);
        }

        protected void WorkoutChoices_SetView(object sender, EventArgs e)
        {
            foreach (View view in WorkoutChoices.Views)
            {
                if (view.ID.ToString().Equals(ddlWorkoutChoices.Text))
                {
                    WorkoutChoices.SetActiveView(view);
                }
            }

        }

        protected void btnSubmitResults_Click(object sender, EventArgs e)
        {
            //http://stackoverflow.com/questions/13362904/convert-control-to-textbox-and-assign-it-a-value
            //foreach (TextBox txtBox in this.Controls)
            //{
             
            //    if (txtBox.Visible && txtBox.Text.Length > 0)
            //    {
            //        float dControl;
            //        float.TryParse(txtBox.Text, NumberStyles.Currency, NumberFormatInfo.InvariantInfo, out dControl);

            //        HealthInputSessionVariables.Activity.Add(txtBox.ID.Remove(0, 3), dControl);
            //    }
            //}

            Response.Redirect("HealthInputReport.aspx");
        }

    }
}