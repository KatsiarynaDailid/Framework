using Framework.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Framework.Tests
{
   public  class GmailTests
    {

        [Ignore("dd")]
        [Test]
        public void CheckTheSpam()
        {
            IpHandler hand = new IpHandler();
           
           LoginPageSteps loginPage = new LoginPageSteps();
            loginPage.LogIn();
            loginPage.Authorize("user1.tat13@gmail.com", "257646667");

            MailBoxPageSteps mailPage = new MailBoxPageSteps();
            mailPage.WriteMessage("user2.tat13@gmail.com", "for spam1", "Spam.123" + hand.GetIp());
            LogoutPageSteps logout = new LogoutPageSteps();
            logout.CommonExit();
            loginPage.Authorize("user2.tat13@gmail.com", "257646667");
            MainPageSteps mainPage = new MainPageSteps();
            mainPage.AddToSpam();
            logout.CommonExit();
            loginPage.Authorize("user1.tat13@gmail.com", "257646667");
            mailPage.WriteMessage("user2.tat13@gmail.com", "for spam2", "Spam.456");
            logout.CommonExit();
            loginPage.Authorize("user2.tat13@gmail.com", "257646667");
            mainPage.GoToSpam();
            SpamPageSteps spamPage = new SpamPageSteps();
            spamPage.CheckSpam();         
            Assert.AreEqual("for spam2", spamPage.topic);
            logout.CommonExit();

        }

        [Ignore("dd")]
        [Test]
        [STAThreadAttribute]
        public void CheckForwardingOfMessages()
        {
            LoginPageSteps loginPage = new LoginPageSteps();
            LogoutPageSteps logoutPage = new LogoutPageSteps();
            SettingPageSteps settPage = new SettingPageSteps();
            MainPageSteps mainPage = new MainPageSteps();
            SettingPageSteps sett = new SettingPageSteps();
            ForwardPageSteps forwardPage = new ForwardPageSteps();
            FormOfForwardPageSteps formPage = new FormOfForwardPageSteps();

            loginPage.LogIn();
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
            logoutPage.CommonExit();
            //***********

             

        }



        [Ignore("dd")]
        [Test]
        [STAThreadAttribute]
        public void ErrorWhileTryingToAttachBigFile()
        {
            LogoutPageSteps logoutPage = new LogoutPageSteps();
            LoginPageSteps loginPage = new LoginPageSteps();
            MailBoxPageSteps mess = new MailBoxPageSteps();
            ErrorSteps errPage = new ErrorSteps();

            loginPage.LogIn();
            loginPage.Authorize("user1.tat13@gmail.com", "257646667");
            mess.WriteMessageWithAttach("user2.tat13@gmail.com", "With attach", "attach", @"C:\Users\Katsiaryna_Dailid\Downloads\001_1.zip");         
            Assert.True(errPage.ThereIsAnErrorMessage());
            //*************************
            errPage.CloseErrorMessage();
            logoutPage.CommonExit();
            //*************************
        }

        [Ignore("dd")]
        [Test]
        [STAThreadAttribute]
        public void ErrorWhileTryingToAttachFileWithNotImageExtension()
        {
            LogoutPageSteps logoutPage = new LogoutPageSteps();
            LoginPageSteps loginPage = new LoginPageSteps();
            MainPageSteps mainPage = new MainPageSteps();
            ThemesPageSteps themePage = new ThemesPageSteps();
            SettingPageSteps settPage = new SettingPageSteps();

            loginPage.LogIn();
            loginPage.Authorize("user1.tat13@gmail.com", "257646667");
            mainPage.GoToSettings();
            settPage.GoToThemesPage();
            themePage.SetTheme();
            themePage.AddFileToThemes(@"C:\Users\Katsiaryna_Dailid\Downloads\001_1.zip");
            Assert.True(themePage.WrongExtensionError());
            //****************
            themePage.CloseWindows();
            logoutPage.CommonExit();
            //****************
        }


        [Ignore("dd")]
        [Test]
        [STAThreadAttribute]
        public void CheckSendingEmoticons()
        {
            LoginPageSteps loginPage = new LoginPageSteps();
            LogoutPageSteps logoutPage = new LogoutPageSteps();
            MainPageSteps mainPage = new MainPageSteps();      
            MailBoxPageSteps mailPage = new MailBoxPageSteps();
            LetterPageSteps letterPage = new LetterPageSteps();

            loginPage.LogIn();
            loginPage.Authorize("user3.tat13@gmail.com", "257646667");
            mailPage.AddEmoticons("user2.tat13@gmail.com", "emoticons", "Hi!");
            logoutPage.CommonExit();
            loginPage.Authorize("user2.tat13@gmail.com", "257646667");
            mainPage.OpenLetter();
            Assert.True(letterPage.ConfirmEmoticons());
            logoutPage.CommonExit();
        }



          [Ignore("dd")]
        [Test]
        [STAThreadAttribute]
        public void CheckStarredAndNotStarredFunction()
        {
            LoginPageSteps loginPage = new LoginPageSteps();
            LogoutPageSteps logoutPage = new LogoutPageSteps();
            MainPageSteps mainPage = new MainPageSteps();      
            MailBoxPageSteps mailPage = new MailBoxPageSteps();      
            StarredPageSteps starredPage = new StarredPageSteps();


            loginPage.LogIn();
            loginPage.Authorize("user2.tat13@gmail.com", "257646667");
            mailPage.WriteMessage("user3.tat13@gmail.com", "For starred", "XO");
            logoutPage.CommonExit();
            loginPage.Authorize("user3.tat13@gmail.com", "257646667");
            Assert.True(mainPage.CheckIfItIsStarred());
            mainPage.GoToStarred();
            Assert.True(starredPage.CheckIfItIsStarredPage("https://mail.google.com/mail/u/0/#starred"));
            Assert.True(starredPage.CheckTheTopic("For starred"));
            logoutPage.CommonExit();
        }

           [Ignore("dd")]
        [Test]
        public void CheckAddToSpamAndDeleteFromSpamFunctions()
        {
            LoginPageSteps loginPage = new LoginPageSteps();
            LogoutPageSteps logoutPage = new LogoutPageSteps();
            MainPageSteps mainPage = new MainPageSteps();
            MailBoxPageSteps mailPage = new MailBoxPageSteps();
            SpamPageSteps spamPage = new SpamPageSteps();


            loginPage.LogIn();
            loginPage.Authorize("user1.tat13@gmail.com", "257646667");
            mailPage.WriteMessage("user2.tat13@gmail.com", "for spam", "Spam");
            logoutPage.CommonExit();
            loginPage.Authorize("user2.tat13@gmail.com", "257646667");
            mainPage.AddToSpam();
            mainPage.GoToSpam();
            spamPage.DeleteFromSpam();
            Assert.True(mainPage.CheckTopicInInbox("for spam"));
            logoutPage.CommonExit();
        }
    }
}
