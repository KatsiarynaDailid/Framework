using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Steps;
using Framework.Pages;

namespace Demo
{
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
           
            LoginPageSteps loginPage = new LoginPageSteps();
            LogoutPageSteps logoutPage = new LogoutPageSteps();
            MainPageSteps mainPage = new MainPageSteps();
            ThemesPageSteps themePage = new ThemesPageSteps();
            SettingPageSteps settPage = new SettingPageSteps();
            MailBoxPageSteps mailPage = new MailBoxPageSteps();
            LetterPageSteps letterPage = new LetterPageSteps();
            StarredPageSteps starredPage = new StarredPageSteps();
            SpamPageSteps spamPage = new SpamPageSteps();

            //MailBoxPageSteps mailPage = new MailBoxPageSteps();
            //StarredPageSteps starredPage = new StarredPageSteps();
            loginPage.Open();
            loginPage.Authorize(D.user2, D.password);
            mailPage.WriteMessage(D.user3, "For starred", "XO");
            logoutPage.CommonExit();
            loginPage.Authorize(D.user3, D.password);
            Console.WriteLine(mainPage.CheckIfItIsStarred());
            mainPage.GoToStarred();
            Console.WriteLine(starredPage.CheckIfItIsStarredPage("https://mail.google.com/mail/u/0/#starred"));
            Console.WriteLine(starredPage.CheckTheTopic("For starred"));
            Console.ReadLine();
        }
    }
}
