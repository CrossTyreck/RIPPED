using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RIPPEDD.Controllers;
using System.Data.SqlClient;
using RIPPEDD.Entities;


namespace RIPPEDD.Controllers
{
    public class RegisterController : DatabaseGateway
    {

        /// <summary>
        /// Insert a new user into the database. 
        /// Returns a string to let the user know the insert was successful
        /// or outputs the database error message.
        /// </summary>
        /// <param name="first_name"></param>
        /// <param name="last_name"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="securityQuestion"></param>
        /// <param name="securityAnswer"></param>
        /// <returns></returns>
        public bool InsertNewUser(User user, out String info)
        {
            List<String> errors = null;
            if (user.ValidateRegister(out errors))
            {
                info = InsertData("tblUser", user.CreateDict());
                return true;
            }
            else
            {
                info = "There are the following errors:";
                foreach (String error in errors)
                {
                    info += "\\n" + error;
                }
                return false;
            }

        }
    }
}