using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Collections;
using RIPPEDD.Health_Input;
using RIPPEDD.Controllers;
using RIPPEDD.Entities;


namespace RIPPEDD
{
    public partial class HealthInput : System.Web.UI.Page
    {
       
        private static string imageMapClick;
        private InjuryMiniPanel pnlTest;
        private static ArrayList injurylist = new ArrayList();
        private static ArrayList panelList = new ArrayList();
        private static Dictionary<string, string> injuryComments = new Dictionary<string, string>();
   
        private int userID;

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            WorkoutChoices_Initialize();

          //Needs to be in the login function

            try
            {
                userID = ((SessionData)Session["User_Data"])._loginID;        
            }
            catch (NullReferenceException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                Response.Redirect("Login.aspx");
            }

            lblSubmissionInfo.Visible = false;

            if (ddlWorkoutChoices.Items.Count < 1)
            {
                foreach (View view in WorkoutChoices.Views)
                {
                    ddlWorkoutChoices.Items.Add(view.ID.ToString());
                }
            }         
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                System.Diagnostics.Debug.WriteLine("not postback");
                
            }
            else
            {
                refreshList();
                System.Diagnostics.Debug.WriteLine("postback");
            }

        }

        private void refreshList()
        {
           
            foreach (InjuryMiniPanel o in panelList)
            {
                pnlInjuryList.Controls.Add(o);
            }
        }

        protected void WorkoutChoices_Initialize()
        {
            foreach (View view in WorkoutChoices.Views)
            {
                if (view.ID.ToString().Equals("Welcome"))
                {
                    WorkoutChoices.SetActiveView(view);
                }
            }
        }

        protected void WorkoutChoices_SetView(object sender, EventArgs e)
        {
            foreach (View view in WorkoutChoices.Views)
            {
                if (view.ID.ToString().Equals(ddlWorkoutChoices.Text))
                {
                    WorkoutChoices.SetActiveView(view);
                }
            }

        }

        protected void SetInjury(object sender, ImageMapEventArgs e)
        {
                
            imageMapClick = e.PostBackValue;


            if (!injurylist.Contains(imageMapClick))
            {
                injurylist.Add(imageMapClick);
                pnlTest = new InjuryMiniPanel((int)Session["Control_Increment"], imageMapClick);
                pnlTest.ID = "pnlInjury_" + ((int)Session["Control_Increment"]);
                panelList.Add(pnlTest);
                Session["Control_Increment"] = ((int) Session["Control_Increment"]) + 1;
                
            }
            else
            {
                injurylist.Remove(imageMapClick);
                foreach (InjuryMiniPanel o in panelList)
                {
                    if (o.Name.Equals(imageMapClick))
                    {
                        pnlInjuryList.Controls.Remove(o);
                        panelList.Remove(o);
                        break;
                    }
                }
            }

            this.Page_Load(sender, e);
        }

        protected void btnTestPrint_Click(object sender, EventArgs e)
        {
            string script = "alert(\"Success!\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);
        }


        protected void btnSubmitResults_Click(object sender, EventArgs e)
        {
           
            System.Diagnostics.Debug.WriteLine("Click test");
            //System.Diagnostics.Debug.WriteLine(WorkoutChoices.GetActiveView().ToString());

            // string current = WorkoutChoices.GetActiveView().ID.ToString();

            HealthInputController controller = new HealthInputController(userID);
            string message = "";
            bool callPassed = true;

            switch (WorkoutChoices.GetActiveView().ID.ToString())
            {

                case "Welcome":
                    System.Diagnostics.Debug.WriteLine("1");
                    break;

                case "CardioWorkout":

                    callPassed = controller.inputCardioWorkout(txtRoadRunning.Text, txtTreadmill.Text, txtCycling.Text, txtSwimming.Text, txtWalking.Text, txtRowing.Text, out message);
                    if (callPassed)
                    {
                        //Input is valid
                        string script = "alert(\"Success!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);
                    }
                    else
                    {
                        //Input invalid
                        System.Diagnostics.Debug.WriteLine(message);

                        string script = "alert(\""+ message + "\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);
                    }



                    System.Diagnostics.Debug.WriteLine("2");
                    break;

                case "StrengthWorkout":

                    callPassed = controller.inputStrengthWorkout(txtClimbing.Text, txtBoxing.Text, txtPushups.Text, txtSitups.Text, txtWorkoutRoutine.Text, out message);
                    if (callPassed)
                    {
                        //Input is valid
                        string script = "alert(\"Success!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);
                    }
                    else
                    {
                        //Input invalid
                        System.Diagnostics.Debug.WriteLine(message);

                        string script = "alert(\"" + message + "\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);
                    }

                    System.Diagnostics.Debug.WriteLine("3");
                    break;

                case "WorkActivities":

                    callPassed = controller.inputWorkActivities(txtComputerTime.Text, txtBreaksPerHour.Text, txtLunchTime.Text, txtWorkTime.Text, txtMeetingTime.Text, out message);
                    if (callPassed)
                    {
                        //Input is valid
                        string script = "alert(\"Success!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);
                    }
                    else
                    {
                        //Input invalid
                        System.Diagnostics.Debug.WriteLine(message);

                        string script = "alert(\"" + message + "\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);
                    }

                    System.Diagnostics.Debug.WriteLine("4");
                    break;


                case "HealthIndicators":

                    callPassed = controller.inputHealthIndicators(txtWeight.Text, txtBMI.Text, txtSittingHeartRate.Text, txtWorkingHeartRate.Text, txtHeight.Text, txtSleep.Text, out message);
                    if (callPassed)
                    {
                        //Input is valid
                        string script = "alert(\"Success!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);
                    }
                    else
                    {
                        //Input invalid
                        System.Diagnostics.Debug.WriteLine(message);

                        string script = "alert(\"" + message + "\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);
                    }


                    System.Diagnostics.Debug.WriteLine("5");
                    break;

                case "CouchPotato":

                    callPassed = controller.inputCouchPotato(txtComputerTimeHome.Text, txtTelevision.Text, txtChores.Text, out message);
                    if (callPassed)
                    {
                        //Input is valid
                        string script = "alert(\"Success!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);
                    }
                    else
                    {
                        //Input invalid
                        System.Diagnostics.Debug.WriteLine(message);

                        string script = "alert(\"" + message + "\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);
                    }

                    System.Diagnostics.Debug.WriteLine("6");
                    break;

                case "Injuries":

                    if (panelList.Count == 0)
                    {
                        string script = "alert(\"You have not clicked on any part!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                                "ServerControlScript", script, true);
                    }
                    else
                    {
                        foreach (InjuryMiniPanel o in panelList)
                        {
                            injuryComments.Add(o.Name, o.txtInjury.Text);
                        }

                        callPassed = controller.inputInjury(injuryComments, out message);
                        if (callPassed)
                        {
                            //Input is valid
                            string script = "alert(\"Success!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(),
                                                    "ServerControlScript", script, true);
                            pnlInjuryList.Controls.Clear();
                            panelList.Clear();
                            injurylist.Clear();
                        }
                        else
                        {
                            //Input invalid
                            System.Diagnostics.Debug.WriteLine(message);

                            string script = "alert(\"" + message + "\");";
                            ScriptManager.RegisterStartupScript(this, GetType(),
                                                    "ServerControlScript", script, true);
                        }

                        
                    }
                    injuryComments.Clear();
                    refreshList();
                   
                    System.Diagnostics.Debug.WriteLine("7");
                    break;

            }

            //Response.Redirect("HealthInputReport.aspx");
            controller = null;
            GC.Collect();

        }


    }
}



































