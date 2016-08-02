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
    public class LetterPage : AbstractPage
    {


        public Button btLink
        {
            get
            {
                return new Button(By.XPath("//a[4]"));
            }
        }

        //img[@data-goomoji='1f601']

        public Button btFirstEmoticonInLetter
        {
            get
            {
                return new Button(By.XPath("//img[@data-goomoji='1f601']"));
            }
        }

        public Button btSecondEmoticonInLetter
        {
            get
            {
                return new Button(By.XPath("//img[@data-goomoji='1f60a']"));
            }
        }

        public Button btConfirm
        {
            get
            {
                return new Button(By.XPath("//input[@value='Confirm']"));
            }
        }


        public LetterPage() : base()
        { }

    }
}
