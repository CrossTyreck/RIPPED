using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RIPPEDD.Entities
{
    public class GooglePlacesParser
    {
        public string status { get; set; }
        public results[] results { get; set; }
    }
    public class results
    {
        public geometry geometry { get; set; }
        public string name { get; set; }
        public string formatted_address { get; set; }
        //public string reference { get; set; }
        //public string vicinity { get; set; }
    }
    public class geometry
    {
        public location location { get; set; }
    }
    public class location
    {
        public string lat { get; set; }
        public string lng { get; set; }
    }
}