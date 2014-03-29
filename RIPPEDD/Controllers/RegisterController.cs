using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RIPPEDD.Controllers;
using System.Data.SqlClient;


namespace RIPPEDD
{
    public class RegisterController : DatabaseGateway
    {

        public RegisterController()
        {


        }

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
        public String InsertNewUser(String first_name, String last_name, String username, String password, String securityQuestion, String securityAnswer)
        {
            SqlConnection dbConn = GetDBConnection();
            SqlCommand insertNewUser = new SqlCommand("INSERT INTO tblLogin (user_type," +
                                                        " username, password, first_name, last_name," +
                                                        " security_question, security_answer) " + Environment.NewLine +
                                                        "VALUES ('general user', @username, @password," +
                                                        " @firstName, @lastName, @securityQuestion, @securityAnswer)",
                                                           dbConn);
            dbConn.Open();

            SqlDataReader reader = new SqlDataReader();

            try
            { reader = insertNewUser.ExecuteReader(System.Data.CommandBehavior.SequentialAccess); }
            catch (SqlException e)
            { return e.Message; }

            finally
            {
                reader.Close();
                dbConn.Close();
            }
            return "Data Inserted Successfully";
        }

    }
}