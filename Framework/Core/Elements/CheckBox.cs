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
    public class CheckBox : Element
    {
       

        public CheckBox(By by) : base(by)
        { }


        public CheckBox(By by, string name) : base(by)
        { }

        public void Check()
        {       
            this.WrappedElement.Click();
            logHandler.LogToFile($"'{NameField}' checked.");
        }

    }
}
