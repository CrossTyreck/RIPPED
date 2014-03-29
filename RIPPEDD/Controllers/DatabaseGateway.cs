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

        public String InsertData(String table, Dictionary<String, String> inputData)
        {
            SqlCommand insertData = null;

            try
            {
                string sSql = CreateSqlQuery("INSERT", table, inputData);
                insertData = new SqlCommand(sSql, GetDBConnection());
                insertData.Connection.Open();
                int rows = insertData.ExecuteNonQuery();
            }

            catch (SqlException e)
            { return e.Message; }
            catch (Exception e)
            { return e.Message; }

            finally
            {
                if (insertData.Connection.State == ConnectionState.Open)
                { insertData.Connection.Close(); }
            }

            return "Data Inserted correctly";
        }

        //private String CreateInsertSqlParameters(Dictionary<String, String> inputData)
        //{
        //    string sSql = null;
        //    foreach (KeyValuePair<String,String> pair in inputData)
        //    {
        //        sSql = (sSql == null? "" : sSql + ", ") + pair.Value;
        //    }
        //    return sSql == null ? "" : "VALUES (" + sSql + ")";

        //}


        /// <summary>
        ///  Creates a string used to query the database. 
        /// </summary>
        /// <param name="sSqlFunct">SQL Command such as UPDATE or INSERT</param>
        /// <param name="table"></param>
        /// <param name="inputData"></param>
        /// <returns></returns>
        private String CreateSqlQuery(String sSqlFunct, String table, Dictionary<String, String> inputData)
        {
            string sSql = null;

            switch (sSqlFunct)
            {
                case "UPDATE":
                    foreach (KeyValuePair<String, String> pair in inputData)
                    {
                        sSql = (sSql == null ? "" : sSql + ", ") + pair.Key + " = '" + pair.Value + "'";
                    }
                    sSql = sSql == null ? null : sSqlFunct + " " + table + " SET " + sSql;
                    break;

                case "INSERT":
                    string sValue = null;
                    foreach (KeyValuePair<String, String> pair in inputData)
                    {
                        sSql = (sSql == null ? "" : sSql + ", ") + pair.Key;
                        sValue = (sValue == null ? "" : sValue + ", ") + "'" + pair.Value + "'";
                    }
                    sSql = (sSql == null || sValue == null) ? null : sSqlFunct + " INTO " + table + " (" + sSql + ") VALUES (" + sValue + ")";
                    break;
                default:
                    return "ERROR";
            }
            if (sSql == null) throw new Exception("While creating " + sSqlFunct + " function. The statement return null");
            return sSql;
        }
    }
}