﻿using System;
using Core.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Core
{
   public  class AbstractPage //: Element
    {
       public string url { get; set; }

        public void OpenPage()
        {
            Driver.Driver.DriverInstance().Navigate().GoToUrl(url);
       
        }

        

        public void ClosePage()
        {
            Driver.Driver.DriverInstance().Quit();
        }

        public void SwitchToFirst()
        {

            Driver.Driver.DriverInstance().SwitchTo()
                .Window(Driver.Driver.DriverInstance().WindowHandles.First());          
        }

        public void SwitchToLast()
        {

            Driver.Driver.DriverInstance().SwitchTo()
                .Window(Driver.Driver.DriverInstance().WindowHandles.Last());
        }

        public void SwitchToDefault()
        {
            Driver.Driver.DriverInstance().SwitchTo().DefaultContent();
        }
        //public void SwitchToFrame(string xpath)
        //{
        //    Driver.Driver.DriverInstance().SwitchTo().Frame(Driver.Driver.DriverInstance().FindElement(By.XPath($"{xpath}")));
        //}

        public string GetCurrentUrl()
        {
            return Driver.Driver.DriverInstance().Url;
        }

    }
}
