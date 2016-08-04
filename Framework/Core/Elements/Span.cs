using Core.Extensions;
using OpenQA.Selenium;
using Core.Log;
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

        public Span(By by, string name) : base(by, name)
        { }

        public string GetText()
        {
            string result = this.WrappedElement.Text;
            logHandler.LogToFile($"Got text '{result}' from '{NameField}'.");
            return result;
            
        }

    }
}
