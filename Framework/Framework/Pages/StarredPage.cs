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
   public class StarredPage : AbstractPage
    {


        public Span spTopic
        {
            get
            {
                return new Span(By.XPath("html/body/div[7]/div[3]/div/div[2]/div[1]/div[2]/div/div/div/div[2]/div[1]/div[1]/div/div/div[4]/div[1]/div/table/tbody/tr/td[6]/div/div/div/span[1]/b"));
            }
        }

        public StarredPage() : base()
        {  }

        
    }
}
