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


       //     loginPage.LogIn();
            loginPage.Authorize("user1.tat13@gmail.com", "257646667");
            mailPage.WriteMessage("user2.tat13@gmail.com", "for spam", "Spam");
            logoutPage.CommonExit();
            loginPage.Authorize("user2.tat13@gmail.com", "257646667");
            mainPage.AddToSpam();   
            mainPage.GoToSpam();        
            spamPage.DeleteFromSpam();
            Console.WriteLine(mainPage.CheckTopicInInbox("for spam"));    
            logoutPage.CommonExit();
            Console.WriteLine();
            Console.WriteLine("end");
            Console.ReadLine();
        }
    }
}
