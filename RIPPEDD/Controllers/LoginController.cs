using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RIPPEDD.Controllers;
using System.Data;
using System.Data.SqlClient;

namespace RIPPEDD
{
    public class LoginController
    {
        private DatabaseGateway dbObject; 

        public void testConnection()
        {
            dbObject = new DatabaseGateway();
            SqlConnection loginConnection = dbObject.GetDBConnection();
            SqlCommand command = new SqlCommand("Select * From tblUsers", loginConnection);

            loginConnection.Open();

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
            { loginConnection.Close(); }
        }
    }
}