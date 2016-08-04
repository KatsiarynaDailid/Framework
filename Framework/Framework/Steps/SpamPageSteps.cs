using Framework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Framework.Steps
{
  public class SpamPageSteps
    {
 
        SpamPage spamPage = new SpamPage();
        MainPage mainPage = new MainPage();
        public string topic;
       
        public void CheckSpam()
        {
            Thread.Sleep(2000);
            topic = spamPage.elTopic.GetText();
        }

        public void DeleteFromSpam()
        {
           
            Thread.Sleep(2000);
            mainPage.cbLetter.Check();
            spamPage.btNotSpam.Click();
            mainPage.btInbox.Click();
        }

    }
}
