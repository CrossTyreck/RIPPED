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
    enum LoginFields
    {
        user_type, username, password, first_name, last_name, security_question, security_answer
    }

    public partial class Register : System.Web.UI.Page
    {
        RegisterController dbObject = new RegisterController();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            User newUser = new User(txtbxUsername.Text, txtbxPassword.Text, txtbxFirstName.Text, txtbxLastName.Text, txtbxSecurityQuestion.Text, txtSecurityAnswer.Text);
            String info;

            if (dbObject.InsertNewUser(newUser, out info))
            {
                Response.Redirect("Login.aspx?reg=1");
            }
            else
            {
                string script = "alert(\"" + info + "\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
            }
        }



    }
}