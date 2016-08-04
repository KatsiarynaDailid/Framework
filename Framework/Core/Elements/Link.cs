using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Core.Log;
using Core.Driver;
using Core.Extensions;

namespace Core.Elements
{
    public class Link : Element
    {

        public Link(By by) : base(by)
        { }

        public Link(By by, string name) : base(by, name)
        { }
        public void Click()
        {        
            this.WrappedElement.Click();
            logHandler.LogToFile($"'{NameField}'  clicked.");
        }

       
    }
}
