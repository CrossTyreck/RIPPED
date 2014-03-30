using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RIPPEDD.Controllers;
using RIPPEDD.Entities;

namespace RIPPEDD
{
    public partial class Login : System.Web.UI.Page
    {
        SessionData userData = new SessionData();

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Request.QueryString["reg"] == null ? '0' : '1') == '1')
            {
                lblRegister.Visible = false;
                btnRegister.Visible = false;
                lblRegistered.Visible = true;
            }
        }

        protected void btnLogin_OnClick(object sender, EventArgs e)
        {
            LoginController dbObject = new LoginController();
            User user = new User(txtUserName.Text, txtPassword.Text);
            User retUser;
            int id;
            String info;
            if (dbObject.LoginAuthentication(user, out id, out retUser, out info))
            {
                userData._loginID = id;
                userData._user = retUser;
                Session["User_Data"] = userData;
                Response.Redirect(info);
            }
            else
            {
                string script = "alert(\"" + info + "\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
            }
          
            //HELLO

           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }


    }
}