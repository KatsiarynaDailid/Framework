﻿using Core.Extensions;
using Core.Log;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.Elements
{
  public  class TextArea : Element
    {

        public TextArea(By by) : base(by)
        { }

        public TextArea(By by, string name) : base(by, name)
        { }

        public void SetText(String str)
        {
            
            this.WrappedElement.SendKeys(str);
            logHandler.LogToFile($"Set text \"{str}\" to: {NameField}.");
        }

    }
}
