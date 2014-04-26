using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using RIPPEDD.Controllers;
using RIPPEDD.Entities;

namespace RIPPEDD.Controllers
{
    public class HealthInputReportController : DatabaseGateway
    {
        private int loginID;

        public HealthInputReportController()
        {
        }
        public HealthInputReportController(int loginID)
        {
            this.loginID = loginID;
        }

        enum TableType { Activity = 1 }

        DataTable TableData = new DataTable();

        public DataTable GetActivityData(int userId, int tableType)
        {
            TableData = GetTableType(tableType);
            SelectTableData(userId);
            return TableData;
        }

        public int SelectTableData(int id)
        {
            SqlCommand selectData = null;
            SqlDataReader reader = null;

            Dictionary<String, String> WhereID = new Dictionary<string, string>();
            WhereID.Add("tblLoginID", id.ToString());

            try
            {
                string sSql = CreateSqlQuery("SELECT activityID, activity_data, activity_date", "tblHealthData", WhereID);
                selectData = new SqlCommand(sSql, GetDBConnection());
                selectData.Connection.Open();
                reader = selectData.ExecuteReader();

                while (reader.Read())
                {
                    //dtTable.Rows.Add(reader.GetInt32(0), reader.GetDouble(1), reader.GetDateTime(2));
                    TableData.Rows.Add(reader.GetDouble(1), reader.GetDateTime(2));
                }

                if (TableData.Rows.Count > 0)
                {
                    return 1;
                }
            }

            catch (SqlException e)
            {
                TableData.Rows.Add(e.ErrorCode, e.Message);
                return e.ErrorCode;
            }
            catch (Exception e)
            {
                TableData.Rows.Add(e.HResult, e.Message);
                return e.HResult;
            }

            TableData.Rows.Add("EMPTY", "EMPTY");
            return -1;
        }

        public String[] ReturnInjuries()
        {
            SqlConnection d = GetDBConnection();
            SqlCommand command = null;
            string[] injuries = new string[7];
            try
            {
                command = new SqlCommand("SELECT top 7 * from tblInjuryData where tblLoginID = " + loginID + " order by injury_date DESC", d);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.Default);
                int counter = 0;
                while (reader.Read())
                {
                    String injury = reader.GetString(3);
                    int location = reader.GetInt32(2);            
                    injuries[counter] = returnInjury(location) + ": " + injury;
                    counter++;
                }
            }
            catch (SqlException e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return injuries;
            }
            finally
            {
                if (command.Connection.State == ConnectionState.Open)
                { command.Connection.Close(); }
            }
            return injuries;
        }
   
        private String returnInjury(int ID)
        {
            SqlConnection d = GetDBConnection();
            SqlCommand command = null;
            string[] injuries = new string[7];
            try
            {
                command = new SqlCommand("SELECT * from tblInjuryList where injury_id = " + ID, d);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.Default);
                if (reader.Read())
                {
                    return reader.GetString(1);
                }
            }
            catch (SqlException e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return "";
            }
            finally
            {
                if (command.Connection.State == ConnectionState.Open)
                { command.Connection.Close(); }
            }
            return "";
        }

        public bool TestDisplay()
        {
            SqlConnection d = GetDBConnection();
            SqlCommand c = null;
            try
            {
                c = new SqlCommand("SELECT * from tblHealthData where activity_data = 2 and activityID = 1", d);
                c.Connection.Open();
                SqlDataReader reader = c.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    int test = reader.GetInt32(1);
                    System.Diagnostics.Debug.WriteLine(test);
                }
            }
            catch (SqlException e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
            finally
            {
                if (c.Connection.State == ConnectionState.Open)
                { c.Connection.Close(); }
            }
            return true;
        }
        private DataTable GetTableType(int tableType)
        {
            DataTable Table = new DataTable();

            switch (tableType)
            {
                case (int)TableType.Activity:
                    Table.Columns.Add("# of Activities");
                    Table.Columns.Add("# of Weeks");
                    break;
            }

            return Table;
        }
    }
}