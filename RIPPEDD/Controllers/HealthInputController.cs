using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Globalization;
using RIPPEDD.Health_Input;
using RIPPEDD.Controllers;
using RIPPEDD.Entities;


namespace RIPPEDD.Controllers
{
    ///<summary>
    /// Function: to test whether or not the string inputs are either empty or numeric
    /// If alphabetical or non-numeric characters exist, send false. The webpage will then
    /// take care to send an error message to the user prompting them to input again
    /// If the input is valid, open a new database connection to place the strings into the table
    /// <summary>
    /// 
    public class HealthInputController : DatabaseGateway
    {

        
        //Session ID instance variable
        private int loginID;

        public HealthInputController()
        {
            loginID = 0;
        }

        /// <summary>
        /// Intantiates the Database object controller with a loginID from the website
        /// </summary>
        /// <param name="loginID"></param>
        public HealthInputController(int loginID)
        {
            

            this.loginID = loginID;

        }

        public bool inputCardioWorkout(string roadRunning, string treadmill, string cycling, string swimming, string walking, string rowing, out string message)
        {
            string[] testing = { roadRunning, treadmill, cycling, swimming, walking, rowing };
            double numTest = 0;
            bool result = true;
            bool parseTest = false;
            message = "";
            

            for (int i = 0; i < testing.Length; ++i)
            {
                //If the string at the index i is not a numeric string
                parseTest = !(Double.TryParse(testing[i], out numTest));
                if (parseTest)
                {
                    switch (i)
                    {
                        case 0: message += "Non-numeric value at textbox Road Running.\\n";
                            break;
                        case 1: message += "Non-numeric value at textbox Treadmill.\\n";
                            break;
                        case 2: message += "Non-numeric value at textbox Cycling.\\n";
                            break;
                        case 3: message += "Non-numeric value at textbox Swimming.\\n";
                            break;
                        case 4: message += "Non-numeric value at textbox Walking.\\n";
                            break;
                        case 5: message += "Non-numeric value at textbox Rowing.\\n";
                            break;
                       
                    }

                
                    result = false;
                    //break;
                }

                if(numTest < 0)
                {
                     switch (i)
                    {
                        case 0: message += "Negative value at textbox Road Running.\\n";
                            break;
                        case 1: message += "Negative value at textbox Treadmill.\\n";
                            break;
                        case 2: message += "Negative value at textbox Cycling.\\n";
                            break;
                        case 3: message += "Negative value at textbox Swimming.\\n";
                            break;
                        case 4: message += "Negative value at textbox Walking.\\n";
                            break;
                        case 5: message += "Negative value at textbox Rowing.\\n";
                            break;
                       
                    }

                
                    result = false;
                    //break;
                }
                
            }

           // System.Diagnostics.Debug.WriteLine(message);
            //test
            //insert into database, beginning at activityID 1
            if (result == true)
            {
                insertHealth(testing, 1);
                message = "Success";
            }
                
            
            return result;
        }

        public bool inputStrengthWorkout(string climbing, string boxing, string pushups, string situps, string workout, out string message)
        {
            string[] testing = { climbing, boxing, pushups, situps };
            double numTest = 0;
            bool result = true;
            bool parseTest = false;
            message = "";

            for (int i = 0; i < testing.Length; ++i)
            {
                //If the string at the index i is not a numeric string
                parseTest = !(Double.TryParse(testing[i], out numTest));
                if (parseTest)
                {
                    switch (i)
                    {
                        case 0: message += "Non-numeric value at textbox Climbing.\\n";
                            break;
                        case 1: message += "Non-numeric value at textbox Boxing.\\n";
                            break;
                        case 2: message += "Non-numeric value at textbox Pushups.\\n";
                            break;
                        case 3: message += "Non-numeric value at textbox Situps.\\n";
                            break;
                        case 4: message += "Non-numeric value at textbox Workout.\\n";
                            break;
                     
                    }

                    result = false;
                    //break;
                }

                if(numTest < 0)
                {
                    switch (i)
                    {
                        case 0: message += "Negative value at textbox Climbing.\\n";
                            break;
                        case 1: message += "Negative value at textbox Boxing.\\n";
                            break;
                        case 2: message += "Negative value at textbox Pushups.\\n";
                            break;
                        case 3: message += "Negative value at textbox Situps.\\n";
                            break;
                        case 4: message += "Negatve value at textbox Workout.\\n";
                            break;
                     
                    }

                    result = false;
                    //break;
                }


            }

            
            


            if (result == true)
            {

                //Insert into database, beginning at activityID 7
                insertHealth(testing, 7);

                //Insert Workout Description

                if (!(workout == "" || workout == "Describe your workout routine here (workouts, # of reps, weights, etc)."))
                {
                    System.Diagnostics.Debug.WriteLine("Empty");
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
                }
                message = "Success";
            }
           
            return result;
        }

