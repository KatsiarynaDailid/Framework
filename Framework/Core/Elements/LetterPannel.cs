using Core.Extensions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Elements
{
   public class LetterPannel : Element
    {
        public LetterPannel(By by) : base(by)
        { }

        public int Count()
        {
            return this.WrappedElements.Count;
        }
    }
}
