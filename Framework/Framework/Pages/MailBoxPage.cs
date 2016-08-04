using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Elements;
using Core;
using OpenQA.Selenium;


namespace Framework.Pages
{
    public class MailBoxPage : AbstractPage
    {
       

        public TextArea txtRecipients
        {
            get
            {
                return new TextArea(By.Name("to"), "To");
            }
        }

        public TextArea txtTopic
        {
            get
            {
                return new TextArea(By.Name("subjectbox"), "Topic");
            }
        }

        public TextArea text
        {
            get
            {
                return new TextArea(By.XPath("//div[@aria-label='Message Body']"), "Message Body");
            }
        }

        public Button btAttach
        {
            get
            {
                return new Button(By.XPath("//td[4]/div/div/div/div/div"), "Attach");
            }
        }

        public Button btSend
        {
            get
            {
                return new Button(By.XPath("//div[@aria-label='Send ‪(Ctrl-Enter)‬']"), "Send");
            }
        }


        public Button btOpenEmoticons
        {
            get
            {
                return new Button(By.XPath("//div[@class='QT aaA aMZ']"), "Open Emoticons");
            }
        }
        //div[@class='wVboN']/button[@string='1f601']

        
        public Button btAllEmoticons
        {
            get
            {
                return new Button(By.XPath("//button[@title='Show face emoticons']"), "All Emoticons");
            }
        }

        public Button btFirstEmoticon
        {
            get
            {
                return new Button(By.XPath("//div[@class='wVboN']/button[@string='1f601']"), "First Emoticons");
            }
        }

        public Button btSecondEmoticon
        {
            get
            {
                return new Button(By.XPath("//div[@class='wVboN']/button[@string='1f60a']"), "Second Emoticons");
            }
        }

        public MailBoxPage() : base()
        { }

    }
}
