using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using RIPPEDD.Controllers;
using RIPPEDD.Entities;

namespace RIPPEDD
{
    public partial class Welcome : System.Web.UI.Page
    {
        WelcomeController dbObject = new WelcomeController();

        protected void Page_Load(object sender, System.EventArgs e)
        {

            NumberOfActivitesByDate.Series["ActivitiesSeries1"].YValueMembers = "# of Activities";
            NumberOfActivitesByDate.Series["ActivitiesSeries1"].XValueMember = "# of Weeks";

            try
            {
                NumberOfActivitesByDate.DataSource = dbObject.GetData(((SessionData)Session["User_Data"])._loginID, 1);
                DataTable BMITable = dbObject.GetData(((SessionData)Session["User_Data"])._loginID, 2);
                //DataTable SittingHRTable = dbObject.GetData(((SessionData)Session["User_Data"])._loginID, 3);
                foreach (DataRow row in BMITable.Rows)
                {
                    HealthIndicators.Series["IndicatorSeries1"].Points.AddY(row[0]);
                }
                //foreach (DataRow row in SittingHRTable.Rows)
                //{
                //    HealthIndicators.Series["IndicatorSeries2"].Points.AddY(row[0]);
                //}
            }
            catch (NullReferenceException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                Response.Redirect("Login.aspx");
            }

            NumberOfActivitesByDate.DataBind();

            HealthIndicators.ChartAreas["IndicatorsChartArea"].Area3DStyle.Enable3D = true;
            HealthIndicators.Series["IndicatorSeries1"].BorderWidth = 3;
   

        }

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    

		}
		#endregion

        protected void InputHealth_Click(object sender, EventArgs e)
        {
            Response.Redirect("HealthInput.aspx");
        }

        protected void HealthProfessionals_Click(object sender, EventArgs e)
        {
            Response.Redirect("HealthProfessionals.aspx");
        }

        protected void GenerateHealthReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("HealthInputReport.aspx");
        }


    }
}