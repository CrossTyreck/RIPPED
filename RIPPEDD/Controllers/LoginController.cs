using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RIPPEDD.Controllers;
using System.Data;
using System.Data.SqlClient;
using RIPPEDD.Entities;

namespace RIPPEDD.Controllers
{
    public class LoginController : DatabaseGateway
    {
        /// <summary>
        /// Verifies the users login. 
        /// </summary>
        /// <param name="user"></param>
        /// <param name="id"></param>
        /// <param name="retUser"></param>
        /// <param name="info"></param>
        /// <returns></returns>
        public bool LoginAuthentication(User user, out int id, out User retUser, out String info)
        {
            List<String> errors;

            if (user.ValidateLogin(out errors))
            {
                info = "Welcome.aspx";
                if ((id = SelectUser("tblUser", user.CreateDict(), out retUser)) < 0)
                {
                    info = "Incorrect username and/or password";
                    return false;
                }

                return true;
            }
            else
            {
                info = "There are the following errors:";
                foreach (String error in errors)
                {
                    info += "\\n" + error;
                }
                retUser = null;
                id = -1;
                return false;
            }

        }



    }
}