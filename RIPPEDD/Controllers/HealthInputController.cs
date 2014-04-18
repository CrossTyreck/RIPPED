using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using RIPPEDD.Health_Input;
using RIPPEDD.Controllers;
using RIPPEDD.Entities;


namespace RIPPEDD.Controllers
{
    public class HealthInputController : DatabaseGateway
    {

        ///<summary>
        /// Function: to test whether or not the string inputs are either empty or numeric
        /// If alphabetical or non-numeric characters exist, send false. The webpage will then
        /// take care to send an error message to the user prompting them to input again
        /// If the input is valid, open a new database connection to place the strings into the table
        /// <summary>
        /// 

        private int loginID;

        public HealthInputController()
        {
        }

        public HealthInputController(int loginID)
        {
            //base();

            this.loginID = loginID;

        }
        public bool inputCardioWorkout(string roadRunning, string treadmill, string cycling, string swimming, string walking, string rowing)
        {
            string[] testing = { roadRunning, treadmill, cycling, swimming, walking, rowing };
            double numTest = 0;

            for (int i = 0; i < testing.Length; ++i)
            {
                //If the string at the index i is not a numeric string
                if (!(Double.TryParse(testing[i], out numTest)))
                {
                    return false;
                }
            }


            //insert into database, beginning at activityID 1
            insertHealth(testing, 1);

            return true;
        }

        public bool inputStrengthWorkout(string climbing, string boxing, string pushups, string situps, string workout)
        {
            string[] testing = { climbing, boxing, pushups, situps };
            double numTest = 0;

            for (int i = 0; i < testing.Length; ++i)
            {
                //If the string at the index i is not a numeric string
                if (!(Double.TryParse(testing[i], out numTest)))
                {
                    return false;
                }
            }

            //Insert into database, beginning at activityID 7
            insertHealth(testing, 7);

            //Insert Workout Description

            SqlConnection d = GetDBConnection();
            SqlCommand c = null;

            try
            {
                c = new SqlCommand("INSERT INTO tblHealthData (tblLoginID, activityID, activity_data, activity_date, activity_description)"
                                                  + "VALUES (" + loginID + ", " + 11 + ", 0, CURRENT_TIMESTAMP, @workout)"
                                                   , d);
                c.Parameters.AddWithValue("@workout", workout);
                c.Connection.Open();

                SqlDataReader reader = c.ExecuteReader(System.Data.CommandBehavior.Default);

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

        public bool inputWorkActivities(string computerTime, string breaksPerHour, string lunchTime, string workTime, string meetingTime)
        {
            string[] testing = { computerTime, breaksPerHour, lunchTime, workTime, meetingTime };
            double numTest = 0;

            for (int i = 0; i < testing.Length; ++i)
            {
                //If the string at the index i is not a numeric string
                if (!(Double.TryParse(testing[i], out numTest)))
                {
                    return false;
                }
            }

            //this section begins at activityID 12
            insertHealth(testing, 12);

            return true;
        }

        
        public bool inputHealthIndicators(string weight, string bodyMassIndex, string sittingHeartRate, string workingHeartRate, string height, string sleep)
        {
            string[] testing = { weight, bodyMassIndex, sittingHeartRate, workingHeartRate, height, sleep };
            double numTest = 0;

            for (int i = 0; i < testing.Length; ++i)
            {
                //If the string at the index i is not a numeric string
                if (!(Double.TryParse(testing[i], out numTest)))
                {
                    return false;
                }
            }

            //Insert into database, beginning at activity id 17
            insertHealth(testing, 17);

            return true;
        }

        public bool inputCouchPotato(string computerTime, string television, string chores)
        {
            string[] testing = { computerTime, television, chores };
            double numTest = 0;

            for (int i = 0; i < testing.Length; ++i)
            {
                //If the string at the index i is not a numeric string
                if (!(Double.TryParse(testing[i], out numTest)))
                {
                    return false;
                }
            }

            //insert into database, beginning at activityID 23
            insertHealth(testing, 23);

            return true;
        }

        public bool inputInjury(string bodyPart, string injury)
        {
            if (injury.Equals(""))
            {
                return false;
            }

            SqlConnection database = GetDBConnection();
            SqlCommand command = null;

            try
            {
                command = new SqlCommand("INSERT INTO tblInjuryData (tblLoginID, injury_location, injury_comment, injury_date)"
                                                  + "VALUES (" + loginID + ", " + getInjuryID(bodyPart) + ", @injury, CURRENT_TIMESTAMP)"
                                                   , database);

               
                command.Parameters.AddWithValue("@injury", injury);
                command.Connection.Open();

                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.Default);

            }
            catch (SqlException e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return false;
            }
            finally
            {
                if (command.Connection.State == ConnectionState.Open)
                { command.Connection.Close(); }
            }

            return true;
        }

        public int getInjuryID(string bodyPart)
        {
            int result = 0;

            System.Diagnostics.Debug.WriteLine("Injury: " + bodyPart);
            switch (bodyPart)
            {
                case "Head": result = 1;
                    break;
                case "Right Shoulder": result = 2;
                    break;
                case "Right Elbow": result = 3;
                    break;
                case "Right Hand": result = 4;
                    break;
                case "Right Knee": result = 5;
                    break;
                case "Right Foot": result = 6;
                    break;
                case "Abdomen": result = 7;
                    break;
                case "Left Shoulder": result = 8;
                    break;
                case "Left Elbow": result = 9;
                    break;
                case "Left Knee": result = 10;
                    break;
                case "Left Foot": result = 11;
                    break;
                case "Neck": result = 12;
                    break;
                case "Left Shoulder Blade": result = 13;
                    break;
                case "Left Forearm": result = 14;
                    break;
                case "Lumbar": result = 15;
                    break;
                case "Thoracic": result = 16;
                    break;
                case "Left Heel": result = 17;
                    break;
                case "Right Heel": result = 18;
                    break;
                case "Right Shoulder Blade": result = 19;
                    break;
                case "Right Forearm": result = 20;
                    break;
                case "Left Hand": result = 21;
                    break;
            }

            return result;
        }

        public int GetActivityID(string activity)
        {
            SqlConnection database = GetDBConnection();
            SqlCommand getActivityID = new SqlCommand("SELECT act_id FROM tblActivities WHERE activity = " + activity, database);
            SqlDataReader reader = null;
            try
            {
                getActivityID.Connection.Open();
                reader = getActivityID.ExecuteReader(System.Data.CommandBehavior.SingleResult);
                if (reader.Read())
                {
                    return reader.GetInt32(0);
                }

            }
            catch (SqlException e)
            { return e.ErrorCode; }
            finally
            {
                if (getActivityID.Connection.State == ConnectionState.Open)
                {
                    getActivityID.Connection.Close();
                }
            }
            //nothing was returned
            return 0;
        }

        private bool insertHealth(string[] testing, int beginningID)
        {
            for (int i = 0; i < testing.Length; ++i)
            {

                SqlConnection database = GetDBConnection();
                SqlCommand command = null;

                try
                {
                    command = new SqlCommand("INSERT INTO tblHealthData (tblLoginID, activityID, activity_data, activity_date)"
                                                      + "VALUES (" + loginID + ", " + (i + beginningID) + ", " + testing[i] + ", CURRENT_TIMESTAMP)"
                                                       , database);
                    command.Connection.Open();

                    SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.Default);

                }
                catch (SqlException e)
                {
                    System.Diagnostics.Debug.WriteLine(e.Message);
                    return false;
                }
                finally
                {
                    if (command.Connection.State == ConnectionState.Open)
                    { command.Connection.Close(); }
                }
            }


            return true;
        }

    }
}