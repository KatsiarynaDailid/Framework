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
    public class ErrorPage : AbstractPage
    {
        public ErrorPage() : base()
        { }

        public Span spError
        {
            get
            {
                return new Span(By.XPath("//div[@class='bab']"));
            }
        }

        public Button btCloseError
        {
            get
            {
                return new Button(By.XPath("//div[@class='Kj-JD-K7 Kj-JD-K7-GIHV4']/span[@aria-label='Close']"));
            }
        }

    }
}
