using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RIPPEDD.Controllers;

namespace RIPPEDD
{
    public partial class Register : System.Web.UI.Page
    {
        RegisterController dbObject = new RegisterController();

        protected void Page_Load(object sender, EventArgs e)
        {
           dbObject.InsertNewUser
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lbldbObject.InsertNewUser(txtbxFirstName.Text, txtbxLastName.Text, txtbxUsername.Text, txtbxPassword.Text, txtbxSecurityQuestion.Text, txtSecurityAnswer.Text);
        }

        
    }
}