using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Core.Driver;
using Core.Extensions;

namespace Core.Elements
{
    public class Link : Element
    {

        public Link(By by) : base(by)
        { }

        public void Click()
        {
            this.WrappedElement.Click();
        }
    }
}
