using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Elements;
using Core;
using OpenQA.Selenium;

namespace Framework.Pages
{
   public class SettingPage : AbstractPage
    {
        public Button btForward
        {
            get
            {
                return new Button(By.XPath("//a[contains(text(),'Forwarding and POP/IMAP')]"));
            }
        }

        public Button btThemes
        {
            get
            {
                return new Button(By.XPath("//a[contains(text(),'Themes')]"));
            }
        }

        public SettingPage(String url) : base()
        {
            base.url = url;
          
        }


      
    }
}
