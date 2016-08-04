using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Pages;
using System.Threading;

namespace Framework.Steps
{
    public class LoginPageSteps
    {
        public const string START_PAGE = "https:\\gmail.com";

        LoginPage loginPage = new LoginPage(START_PAGE);

        public void Open()
        {
            loginPage.OpenDriver();
        }

        public void Close()
        {
            loginPage.CloseDriver();
        }

        public void OpenPage()
        {

        }

        public void Authorize(string email, string pass)
        {
            loginPage.txtEmail.SetText(email);
            loginPage.btNext.Click();
            Thread.Sleep(1000);
            loginPage.txtPassword.SetText(pass);
            loginPage.btSingIn.Click();
        }

       

    }
}
