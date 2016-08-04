using Framework.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Framework;

namespace TestsForFramework
{

    public class GmailTests
    {
        LogoutPageSteps logoutPage = new LogoutPageSteps();
        LoginPageSteps loginPage = new LoginPageSteps();
        MainPageSteps mainPage = new MainPageSteps();

        [SetUp]
        public void BeforeTest()
        {
            loginPage.Open();
        }


     //   [Ignore("dd")]
        [Test]
        public void CheckTheSpam()
        {
            IpHandler hand = new IpHandler();

          //  LoginPageSteps loginPage = new LoginPageSteps();
            //      loginPage.LogIn();
            loginPage.Authorize("user1.tat13@gmail.com", "257646667");

            MailBoxPageSteps mailPage = new MailBoxPageSteps();
            mailPage.WriteMessage("user2.tat13@gmail.com", "for spam1", "Spam.123" + hand.GetIp());
          //  LogoutPageSteps logout = new LogoutPageSteps();
            logoutPage.CommonExit();
            loginPage.Authorize("user2.tat13@gmail.com", "257646667");
         //   MainPageSteps mainPage = new MainPageSteps();
            mainPage.AddToSpam();
            logoutPage.CommonExit();
            loginPage.Authorize("user1.tat13@gmail.com", "257646667");
            mailPage.WriteMessage("user2.tat13@gmail.com", "for spam2", "Spam.456");
            logoutPage.CommonExit();
            loginPage.Authorize("user2.tat13@gmail.com", "257646667");
            mainPage.GoToSpam();
            SpamPageSteps spamPage = new SpamPageSteps();
            spamPage.CheckSpam();
            Assert.AreEqual("for spam2", spamPage.topic);
         //   logout.CommonExit();

        }
//
     //   [Ignore("dd")]
        [Test]
        [STAThreadAttribute]
        public void CheckForwardingOfMessages()
        {
           // LoginPageSteps loginPage = new LoginPageSteps();
          //  LogoutPageSteps logoutPage = new LogoutPageSteps();
            SettingPageSteps settPage = new SettingPageSteps();
          //  MainPageSteps mainPage = new MainPageSteps();
            SettingPageSteps sett = new SettingPageSteps();
            ForwardPageSteps forwardPage = new ForwardPageSteps();
            FormOfForwardPageSteps formPage = new FormOfForwardPageSteps();

            //     loginPage.LogIn();
            loginPage.Authorize("user2.tat13@gmail.com", "257646667");

            mainPage.GoToSettings();
            settPage.GoToForward();
            forwardPage.SetForward("user3.tat13@gmail.com");

            logoutPage.CommonExit();
            loginPage.Authorize("user3.tat13@gmail.com", "257646667");
            mainPage.OpenLetter();
            LetterPageSteps letter = new LetterPageSteps();
            letter.GoByLinkToConfirm();
            logoutPage.CommonExit();

            loginPage.Authorize("user2.tat13@gmail.com", "257646667");
            mainPage.GoToSettings();
            settPage.GoToForward();
            forwardPage.CreateFilter();
            mainPage.GoToSettings();
            settPage.GoToForward();

            forwardPage.AddFilter();
            formPage.ConfirmForward("user1.tat13@gmail.com");

            logoutPage.CommonExit();
            loginPage.Authorize("user1.tat13@gmail.com", "257646667");

            MailBoxPageSteps mess = new MailBoxPageSteps();
            mess.WriteMessageWithAttach("user2.tat13@gmail.com", "With attach", "attach", @"C:\Users\Katsiaryna_Dailid\Documents\1.txt");
            mess.WriteMessage("user2.tat13@gmail.com", "Without attach", "There is no attachment here.");
            logoutPage.CommonExit();
            loginPage.Authorize("user2.tat13@gmail.com", "257646667");
            Assert.True(mainPage.CheckUserInInbox());
            Assert.False(mainPage.CheckLabel());

            mainPage.GoToBin();
            BinPageSteps binPage = new BinPageSteps();
            Assert.True(binPage.CheckLabelInBin());
            Assert.True(binPage.CheckUserInBin());

            logoutPage.CommonExit();
            loginPage.Authorize("user3.tat13@gmail.com", "257646667");
            Assert.True(mainPage.CheckUserInInbox());
            Assert.False(mainPage.CheckLabel());
            //************
            logoutPage.CommonExit();
            loginPage.Authorize("user2.tat13@gmail.com", "257646667");
            mainPage.GoToSettings();
            settPage.GoToForward();
            forwardPage.RemoveFilter();
           // logoutPage.CommonExit();
            //***********



        }

