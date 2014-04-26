using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace RIPPEDD.Controllers
{
    public class WelcomeController : DatabaseGateway
    {
        public enum TableType { Activity = 1, BMI = 2, SittingHeartRate = 3, WorkingHeartRate = 4 }

        DataTable TableData = new DataTable();
        Dictionary<String, String> WhereItems = new Dictionary<string, string>();

        public DataTable GetData(int userId, TableType tableType)
        {
            TableData = GetTableType(userId, tableType);
            SelectTableData(userId, "activity_date");
            return TableData;
        }

        /// <summary>
        /// Allows you to query the database for the required table data
        /// </summary>
        /// <param name="id">Id for which you are requesting data for.</param>
        /// <param name="dtTable">Object responsible for containing the queried data</param>
        /// <returns>1 if the data table has objects, -1 if it does not, an error message if there is an error</returns>
        public int SelectTableData(int id, string orderby = "")
        {
            SqlCommand selectData = null;
            SqlDataReader reader = null;

            try
            {
                string sSql = CreateSqlQuery("SELECT activityID, activity_data, activity_date", "tblHealthData", WhereItems);
                if (orderby != "")
                {
                    OrderBy(sSql, orderby);
                }

                selectData = new SqlCommand(sSql, GetDBConnection());
                selectData.Connection.Open();
                reader = selectData.ExecuteReader();

                while (reader.Read())
                {
                    TableData.Rows.Add(reader.GetDouble(1), reader.GetDateTime(2).ToString("dd MMM"));
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

        private DataTable GetTableType(int userId, TableType tableType)
        {
            DataTable Table = new DataTable();

            switch (tableType)
            {
                case TableType.Activity:
                    WhereItems.Clear();
                    Table.Columns.Add("# of Activities");
                    Table.Columns.Add("# of Weeks");
                    WhereItems.Add("tblLoginID", userId.ToString());
                    break;

                case TableType.BMI:
                    WhereItems.Clear();
                    Table.Columns.Add("Activity");
                    Table.Columns.Add("Value");
                    WhereItems.Add("activityID", SelectActivityID("BMI").ToString());
                    WhereItems.Add("tblLoginID", userId.ToString());
                    break;

                case TableType.SittingHeartRate:
                    WhereItems.Clear();
                    Table.Columns.Add("Activity");
                    Table.Columns.Add("Value");
                    WhereItems.Add("activityID", SelectActivityID("Sitting Heart Rate").ToString());
                    WhereItems.Add("tblLoginID", userId.ToString());
                    break;

                case TableType.WorkingHeartRate:
                    WhereItems.Clear();
                    Table.Columns.Add("Activity");
                    Table.Columns.Add("Value");
                    WhereItems.Add("activityID", SelectActivityID("Working Heart Rate").ToString());
                    WhereItems.Add("tblLoginID", userId.ToString());
                    break;

            }
            return Table;
        }

        /// <summary>
        /// Used in retrieving the Activity ID
        /// </summary>
        /// <returns>int Activity ID from tblActivities</returns>
        private int SelectActivityID(string activityName)
        {
            SqlCommand selectData = null;
            SqlDataReader reader = null;

            Dictionary<String, String> Activity = new Dictionary<String, String>();
            Activity.Add("activity", activityName);

            try
            {
                string sSql = CreateSqlQuery("SELECT act_id", "tblActivities", Activity);
                selectData = new SqlCommand(sSql, GetDBConnection());
                selectData.Connection.Open();
                reader = selectData.ExecuteReader(CommandBehavior.SingleResult);

                if (reader.Read())
                {
                   return reader.GetInt32(0);
                }
            }

            catch (SqlException e)
            {
                return e.ErrorCode;
            }
            catch (Exception e)
            {
                return e.HResult;
            }

            return -1;
        }
    }
}