using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RIPPEDD
{
    public partial class HealthProfessionals : System.Web.UI.Page
    {
        public static string typeProvider;
        public static string city;
        public static string state;
        public static string zip;
        public static string query;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            // 
            city = txtBoxCity.Text;
            state = txtBoxState.Text;
            zip = txtBoxZip.Text;
            query = typeProvider + " " + city + " " + " " + state + " " + zip;
            TestSubmit();
        }

        protected void dropDownListHC_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeProvider = dropDownListHealthCareType.SelectedItem.ToString();
            TestDropDown(); // test if getting the text from the DropDownList
        }

        private void TestDropDown()
        {
            System.Diagnostics.Debug.WriteLine(typeProvider);
        }

        private void TestSubmit()
        {
            System.Diagnostics.Debug.WriteLine(query);
        }
    }
}