        [Test]//1
        public void CheckAddToSpamAndDeleteFromSpamFunctions()
        {           
            MailBoxPageSteps mailPage = new MailBoxPageSteps();
            SpamPageSteps spamPage = new SpamPageSteps();

            loginPage.Authorize("user1.tat13@gmail.com", "257646667");
            mailPage.WriteMessage("user2.tat13@gmail.com", "for spam", "Spam");
            logoutPage.CommonExit();
            loginPage.Authorize("user2.tat13@gmail.com", "257646667");
            mainPage.AddToSpam();
            mainPage.GoToSpam();
            spamPage.DeleteFromSpam();
            Assert.True(mainPage.CheckTopicInInbox("for spam"));
            
        }

      //  [Ignore("wrgwerg")]
        [Test]
        [STAThreadAttribute]
        public void ErrorWhileTryingToAttachBigFile()
        {
            MailBoxPageSteps mess = new MailBoxPageSteps();
            ErrorSteps errPage = new ErrorSteps();

            loginPage.Authorize("user1.tat13@gmail.com", "257646667");
            mess.WriteMessageWithAttach("user2.tat13@gmail.com", "With attach", "attach", @"C:\Users\Katsiaryna_Dailid\Downloads\001_1.zip");
            Assert.True(errPage.ThereIsAnErrorMessage());
            //*************************
            errPage.CloseErrorMessage();
            //*************************
        }

        //[Ignore("wrgwerg")]
        [Test]
        [STAThreadAttribute]
        public void ErrorWhileTryingToAttachFileWithNotImageExtension()
        {                   
            ThemesPageSteps themePage = new ThemesPageSteps();
            SettingPageSteps settPage = new SettingPageSteps();

            loginPage.Authorize("user1.tat13@gmail.com", "257646667");
            mainPage.GoToSettings();
            settPage.GoToThemesPage();
            themePage.SetTheme();
            themePage.AddFileToThemes(@"C:\Users\Katsiaryna_Dailid\Downloads\001_1.zip");
            Assert.True(themePage.WrongExtensionError());
            //****************
            themePage.CloseWindows();
            //****************
        }

      //  [Ignore("wrgwerg")]
        [Test] //2
        public void CheckSendingEmoticons()
        {           
            MailBoxPageSteps mailPage = new MailBoxPageSteps();
            LetterPageSteps letterPage = new LetterPageSteps();

            loginPage.Authorize("user3.tat13@gmail.com", "257646667");
            mailPage.AddEmoticons("user2.tat13@gmail.com", "emoticons", "Hi!");
            logoutPage.CommonExit();
            loginPage.Authorize("user2.tat13@gmail.com", "257646667");
            mainPage.OpenLetter();
            Assert.True(letterPage.ConfirmEmoticons());
        }

      //  [Ignore("wrgwerg")]
        [Test]
        public void CheckStarredAndNotStarredFunction()
        {           
            MailBoxPageSteps mailPage = new MailBoxPageSteps();
            StarredPageSteps starredPage = new StarredPageSteps();
      
            loginPage.Authorize("user2.tat13@gmail.com", "257646667");
            mailPage.WriteMessage("user3.tat13@gmail.com", "For starred", "XO");
            logoutPage.CommonExit();
            loginPage.Authorize("user3.tat13@gmail.com", "257646667");
            Assert.True(mainPage.CheckIfItIsStarred());
            mainPage.GoToStarred();
            Assert.True(starredPage.CheckIfItIsStarredPage("https://mail.google.com/mail/u/0/#starred"));
            Assert.True(starredPage.CheckTheTopic("For starred"));           
        }



        [TearDown]
        public void AfterTest()
        {
            //logoutPage.CommonExit();
            //loginPage.Authorize("user1.tat13@gmail.com", "257646667");
            //mainPage.CleanUpAllLettersAfterTest();
            //logoutPage.CommonExit();
            //loginPage.Authorize("user2.tat13@gmail.com", "257646667");
            //mainPage.CleanUpAllLettersAfterTest();
            //logoutPage.CommonExit();
            //loginPage.Authorize("user3.tat13@gmail.com", "257646667");
            //mainPage.CleanUpAllLettersAfterTest();
            loginPage.Close();   
        }

     
    }
}
