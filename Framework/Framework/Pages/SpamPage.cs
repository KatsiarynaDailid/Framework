using Core.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Framework.Pages
{
   public class SpamPage : AbstractPage
    {
       

        public Button btNotSpam
        {
            /*//div/div/span/b/*/
            /*//div[@class='xT']/div[@class='y6']/span[1]/b*/
            get
            {
                return new Button(By.XPath("//div[contains(text(),'Not spam')]"), "Not Spam");
            }
        }

        public Span elTopic
        {
            /*//div/div/span/b/*/
            /*//div[@class='xT']/div[@class='y6']/span[1]/b*/
            get
            {
                return new Span(By.XPath("html/body/div[7]/div[3]/div/div[2]/div[1]/div[2]/div/div/div/div[2]/div[1]/div[1]/div/div/div[4]/div[1]/div/table/tbody/tr/td[6]/div/div/div/span[1]/b"), "Topic");
            }
        }

        public SpamPage() : base()
        { }


    }
}
