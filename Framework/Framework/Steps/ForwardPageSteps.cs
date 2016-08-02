using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Pages;
using System.Threading;


namespace Framework.Steps
{
   public class ForwardPageSteps
    {
        ForwardPage forwardPage = new ForwardPage();

        public void SetForward(String email)
        {         
            forwardPage.btAddForward.Click();
            forwardPage.txtAddress.SetText(email);
            forwardPage.btNext.Click();
            forwardPage.SwitchToLast();
            forwardPage.btProceed.Click();
            forwardPage.SwitchToFirst();
            forwardPage.btOk.Click();
        }


        public void CreateFilter()
        {
            forwardPage.rbForward.Click();
            forwardPage.btSaveChange.Click();
     
        }

        public void AddFilter()
        {
            forwardPage.btFilter.Click();
        }

        public void RemoveFilter()
        {
            forwardPage.btOptions.Click();
            forwardPage.btRemove.Click();
            forwardPage.btOkRemove.Click();
        }
    }
}
