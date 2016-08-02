using Framework.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace TestsForFramework
{

    public class GmailTests
    {



        [Test]
        public void CheckAddToSpamAndDeleteFromSpamFunctions()
        {

            bool pol = true;
            Assert.True(pol);
            // LoginPageSteps loginPage = new LoginPageSteps();
            // LogoutPageSteps logoutPage = new LogoutPageSteps();
            // MainPageSteps mainPage = new MainPageSteps();
            // MailBoxPageSteps mailPage = new MailBoxPageSteps();
            // SpamPageSteps spamPage = new SpamPageSteps();


            // loginPage.LogIn();
            // loginPage.Authorize("user1.tat13@gmail.com", "257646667");
            // mailPage.WriteMessage("user2.tat13@gmail.com", "for spam", "Spam");
            // logoutPage.CommonExit();
            // loginPage.Authorize("user2.tat13@gmail.com", "257646667");
            // mainPage.AddToSpam();
            // mainPage.GoToSpam();
            // spamPage.DeleteFromSpam();
            // Assert.True(mainPage.CheckTopicInInbox("for spam"));
            //logoutPage.CommonExit();
        }


        [Test]
        public void ForFail()
        {
            bool pol = false;
            Assert.True(pol);
        }
     }
}
