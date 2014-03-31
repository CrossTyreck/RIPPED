using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RIPPEDD.Entities
{
    public class User
    {
        public string user_type { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string user_name { get; set; }
        public string pass_word { get; set; }
        public string security_question { get; set; }
        public string security_answer { get; set; }
        private Dictionary<String, String> userData;

        /// <summary>
        /// Creates the User object by assigning the values from the Register page
        /// textboxes.
        /// </summary>
        /// <param name="first_name">Value of txtbxFirstName</param>
        /// <param name="last_name">Value of txtbxLastName</param>
        /// <param name="user_name">Value of txtbxUserName</param>
        /// <param name="password">Value of txtbxPassword</param>
        /// <param name="security_question">Value of txtbxSecurityQuestion</param>
        /// <param name="security_answer">Value of txtbxSecurityAnswer</param>
        public User(string username, string password, string firstname = null, string lastname = null, string securityquestion = null, string securityanswer = null)
        {
            user_type = "General User";
            first_name = firstname;
            last_name = lastname;
            user_name = username;
            pass_word = password;
            security_question = securityquestion;
            security_answer = securityanswer;

        }

        /// <summary>
        /// Creates an ordered list to use for querying userdata
        /// out of the database. 
        /// </summary>
        /// <returns></returns>
        public Dictionary<String, String> CreateDict()
        {
            List<string> dummy;
            if (userData == null)
                ValidateRegister(out dummy);
            return userData;
        }

        /// <summary>
        /// Verifies the user inputted data into the registration screen
        /// before trying to add the user to the database. 
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public bool ValidateRegister(out List<String> info)
        {
            if (userData != null) userData.Clear();
            else userData = new Dictionary<string, string>();
            ValidateLogin(out info);

            if (user_type == null || user_type == "")
                user_type = "General User";
            //info.Add("Please choose a User Type");
            else
                userData["user_type"] = user_type;

            if (first_name == null || first_name == "")
                info.Add("Please input your First Name.");
            else
                userData["first_name"] = first_name;

            if (last_name == null || last_name == "")
                info.Add("Last Name is empty.");
            else
                userData["last_name"] = last_name;

            if (security_question == null || security_question == "")
                info.Add("Please create a Security Question to help you recover your password.");
            else
                userData["security_question"] = security_question;

            if (security_answer == null || security_answer == "")
                info.Add("Security Answer is required.");
            else
                userData["security_answer"] = security_answer;

            return info.Count == 0;

        }

        /// <summary>
        /// Verifies the user inputted data into all fields
        /// before trying to verify their credentials. 
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public bool ValidateLogin(out List<String> info)
        {
            if (userData != null) userData.Clear();
            else userData = new Dictionary<string, string>();
            info = new List<String>();

            if (user_name == null || user_name == "")
                info.Add("Enter a User Name.");
            else
                userData["user_name"] = user_name;

            if (pass_word == null || pass_word == "")
                info.Add("Password is blank.");
            else
                userData["pass_word"] = pass_word;

            return info.Count == 0;

        }
    }
}