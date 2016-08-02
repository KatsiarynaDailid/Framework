using Core.Extensions;
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

        public void SetText(String str)
        {
            this.WrappedElement.SendKeys(str);
        }

    }
}
