using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RIPPEDD
{
    public partial class Site1 : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Count == 0)
                lnkLogoutButton.Visible = false; 

        }

        protected void lnkWelcomePage_Click(object sender, EventArgs e)
        {
            if (Session.Count == 0)
                Response.Redirect("Login.aspx");
            else
                Response.Redirect("Welcome.aspx");
        }

        protected void lnkLogoutButton_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Login.aspx");
        }
    }
}