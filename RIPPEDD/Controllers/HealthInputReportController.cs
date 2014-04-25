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

        public String[] ReturnInjuries()
        {

            SqlConnection d = GetDBConnection();
            SqlCommand command = null;
            string[] injuries = new string[7];

            try
            {
                command = new SqlCommand("SELECT * from tblInjuryData where tblLoginID = " + loginID + "order by injury_date", d);

                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.Default);
                int counter = 0;

                while (reader.Read())
                {
                    injuries[counter] = reader.GetString(3);
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
    }
}