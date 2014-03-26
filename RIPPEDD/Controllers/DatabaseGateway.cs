using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace RIPPEDD.Controllers
{
    public class DatabaseGateway
    {

        private string server = "Server=" + "tcp:h6lr0qsx1c.database.windows.net, 1433" + ";";
        private string database = "Database=" + "RIPPED" + ";";
        private string user = "User ID=" + "RIPPED@h6lr0qsx1c" + ";";
        private string password = "Password=" + "KtsNW8mM!" + ";";
        private string connectiontrust = "Trusted_Connection=False;";
        private string encryption = "Encrypt=True;";
        private string timeout = "Connection Timeout=" + "30" + ";";

        private SqlConnection databaseConnection;

        public DatabaseGateway()
        {
         
        }

        public SqlConnection GetDBConnection()
        {
            return databaseConnection = new SqlConnection(server + database + user + password + connectiontrust + encryption + timeout);

        }

        /// <summary>
        /// Used only to verify the connection by passing data to a data reader. Also serves as a generic
        /// layout for connection code. 
        /// </summary>
        private void testConnection()
        {
            SqlCommand command = new SqlCommand("Select * From tblUsers", databaseConnection);

            databaseConnection.Open();

            try
            {
                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.Default);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}", reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
            }
            catch (SqlException eSql)
            { Console.WriteLine(eSql.Message); }
            finally
            { databaseConnection.Close(); }
        }

    }
}