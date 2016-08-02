using Core.Extensions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Elements
{
   public  class Span : Element
    {
        public Span(By by) : base(by)
        { }


        public string GetText()
        {
           return this.WrappedElement.Text;
        }

    }
}
