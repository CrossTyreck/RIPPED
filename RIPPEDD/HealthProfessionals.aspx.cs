using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using Newtonsoft.Json;
using RIPPEDD.Entities;

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
            // get information from text boxes
            city = txtBoxCity.Text;
            state = txtBoxState.Text;
            zip = txtBoxZip.Text;
            string location = city + ", " + state + " " + zip;
            string defaultSettings = "https://www.google.com/maps/embed/v1/view?key=AIzaSyAmraGWkXFKyVgd_pna2BjAnlXJ_iRsOWo&center=33.4294,-111.9431&zoom=13&maptype=roadmap";
            WebClient wc = new WebClient();

            // retrieve list of places for search and save results in object gpr
            string jsonStr = wc.DownloadString("https://maps.googleapis.com/maps/api/place/textsearch/json?query=" + typeProvider + "in " + location + "&sensor=true&key=AIzaSyAmraGWkXFKyVgd_pna2BjAnlXJ_iRsOWo&q");
            GooglePlacesParser gpr = (GooglePlacesParser)JsonConvert.DeserializeObject<GooglePlacesParser>(jsonStr);

            if (((isTypeProviderEmpty()) && (isCityEmpty()) && (isStateEmpty())) || ((isTypeProviderEmpty()) && (isZipEmpty())))
            {
                if (gpr.status != "OK")
                {
                    // return an error that no results were found
                    System.Diagnostics.Debug.WriteLine(gpr.status);
                    MessageBox(gpr.status);
                    // show default map
                    gmap.Attributes.Add("src", defaultSettings);
                }
                else
                {
                    query = "https://www.google.com/maps/embed/v1/search?key=AIzaSyAmraGWkXFKyVgd_pna2BjAnlXJ_iRsOWo&q=";
                    query = query + typeProvider + " " + location + "&zoom=10&maptype=roadmap";
                    gmap.Attributes.Add("src", query);
                }
            }
            else
            {
                // find out which one is empty and post appropriate message
                // show default map
                gmap.Attributes.Add("src", defaultSettings);
            }
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
        private void TestGpr()
        {
            // test if gpr is retaining data  
        }
        private bool isTypeProviderEmpty()
        {
            if (typeProvider.Length != 0)
                return true;
            else
                return false;
        }
        private bool isCityEmpty()
        {
            if (city.Length != 0)
                return true;
            else
                return false;
        }
        private bool isStateEmpty()
        {
            if (state.Length != 0)
                return true;
            else
                return false;
        }
        // checks if zipcode is empty or not, also checks if it is only numeric
        private bool isZipEmpty()
        {
            if (zip.Length != 0)
            {
                foreach (char c in zip)
                {
                        if (c < '0' || c > '9')
                            return false;
                        else
                            return true;
                }
            }
            return false;
        }
        private void MessageBox(string msg)
       {
        Label lbl = new Label();
        lbl.Text = "<script language='javascript'>" + Environment.NewLine + "window.alert('" + msg + "')</script>";
        Page.Controls.Add(lbl);
       }
    }
}
