using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BrowsersDriverSettings
{
    public class FireFoxDriverSettings
    {

        public static IWebDriver CreateFireFoxDriver()
        {
            return new FirefoxDriver();
        }
    }
}
