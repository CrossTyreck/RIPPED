using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RIPPEDD
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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