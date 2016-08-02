using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Core.BrowsersDriverSettings;
using Framework.Exceptions;

namespace Core.Driver
{
   public class CreationOfDriver
    {
        public static IWebDriver CreateDriver()
        {

            String browserName = ConfigurationManager.AppSettings["CurrentBrowser"];
            switch (browserName)
            {

                case "FireFox":
                    return FireFoxDriverSettings.CreateFireFoxDriver();
                case "Chrome":
                    return CreationOfChromeDriver.CreateChromeDriver();
                case "Opera":
                    return OperaDriverSettings.CreateOperaDriver();
                case "IE":
                    return IEDriverSettings.CreateIEDriver();
                default:
                    throw new InvalideBrowserException();
            }

        }

    }
}
