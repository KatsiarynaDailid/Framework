using Core.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.Extensions;

namespace Framework.Pages
{
    public class MainPage : AbstractPage
    {

      
        public CheckBox cbLetter
        {
            get
            {
                return new CheckBox(By.XPath("//tr[@class='zA zE'][1]/td[2]/div/div"));
            }
        }

        public CheckBox cbAllLetters
        {
            get
            {
                return new CheckBox(By.XPath("//div[@class='J-J5-Ji J-JN-M-I-Jm']/span/div[@role='presentation']"));
            }
        }

        public Button btSpam
        {
            get
            {
                return new Button(By.XPath("//div[@class='asl T-I-J3 J-J5-Ji']"));
            }
        }

        public Button toWrite
        {
            get
            {
                return new Button(By.XPath("//div[@class='T-I J-J5-Ji T-I-KE L3']"));
            }
        }

        public Button btMore
        {
            get
            {
                return new Button(By.XPath("//span[@class='CJ']"));
            }
        }

        public Button btSpamLetters
        {
            get
            {
                return new Button(By.XPath("//div[3]/div/div/div/div[4]/div/div/div"));
            }
        }

        public Button btSettings
        {
            get
            {
                return new Button(By.XPath("//div[@class='Cr aqJ']/div[@class='G-Ni J-J5-Ji']/div"));
            }
        }

        public Button btLowerSett
        {
            get
            {
                return new Button(By.XPath("//div[@class='J-N aMS']"));
            }
        }

        public Button btThemes
        {
            get
            {
                return new Button(By.XPath(""));
            }
        }

        public Button btOpenLetter
        {
            get
            {
                return new Button(By.XPath("//td[6]/div/div/div/span"));
            }
        }

        public Span spFormFromInbox
        {
            get
            {
                return new Span(By.XPath("//div[@class='yW']/span[@name='User First']"));
            }
        }

     public Button btInbox
        {
            get
            {
                return new Button(By.XPath("//a[contains(text(),'Inbox')]"));
            }
        }

        public Button btLabelImp
        {
            get
            {
                return new Button(By.XPath("//div[@aria-label='Important because you marked it as important.']"));
            }
        }
        //html/body/div[7]/div[3]/div/div[2]/div[1]/div[2]/div/div/div/div[2]/div[1]/div[1]/div/div/div[4]/div[1]/div/table/tbody/tr/td[6]/div/div/div/span[1]/b

        public Span spTopic
        {
            get
            {
                return new Span(By.XPath("//td/div/div/div/span[1]"));
            }
        }


        public Button btBin
        {
            get
            {
                return new Button(By.XPath("//div[3]/div/div/div/div[5]/div/div/div"));
            }
        }

        public Button btToBin
        {
            get
            {
                return new Button(By.XPath("//div[@class='asa']/div[@class='ar9 T-I-J3 J-J5-Ji']"));
            }
        }

       

        public Button btAccount
        {
            get
            {
                return new Button(By.XPath("//a[@class='gb_b gb_8a gb_R']/span[@class='gb_3a gbii']"));
            }
        }

        public Button btLogout
        {
            get
            {
                return new Button(By.XPath("//a[@class='gb_Fa gb_Ce gb_Ke gb_rb']"));
            }
        }

        public Button btStarred
        {
            get
            {
                return new Button(By.XPath("//td[@class='apU xY']/span[@aria-label='Starred']"));
            }
        }
        public Button btNotStarred
        {
            get
            {
                return new Button(By.XPath("//td[@class='apU xY']/span[@aria-label='Not starred']"));
            }
        }

        
        public Button btListOfStarred
        {
            get
            {
                return new Button(By.XPath("//div[@class='aio UKr6le']/span/a[@title='Starred']"));
            }
        }

       public LetterPannel lpLetters
        {
            get
            {
                return new LetterPannel(By.XPath("//div[@class='Cp']/div/table/tbody/tr"));
            }
        }


        public MainPage() : base()
        { }

    }
}
