using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Pages;
using System.Windows.Forms;
using System.Threading;

namespace Framework.Steps
{
   public class MailBoxPageSteps
    {
        MailBoxPage mailPage = new MailBoxPage();
        MainPage mainPage = new MainPage();

        public void WriteMessage(string email, string topic, string text)
        {
            mainPage.toWrite.Click();
            Thread.Sleep(4000);
            mailPage.txtRecipients.SetText(email);
            mailPage.txtTopic.SetText(topic);
            mailPage.text.SetText(text);
            mailPage.btSend.Click();
        }


        [STAThread]
        public void WriteMessageWithAttach(string email, string topic, string text, string pathToAttach)
        {
         
            mainPage.toWrite.Click();
            mailPage.txtRecipients.SetText(email);
            mailPage.txtTopic.SetText(topic);
            mailPage.text.SetText(text);

            Thread.Sleep(2000);
            Thread thread = new Thread(
               () =>
               {
                   Clipboard.SetText(pathToAttach);
                   Console.WriteLine(Clipboard.GetText());
               });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            mailPage.btAttach.Click();
            Thread.Sleep(4000);
            SendKeys.SendWait("^(v)");
            Thread.Sleep(5000);
            SendKeys.SendWait("{ENTER}");
            try
            {
                mailPage.btSend.Click();
            }catch (Exception ex) { }
        }


        public void AddEmoticons(string email, string topic, string text)
        {
            mainPage.toWrite.Click();
            mailPage.txtRecipients.SetText(email);
            mailPage.txtTopic.SetText(topic);
            mailPage.text.SetText(text);
            mailPage.btOpenEmoticons.Click();
            mailPage.btAllEmoticons.Click();
            mailPage.btFirstEmoticon.Click(); 
            mailPage.btSecondEmoticon.Click();
            mailPage.btSend.Click();
        }
        

    }
}
