using Core.Extensions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Log;
using System.Threading.Tasks;

namespace Core.Elements
{
    public class Button : Element
    {

        public Button(By by) : base(by)
        { }

        public void Click()
        {
           logHandler.LogToFile("Click!");
            this.WrappedElement.Click();
        }
    }
}
