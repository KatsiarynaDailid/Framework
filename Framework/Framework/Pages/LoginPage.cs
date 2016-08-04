using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using OpenQA.Selenium;
using Core.Elements;

namespace Framework.Pages
{
    public class LoginPage : AbstractPage
    {

        public Button btNext
        {
            get
            {
                return new Button(By.Id("next"), "Next");
            }
        }

        public TextArea txtEmail
        {
            get
            {
                return new TextArea(By.Id("Email"),"Email");
            }
        }

        public Button btSingIn
        {
            get
            {
                return new Button(By.Id("signIn"),"SignIn");
            }
        }

        public TextArea txtPassword
        {
            get
            {
                return new TextArea(By.Id("Passwd"), "Password");
            }
        }


        public LoginPage(String url) : base()
        {
            base.url = url;
        }

    }
}
