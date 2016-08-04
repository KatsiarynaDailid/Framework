using Framework.Steps;
using System;
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
            MailBoxPageSteps mailPage = new MailBoxPageSteps();
            SpamPageSteps spamPage = new SpamPageSteps();

            loginPage.Authorize(Data.user1, Data.password);
            mailPage.WriteMessage(Data.user2, "for spam1", "Spam.123" + hand.GetIp(Data.ip));
            logoutPage.CommonExit();
            loginPage.Authorize(Data.user2, Data.password);
            mainPage.AddToSpam();
            logoutPage.CommonExit();
            loginPage.Authorize(Data.user1, Data.password);
            mailPage.WriteMessage(Data.user2, "for spam2", "Spam.456");
            logoutPage.CommonExit();
            loginPage.Authorize(Data.user2, Data.password);
            mainPage.GoToSpam();
            spamPage.CheckSpam();
            Assert.AreEqual("for spam2", spamPage.topic);
        }


        [Test]//1
        public void CheckAddToSpamAndDeleteFromSpamFunctions()
        {           
            MailBoxPageSteps mailPage = new MailBoxPageSteps();
            SpamPageSteps spamPage = new SpamPageSteps();

            loginPage.Authorize(Data.user1, Data.password);
            mailPage.WriteMessage(Data.user2, "for spam", "Spam");
            logoutPage.CommonExit();
            loginPage.Authorize(Data.user2, Data.password);
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
            string path = TestContext.CurrentContext.TestDirectory;
            loginPage.Authorize(Data.user1, Data.password);
            mess.WriteMessageWithAttach(Data.user2, "With attach", "attach",path+Data.bigFile);
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
            string path = TestContext.CurrentContext.TestDirectory;
            ThemesPageSteps themePage = new ThemesPageSteps();
            SettingPageSteps settPage = new SettingPageSteps();

            loginPage.Authorize(Data.user1, Data.password);
            mainPage.GoToSettings();
            settPage.GoToThemesPage();
            themePage.SetTheme();
            themePage.AddFileToThemes(path+Data.notImgFile);
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

            loginPage.Authorize(Data.user3, Data.password);
            mailPage.AddEmoticons(Data.user2, "emoticons", "Hi!");
            logoutPage.CommonExit();
            loginPage.Authorize(Data.user2, Data.password);
            mainPage.OpenLetter();
            Assert.True(letterPage.ConfirmEmoticons());
        }

      //  [Ignore("wrgwerg")]
        [Test]
        public void CheckStarredAndNotStarredFunction()
        {           
            MailBoxPageSteps mailPage = new MailBoxPageSteps();
            StarredPageSteps starredPage = new StarredPageSteps();
      
            loginPage.Authorize(Data.user2, Data.password);
            mailPage.WriteMessage(Data.user3, "For starred", "XO");
            logoutPage.CommonExit();
            loginPage.Authorize(Data.user3, Data.password);
            Assert.True(mainPage.CheckIfItIsStarred());
            mainPage.GoToStarred();
            Assert.True(starredPage.CheckIfItIsStarredPage("https://mail.google.com/mail/u/0/#starred"));
            Assert.True(starredPage.CheckTheTopic("For starred"));           
        }



        [TearDown]
        public void AfterTest()
        {
            //logoutPage.CommonExit();
            //loginPage.Authorize(Data.user1, Data.password);
            //mainPage.CleanUpAllLettersAfterTest();
            //logoutPage.CommonExit();
            //loginPage.Authorize(Data.user2, Data.password);
            //mainPage.CleanUpAllLettersAfterTest();
            //logoutPage.CommonExit();
            //loginPage.Authorize(Data.user3, Data.password);
            //mainPage.CleanUpAllLettersAfterTest();
            loginPage.Close();   
        }

     
    }
}
