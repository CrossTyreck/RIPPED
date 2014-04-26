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
        private static int injuryCount = 0;
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

            this.pnlInjuryList.Controls.Add(new LiteralControl("<br />"));
            //Session["pnlInjuryList"] = pnlInjuryList;
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
            //Session["pnlInjuryList"] = 
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
                pnlTest = new InjuryMiniPanel(injuryCount, imageMapClick);
                pnlTest.ID = "pnlInjury_" + injuryCount;
                panelList.Add(pnlTest);
                injuryCount++;
                //this.refreshList();
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
                        injuryCount--;
                        //this.Page_Load(sender, e);
                        break;
                    }
                }
            }

            this.Page_Load(sender, e);
        }

        protected void btnSubmitResults_Click(object sender, EventArgs e)
        {
            //http://stackoverflow.com/questions/13362904/convert-control-to-textbox-and-assign-it-a-value
            //foreach (TextBox txtBox in this.Controls)
            //{

            //    if (txtBox.Visible && txtBox.Text.Length > 0)
            //    {
            //        float dControl;
            //        float.TryParse(txtBox.Text, NumberStyles.Currency, NumberFormatInfo.InvariantInfo, out dControl);

            //        HealthInputSessionVariables.Activity.Add(txtBox.ID.Remove(0, 3), dControl);
            //    }
            //}

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



































