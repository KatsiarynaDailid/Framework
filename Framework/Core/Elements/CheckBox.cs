﻿using Core.Extensions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Elements
{
    public class CheckBox : Element
    {
       

        public CheckBox(By by) : base(by)
        { }

        public void Check(/*out bool exist */)
        {
            //try
            //{
            //    exist = true
            
                this.WrappedElement.Click();
                

            //}
            //catch (Exception ex) { exist = false; }
            }

    }
}
