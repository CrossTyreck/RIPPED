using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RIPPEDD.Entities
{
    public class User
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }


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
        public User(string firstname, string lastname, string username, string password, string securityquestion, string securityanswer)
        {
            first_name = firstname;
            last_name = lastname;
            UserName = username;
            Password = password;
            SecurityQuestion = securityquestion;
            SecurityAnswer = securityanswer;

        }

        public Dictionary<String, String> CreateDict()
        {
            Dictionary<String, String> regDict = new Dictionary<string, string>();
            regDict["FirstName"] = first_name;
            regDict["LastName"] = last_name;
            regDict["FirstName"] = first_name;
            regDict["FirstName"] = first_name;
            regDict["FirstName"] = first_name;
            regDict["FirstName"] = first_name;

            return regDict;

        }
    }
}