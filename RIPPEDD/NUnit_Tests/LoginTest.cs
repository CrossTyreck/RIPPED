/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace RIPPEDD.NUnit_Tests

{
    /// <summary>
    /// Christopher Owen Hamilton's LoginAuthentication testing. 
    /// </summary>
   [TestFixture]
    public class LoginTest
    {
     [Test]
        public void LoginAuthenticationFalse()
        {
         Entities.User user = new Entities.User("sodkj", "CHRasdIS");
         Entities.User retUser;
         Dictionary<string, string> dictUser = new Dictionary<string,string>();
         Controllers.DatabaseGateway  gateway = new Controllers.DatabaseGateway();
         string info;
         int id = gateway.SelectUser("tblUser", user.CreateDict(), out retUser);
             Controllers.LoginController testLoginController = new Controllers.LoginController();
            Assert.False(testLoginController.LoginAuthentication(user, out id, out retUser, out info));
  
        }

     [Test]
     public void LoginAuthenticationTrue()
     {
         Entities.User user = new Entities.User("chris", "CHRIS");
         Entities.User retUser;
         Dictionary<string, string> dictUser = new Dictionary<string, string>();
         Controllers.DatabaseGateway gateway = new Controllers.DatabaseGateway();
         string info;
         int id = gateway.SelectUser("tblUser", user.CreateDict(), out retUser);
         Controllers.LoginController testLoginController = new Controllers.LoginController();
       
         Assert.True(testLoginController.LoginAuthentication(user, out id, out retUser, out info));
        
         Assert.IsNotEmpty(info);
         Assert.IsNotNull(retUser);
     }

       [Test]
        public void LoginAuthenticationErrorMessage()
        {
            Entities.User user = new Entities.User("chris", "CHRIS");
            Entities.User retUser;
            Dictionary<string, string> dictUser = new Dictionary<string, string>();
            Controllers.DatabaseGateway gateway = new Controllers.DatabaseGateway();
            string info;
            int id = gateway.SelectUser("tblUser", user.CreateDict(), out retUser);
            Controllers.LoginController testLoginController = new Controllers.LoginController();

            bool test = testLoginController.LoginAuthentication(user, out id, out retUser, out info);
            Assert.IsNotEmpty(info);
        }
    }
}
*/
 

 

 


 

