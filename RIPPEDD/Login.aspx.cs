using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RIPPEDD.Controllers;

namespace RIPPEDD
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblIncorrectLogin.Visible = false;
        }

        protected void btnLogin_OnClick(object sender, EventArgs e)
        {
            DatabaseGateway dbObject = new DatabaseGateway();
            Response.Redirect("Welcome.aspx");
            //HELLO
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }


    }
}