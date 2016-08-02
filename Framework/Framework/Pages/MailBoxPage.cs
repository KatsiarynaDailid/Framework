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
                return new TextArea(By.Name("to"));
            }
        }

        public TextArea txtTopic
        {
            get
            {
                return new TextArea(By.Name("subjectbox"));
            }
        }

        public TextArea text
        {
            get
            {
                return new TextArea(By.XPath("//div[@aria-label='Message Body']"));
            }
        }

        public Button btAttach
        {
            get
            {
                return new Button(By.XPath("//td[4]/div/div/div/div/div"));
            }
        }

        public Button btSend
        {
            get
            {
                return new Button(By.XPath("//div[@aria-label='Send ‪(Ctrl-Enter)‬']"));
            }
        }


        public Button btOpenEmoticons
        {
            get
            {
                return new Button(By.XPath("//div[@class='QT aaA aMZ']"));
            }
        }
        //div[@class='wVboN']/button[@string='1f601']

        
        public Button btAllEmoticons
        {
            get
            {
                return new Button(By.XPath("//button[@title='Show face emoticons']"));
            }
        }

        public Button btFirstEmoticon
        {
            get
            {
                return new Button(By.XPath("//div[@class='wVboN']/button[@string='1f601']"));
            }
        }

        public Button btSecondEmoticon
        {
            get
            {
                return new Button(By.XPath("//div[@class='wVboN']/button[@string='1f60a']"));
            }
        }

        public MailBoxPage() : base()
        { }

    }
}
