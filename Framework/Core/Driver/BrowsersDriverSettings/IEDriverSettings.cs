using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BrowsersDriverSettings
{
    public class IEDriverSettings
    {

        public static IWebDriver CreateIEDriver()
        {
            return new InternetExplorerDriver();
        }
    }
}
