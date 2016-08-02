using OpenQA.Selenium;
using OpenQA.Selenium.Opera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BrowsersDriverSettings
{
    public class OperaDriverSettings
    {

        public static IWebDriver CreateOperaDriver()
        {
            return new OperaDriver();
        }

    }
}
