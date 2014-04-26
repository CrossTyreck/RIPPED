using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RIPPEDD.Controllers;
using RIPPEDD.Entities;


namespace RIPPEDD.Controllers
{
    public class InjuryListController : DatabaseGateway
    {
        Dictionary<string, string> injuryList;

        public InjuryListController(Dictionary<string, string> pList) 
        {

            //copy the dictionary into new memory just in case
            injuryList = new Dictionary<string, string>(pList);


        }

        public bool processInjuries(out string message)
        {
            bool result = true;
            message = "";

            foreach (KeyValuePair<string, string> entry in injuryList)
            {

            }


            if (result == true)
            {
                message = "Sucess!";
                //database call here
            }

            return result;
        }
             


    }
}