using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BrowsersDriverSettings
{
    public class CreationOfChromeDriver
    {
        public static IWebDriver CreateChromeDriver()
        {
            return new ChromeDriver();
        }


    }
}
