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
   public class LetterPannel : Element
    {
        public LetterPannel(By by) : base(by)
        { }

        public LetterPannel(By by, string name) : base(by, name)
        { }

        public int Count()
        {
            return this.WrappedElements.Count;
        }
    }
}
