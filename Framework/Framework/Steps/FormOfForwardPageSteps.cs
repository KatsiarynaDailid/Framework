using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Pages;
using System.Threading;


namespace Framework.Steps
{
   public class FormOfForwardPageSteps
    {
        FormOfForwardPage formPage = new FormOfForwardPage();

        public void ConfirmForward(string form)
        {         
            //Thread.Sleep(4000);
           
            formPage.txtFrom.SetText(form);
            formPage.cbHasAttachment.Check();
            formPage.btCreateFilter.Click();
            //       btOk.Click();
            formPage.cbDeleteIt.Check();
            formPage.cbAlwaysMark.Check();
            formPage.btFinishCreation.Click();
        }

    }
}
