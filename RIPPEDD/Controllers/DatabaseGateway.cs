using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using RIPPEDD.Entities;
using System.Data.Sql;
using System.Web.UI;


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

        /// <summary>
        /// Create a connection to the database
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetDBConnection()
        {
            return databaseConnection = new SqlConnection(server + database + user + password + connectiontrust + encryption + timeout);

        }

        /// <summary>
        /// Allows you to retrieve all the user information from the database for a particular user
        /// </summary>
        /// <param name="table">tblUser</param>
        /// <param name="inputData"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public int SelectUser(String table, Dictionary<String, String> inputData, out User user)
        {
            SqlCommand selectData = null;
            user = null;
             SqlDataReader reader = null;
            try
            {
                string sSql = CreateSqlQuery("SELECT *", table, inputData);
                selectData = new SqlCommand(sSql, GetDBConnection());
                selectData.Connection.Open();
                reader = selectData.ExecuteReader(CommandBehavior.SingleRow);
                
                if (reader.Read())
                {
                   user = new User(reader.GetString(2), null, reader.GetString(4), reader.GetString(5));
                   return reader.GetInt32(0);
                }
            }

            catch (SqlException e)
            { return e.ErrorCode; }
            catch (Exception e)
            { return e.HResult; }

            return -1;
        }

        /// <summary>
        /// Queries the database to insert data. 
        /// </summary>
        /// <param name="table">The table should the insert occurr in.</param>
        /// <param name="inputData">The data to be inserted into the database.</param>
        /// <returns>A message displaying whether the insert occurred or an error happened.</returns>
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

            return "Data Inserted correctly";
        }

        /// <summary>
        ///  Creates a string used to query the database. 
        /// </summary>
        /// <param name="sSqlFunct">SQL Command such as UPDATE or INSERT</param>
        /// <param name="table">Table you are querying</param>
        /// <param name="inputData">Data manipulated</param>
        /// <returns>Returns the Query</returns>
        protected String CreateSqlQuery(String sSqlFunct, String table, Dictionary<String, String> inputData)
        {
            string sSql = null;
           
            switch (sSqlFunct.Contains(' ') ? sSqlFunct.Substring(0, sSqlFunct.IndexOf(' ')) : sSqlFunct)
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

                case "SELECT":
                    foreach(KeyValuePair<String,String> pair in inputData)
                    {
                        sSql = (sSql == null ? "" : sSql + " AND ") + pair.Key + " = '" + pair.Value + "'";
                    }
                    sSql = sSqlFunct + " FROM " + table + (sSql == null ? "" : " WHERE " + sSql); 
                    
                    break;
                default:
                    return "ERROR";
            }
            if (sSql == null) throw new Exception("While creating " + sSqlFunct + " function. The statement returned null");
            return sSql;
        }
    }
}