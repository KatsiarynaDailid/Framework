using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Pages;
using System.Threading;
using OpenQA.Selenium;

namespace Framework.Steps
{
    public class LogoutPageSteps
    {

        LogoutPage logout = new LogoutPage();
        MainPage mainPage = new MainPage();

        public void CommonExit()
        {
            Thread.Sleep(2000);
            mainPage.btAccount.Click();
            mainPage.btLogout.Click();
            Thread.Sleep(2000);
            try
            {
                logout.btChangeAcc.Click();
            }
            catch (WebDriverException ex) { }
           
            logout.btAddAcc.Click();
        }
      

    }
}
