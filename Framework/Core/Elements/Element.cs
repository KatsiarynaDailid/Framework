using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Core.Driver;
using Core.Extensions;

namespace Core
{
    public abstract class Element
    {

        private By by { get; set; }

        public Element(By by)
        {
            this.by = by;
        }

        public IWebElement WrappedElement
        {
            get { return Driver.Driver.DriverInstance().FindElement(this.by, 10); }
        }

        public bool Display()
        {
            return this.WrappedElement.Displayed;
        }

    }
}