        public bool inputWorkActivities(string computerTime, string breaksPerHour, string lunchTime, string workTime, string meetingTime, out string message)
        {
            string[] testing = { computerTime, breaksPerHour, lunchTime, workTime, meetingTime };
            double numTest = 0;
            bool result = true;
            bool parseTest = false;
            message = "";

            for (int i = 0; i < testing.Length; ++i)
            {
                //If the string at the index i is not a numeric string
                System.Diagnostics.Debug.WriteLine((result) ? "true" : "false");
                parseTest = !(Double.TryParse(testing[i], out numTest));
                if (parseTest)
                {
                    switch (i)
                    {
                        case 0: message += "Non-numeric value at textbox Computer Time\\n";
                            break;
                        case 1: message += "Non-numeric value at textbox Breaks Per Hour\\n";
                            break;
                        case 2: message += "Non-numeric value at textbox Lunch Time\\n";
                            break;
                        case 3: message += "Non-numeric value at textbox Work Time\\n";
                            break;
                        case 4: message += "Non-numeric value at textbox Meeting Time\\n";
                            break;

                    }

                    
                    result = false;
                    //break;
                }

                if(numTest < 0)
                {
                    switch (i)
                    {
                        case 0: message += "Negative value at textbox Computer Time\\n";
                            break;
                        case 1: message += "Negative value at textbox Breaks Per Hour\\n";
                            break;
                        case 2: message += "Negative value at textbox Lunch Time\\n";
                            break;
                        case 3: message += "Negative value at textbox Work Time\\n";
                            break;
                        case 4: message += "Negative value at textbox Meeting Time\\n";
                            break;

                    }

                    result = false;
                    //break;
                }
            }

            //this section begins at activityID 12
            System.Diagnostics.Debug.WriteLine((result) ? "true" : "false");

            if (result == true)
            {
                insertHealth(testing, 12);
                message = "Success";
            }
                
            
            return result;
        }


        public bool inputHealthIndicators(string weight, string bodyMassIndex, string sittingHeartRate, string workingHeartRate, string height, string sleep, out string message)
        {
            string[] testing = { weight, bodyMassIndex, sittingHeartRate, workingHeartRate, height, sleep };
            double numTest = 0;
            bool result = true;
            bool parseTest = false;
            message = "";

            for (int i = 0; i < testing.Length; ++i)
            {
                //If the string at the index i is not a numeric string
                parseTest = !(Double.TryParse(testing[i], out numTest));
                if (parseTest)
                {
                    switch (i)
                    {
                        case 0: message += "Non-numeric value at textbox Weight\\n";
                            break;
                        case 1: message += "Non-numeric value at textbox BMI\\n";
                            break;
                        case 2: message += "Non-numeric value at textbox Sitting Heart Rate\\n";
                            break;
                        case 3: message += "Non-numeric value at textbox Working Heart Rate\\n";
                            break;
                        case 4: message += "Non-numeric value at textbox Height\\n";
                            break;
                        case 5: message += "Non-numeric value at textbox Sleep\\n";
                            break;

                    }

               
                    result = false;
                   // break;
                }

                if (numTest < 0)
                {
                    switch (i)
                    {
                        case 0: message += "Negative value at textbox Weight\\n";
                            break;
                        case 1: message += "Negative value at textbox BMI\\n";
                            break;
                        case 2: message += "Negative value at textbox Sitting Heart Rate\\n";
                            break;
                        case 3: message += "Negative value at textbox Working Heart Rate\\n";
                            break;
                        case 4: message += "Negative value at textbox Height\\n";
                            break;
                        case 5: message += "Negative value at textbox Sleep\\n";
                            break;

                    }

                    result = false;
                    //break;
                }
            }

            //Insert into database, beginning at activity id 17
            

            if (result == true)
            {
                insertHealth(testing, 17);
                message = "Success";
            }
                
            return result;
        }

        public bool inputCouchPotato(string computerTime, string television, string chores, out string message)
        {
            string[] testing = { computerTime, television, chores };
            double numTest = 0;
            bool result = true;
            message = "";

            for (int i = 0; i < testing.Length; ++i)
            {
                //If the string at the index i is not a numeric string
                if (!(Double.TryParse(testing[i], out numTest)))
                {
                    switch (i)
                    {
                        case 0: message += "Non-numeric value at textbox Computer Time\\n";
                            break;
                        case 1: message += "Non-numeric value at textbox Television Time\\n";
                            break;
                        case 2: message += "Non-numeric value at textbox Chores Time\\n";
                            break;

                    }

                    result = false;
                    //break;
                }

                if (numTest < 0)
                {
                    switch (i)
                    {
                        case 0: message += "Negative value at textbox Computer Time\\n";
                            break;
                        case 1: message += "Negative value at textbox Television Time\\n";
                            break;
                        case 2: message += "Negative value at textbox Chores Time\\n";
                            break;

                    }
                    result = false;
                    //break;
                }
            }

            //insert into database, beginning at activityID 23
           

            if (result == true)
            {
                insertHealth(testing, 23);
                message = "Success";
            }
                
            return result;
        }

        public bool inputInjury(Dictionary<string, string> panelList, out string message)
        {
            message = "";
            bool result = true;
            foreach (KeyValuePair<string, string> o in panelList)
            {
                if (o.Value.Equals(""))
                {
                    message += "Empty field! (at " + o.Key + ").\\n";
                    result = false;
                }
            }

            if (result == true)
            {
                foreach (KeyValuePair<string, string> o in panelList)
                {
                    System.Diagnostics.Debug.WriteLine(o.Key + ":: " + o.Value);

                    SqlConnection database = GetDBConnection();
                    SqlCommand command = null;

                    try
                    {
                        command = new SqlCommand("INSERT INTO tblInjuryData (tblLoginID, injury_location, injury_comment, injury_date)"
                                                          + "VALUES (" + loginID + ", " + getInjuryID(o.Key) + ", @injury, CURRENT_TIMESTAMP)"
                                                           , database);


                        command.Parameters.AddWithValue("@injury", o.Value);
                        command.Connection.Open();
                        SqlDataReader reader;
                        if(getInjuryID(o.Key) != 0)
                            reader = command.ExecuteReader(System.Data.CommandBehavior.Default);

                    }
                    catch (SqlException e)
                    {
                        System.Diagnostics.Debug.WriteLine(e.Message);
                        message = e.Message;
                        result = false;
                        message = e.Message;
                        return false;
                    }
                    finally
                    {
                        if (command.Connection.State == ConnectionState.Open)
                        { command.Connection.Close(); }
                    }

                }
                message = "Success!";
            }

            return result;
        }


        public static int getInjuryID(string bodyPart)
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