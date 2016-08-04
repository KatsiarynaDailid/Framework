using Framework.Steps;
using System;
using NUnit.Framework;
using Framework;


namespace TestsForFramework
{
  public  class ForwardTest
    {
        LogoutPageSteps logoutPage = new LogoutPageSteps();
        LoginPageSteps loginPage = new LoginPageSteps();
        MainPageSteps mainPage = new MainPageSteps();
        SettingPageSteps settPage = new SettingPageSteps();
        ForwardPageSteps forwardPage = new ForwardPageSteps();

        [SetUp]
        public void BeforeTest()
        {
            loginPage.Open();
        }

        //    [Ignore("dd")]
        [Test]
        [STAThreadAttribute]
        public void CheckForwardingOfMessages()
        {
            string path = TestContext.CurrentContext.TestDirectory;

           
         //   SettingPageSteps sett = new SettingPageSteps();
           
            FormOfForwardPageSteps formPage = new FormOfForwardPageSteps();
            LetterPageSteps letter = new LetterPageSteps();
            MailBoxPageSteps mess = new MailBoxPageSteps();
            BinPageSteps binPage = new BinPageSteps();

            loginPage.Authorize(Data.user2, Data.password);

            mainPage.GoToSettings();
            settPage.GoToForward();
            forwardPage.SetForward(Data.user3);

            logoutPage.CommonExit();
            loginPage.Authorize(Data.user3, Data.password);
            mainPage.OpenLetter();

            letter.GoByLinkToConfirm();
            logoutPage.CommonExit();

            loginPage.Authorize(Data.user2, Data.password);
            mainPage.GoToSettings();
            settPage.GoToForward();
            forwardPage.CreateFilter();
            mainPage.GoToSettings();
            settPage.GoToForward();

            forwardPage.AddFilter();
            formPage.ConfirmForward(Data.user1);

            logoutPage.CommonExit();
            loginPage.Authorize(Data.user1, Data.password);


            mess.WriteMessageWithAttach(Data.user2, "With attach", "attach", path + Data.txtFile);
            mess.WriteMessage(Data.user2, "Without attach", "There is no attachment here.");
            logoutPage.CommonExit();
            loginPage.Authorize(Data.user2, Data.password);
            Assert.True(mainPage.CheckUserInInbox());
            Assert.False(mainPage.CheckLabel());

            mainPage.GoToBin();

            Assert.True(binPage.CheckLabelInBin());
            Assert.True(binPage.CheckUserInBin());

            logoutPage.CommonExit();
            loginPage.Authorize(Data.user3, Data.password);
            Assert.True(mainPage.CheckUserInInbox());
            Assert.False(mainPage.CheckLabel());
            //************
            //logoutPage.CommonExit();
            //loginPage.Authorize(Data.user2, Data.password);
            //mainPage.GoToSettings();
            //settPage.GoToForward();
            //forwardPage.RemoveFilter();

            //***********

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
            logoutPage.CommonExit();
            loginPage.Authorize(Data.user2, Data.password);
            mainPage.GoToSettings();
            settPage.GoToForward();
            forwardPage.RemoveFilter();
            loginPage.Close();
        }

    }
}
