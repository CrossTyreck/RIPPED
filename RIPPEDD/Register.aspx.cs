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

    public partial class Register : System.Web.UI.Page
    {
        public RegisterController dbObject = new RegisterController();
        public User newUser; 
        /// <summary>
        /// Insert user information into the database to create a login for that user. 
        /// Displays an error if any fields are not filled in.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            newUser = new User(txtbxUsername.Text, txtbxPassword.Text, txtbxFirstName.Text, txtbxLastName.Text, txtbxSecurityQuestion.Text, txtSecurityAnswer.Text);
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