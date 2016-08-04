using Core;
using Core.Elements;
using OpenQA.Selenium;
using Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Framework.Pages
{
    public class LogoutPage : AbstractPage
    {

       

        public Button btChangeAcc
        {
            get
            {
                return new Button(By.Id("account-chooser-link"),"Change Account");
            }
        }

        public Button btAddAcc
        {
            get
            {
                return new Button(By.Id("account-chooser-add-account"),"Add Account");
            }
        }

        public LogoutPage() : base()
        { }

    }
}
