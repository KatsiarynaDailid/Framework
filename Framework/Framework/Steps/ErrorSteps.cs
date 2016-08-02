using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Pages;
using System.Threading;
using OpenQA.Selenium;

namespace Framework.Steps
{
    public class ErrorSteps
    {
        ErrorPage errPage = new ErrorPage();

        public bool ThereIsAnErrorMessage()
        {
           return errPage.spError.Display();
        }


        public void CloseErrorMessage() {

            errPage.btCloseError.Click();

        }
    }
}
