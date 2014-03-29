using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RIPPEDD.Controllers;

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
            Dictionary<Enum, String> dictTblLoginUser = new Dictionary<Enum, String>();
           

            //lblDataInserted.Text = dbObject.InsertData("tblLogin", 
        }

        
        
    }
}