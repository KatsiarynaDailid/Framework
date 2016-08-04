using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public static class WebDriverExtensions
    {
        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            var elementsList = driver.FindElements(by);
            try
            {
                if (timeoutInSeconds > 0)
                {
                    foreach (IWebElement elem in elementsList)
                    {
                        if (elem.Displayed)
                        {
                            return elem;//driver.FindElement(by);
                }
            }
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                    return wait.Until(ExpectedConditions.ElementIsVisible(by));
                }
                return driver.FindElement(by);
            }
            catch (TimeoutException ex) { return null; }
          
        }

        public static IWebElement FindElements(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            //var elementsList = driver.FindElements(by);

            if (timeoutInSeconds > 0)
            {
                //foreach (IWebElement elem in elementsList)
                //{
                //    if (elem.Displayed)
                //    {
                        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                        return wait.Until(ExpectedConditions.ElementIsVisible(by));
                    }
            //    }

            //}
            return driver.FindElement(by);


        }


        public static void ImplWait(this IWebDriver driver, double time)
        {
           driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(time));
        }

        //public static bool IsPresent(this IWebDriver driver, By by)
        //{
        //    return driver.FindElement(by, 10).Displayed;  

        //}


        public static void JavaScriptClick(this IWebDriver driver, By by)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", driver.FindElement(by,10));
        }
    }
}
