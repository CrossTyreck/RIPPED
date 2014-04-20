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
        enum TableType { Activity = 1 }

        DataTable TableData = new DataTable();

        public DataTable GetActivityData(int userId, int tableType)
        {
            TableData = GetTableType(tableType);
            SelectTableData(userId);
            return TableData;
        }

        /// <summary>
        /// Allows you to query the database for the required table data
        /// </summary>
        /// <param name="id">Id for which you are requesting data for.</param>
        /// <param name="dtTable">Object responsible for containing the queried data</param>
        /// <returns>1 if the data table has objects, -1 if it does not, an error message if there is an error</returns>
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