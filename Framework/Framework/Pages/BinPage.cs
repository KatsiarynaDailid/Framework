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
   public class BinPage : AbstractPage
    {
        public Span spFormFromBin
        {
            get
            {
                return new Span(By.XPath("/html/body/div[7]/div[3]/div/div[2]/div[1]/div[2]/div/div/div/div[2]/div[1]/div[1]/div/div/div[4]/div[1]/div/table/tbody/tr/td[5]/div[2]/span[1]"), "Form From Bin");
            }
        }

        public Button btNotLabelImp
        {
            get
            {
                return new Button(By.XPath("//*[@aria-label='Not important']"), "Not Label Important");
            }
        }

        public Button btDeleteForever
        {
            get
            {
                return new Button(By.XPath("//div[contains(text(),'Delete forever')]"), "Delete Forever");
            }
        }

        public BinPage() : base()
        { }

    }
}
