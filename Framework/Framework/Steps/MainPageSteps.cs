using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Pages;
using System.Windows.Forms;
using System.Threading;

namespace Framework.Steps
{
    public class MainPageSteps
    {


        MainPage mainPage = new MainPage();
        BinPage binPage = new BinPage();
        public const string SETTING_PAGE = "https://mail.google.com/mail/u/0/#settings/general";
        public const string THEMES_PAGE = "https://hangouts.google.com/webchat/u/0/host-js?prop=gmail&b=1&zx=tb8xwalepfin";

        public void OpenLetter()
        {
            mainPage.btOpenLetter.Click();
        }

        public void AddToSpam()
        {
            bool exist;
            mainPage.cbLetter.Check();
            mainPage.btSpam.Click();
        }


        public void GoToSpam()
        {
            mainPage.btMore.Click();
            mainPage.btSpamLetters.Click();
        }


        public void GoToBin()
        {
            mainPage.btMore.Click();
            mainPage.btBin.Click();
        }

        public void GoToSettings()
        {
            mainPage.btSettings.Click();
            // can`t press button "settings"
            //mainPage.btLowerSett.Click();
            SettingPage settingsPage = new SettingPage(SETTING_PAGE);
            settingsPage.OpenPage();
        }



        public bool CheckUserInInbox()
        {
            string s = mainPage.spFormFromInbox.GetText();
            return s.Equals("User First");
        }

        public bool CheckLabel()
        {
            // Thread.Sleep(4000);
            try
            {
                return mainPage.btLabelImp.Display();
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void GoToStarred()
        {
            mainPage.btListOfStarred.Click();
        }

        public bool CheckIfItIsStarred()
        {
            mainPage.btNotStarred.Click();
            return mainPage.btStarred.Display();
        }

        public bool CheckTopicInInbox(string topic)
        {
            Thread.Sleep(4000);
            return topic.Equals(mainPage.spTopic.GetText());
        }



        public bool ThereIsALetters()
        {
            try
            {
                mainPage.lpLetters.Display();
                return true;

            }
            catch (Exception ex) { return false; }
        }

        public void CleanUpAllLettersAfterTest()
        {
           

            GoToSpam();      
            mainPage.cbAllLetters.Check();

            if (ThereIsALetters())
            {
                mainPage.btToBin.Click();
            }

            mainPage.btInbox.Click();
            Thread.Sleep(4000);         
            mainPage.cbAllLetters.Check();
            if (ThereIsALetters())
            {
                mainPage.btToBin.Click();
            }
            GoToBin();

            mainPage.cbAllLetters.Check();
            if (ThereIsALetters())
            {
                binPage.btDeleteForever.Click();
            }

        }

    }
}
