using OpenQA.Selenium;
using Core.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Driver;
using Core.Extensions;

namespace Core.Elements
{
   public class RadioButton : Element
    {

        public RadioButton(By by) : base(by)
        { }

        public RadioButton(By by, string name) : base(by, name)
        { }
        public void Click()
        {          
            this.WrappedElement.Click();
            logHandler.LogToFile($"'{NameField}' clicked.");
        }


     

    }
}
