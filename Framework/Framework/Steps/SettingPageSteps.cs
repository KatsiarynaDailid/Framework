using Framework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Framework.Steps
{
  public class SettingPageSteps
    {
        public const string SETTING_PAGE = "https://mail.google.com/mail/u/0/#settings/general";

        ForwardPage forwardPage = new ForwardPage();
        FormOfForwardPage formPage = new FormOfForwardPage();
        SettingPage settingsPage = new SettingPage(SETTING_PAGE);

        public void GoToForward()
        {

            //MainPage mainP = new MainPage();
            //mainP.GoToSettings();   
            //SettingsPage settingsPage = new SettingsPage(SETTING_PAGE);
            //settingsPage.OpenDriver();
            settingsPage.btForward.Click();

        }

        public void GoToThemesPage()
        {

            settingsPage.btThemes.Click();

            //mainPage.btSettings.Click();
            // can`t press button "themes"
            //mainPage.btThemes.Click();
           // ThemesPage themesPage = new ThemesPage(THEMES_PAGE);
            //themesPage.OpenDriver();
        }
        //public void SetForward(String email)
        //{
        //    forwardPage.AddForward(email);
        //    forwardPage.SwitchToLast();
        //    forwardPage.PressProceed();
        //    forwardPage.SwitchToFirst();
        //    forwardPage.Confirm();
        //}

        //public void ConfirmForward(string form)
        //{
        //    forwardPage.CreateFilter();
        //    Thread.Sleep(4000);
        //    SettingPage settingsPage = new SettingPage(SETTING_PAGE);
        //    settingsPage.OpenDriver();
        //    settingsPage.btForward.Click();

        //    forwardPage.btFilter.Click();
        //    formPage.SetForm(form);
        //    formPage.GoToAnotherForm();
        //    formPage.SetNextForm();
        //}

    }
}
