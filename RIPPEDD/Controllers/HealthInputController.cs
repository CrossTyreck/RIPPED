using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RIPPEDD.Controllers
{
    public class HealthInputController
    {

        public void testConnection()
        {

        }
        ///<summary>
        /// Function: to test whether or not the string inputs are either empty or numeric
        /// If alphabetical or non-numeric characters exist, send false. The webpage will then
        /// take care to send an error message to the user prompting them to input again
        /// If the input is valid, open a new database connection to place the strings into the table
        /// <summary>
        public bool inputCardioWorkout(string roadRunning, string treadmill, string cycling, string swimming, string walking, string rowing)
        {
            string[] testing = {roadRunning, treadmill, cycling, swimming, walking, rowing };
            double numTest = 0;

            for (int i = 0; i < testing.Length; ++i)
            {
                //If the string at the index i is not a numeric string
                if( !(Double.TryParse(testing[i], out numTest)) )
                {
                     return false;
                }
            }
           

            //DATABASE OBJECT CALLS HERE
            
            return true;
        }

        public bool inputStrengthWorkout(string climbing, string boxing, string pushups, string situps, string workout)
        {
            string[] testing = { climbing, boxing, pushups, situps };
            double numTest = 0;

            for (int i = 0; i < testing.Length; ++i)
            {
                //If the string at the index i is not a numeric string
                if ( !(Double.TryParse(testing[i], out numTest)))
                {
                    return false;
                }
            }

            //DATABASE OBJECT CALLS HERE

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

            //DATABASE OBJECT CALLS HERE
            
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

            //DATABASE OBJECT CALLS HERE

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

            //DATABASE OBJECT CALLS HERE
            
            return true;
        }

        public bool inputInjury(string bodyPart, string injury)
        {
            

            return true;
        }


    }
}