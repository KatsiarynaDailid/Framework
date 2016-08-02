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
   public class FormOfForwardPage : AbstractPage
    {

       public TextArea txtFrom
        {
            get
            {
                return new TextArea(By.XPath("//span[2]/input"));
            }
        }

       public CheckBox cbHasAttachment
        {
            get
            {
                return new   CheckBox(By.XPath("//div[7]/span/input"));
            }
        }

        public Button btOk
        {
            get
            {
                return new Button(By.Name("ok"));
            }
        }

        public Button btCreateFilter
        {
            get
            {
                return new Button(By.XPath("//div[9]/div[2]"));
            }

        }

        public CheckBox cbDeleteIt
        {
            get
            {
                return new CheckBox(By.XPath("//div[6]/input"));
            }
        }

        public CheckBox cbAlwaysMark
        {
            get
            {
                return new CheckBox(By.XPath("//div[8]/input"));
            }   
        }

        public Button btFinishCreation
        {
            get
            {
                return new Button(By.XPath("//div[contains(text(),'Create filter')]"));
            }
           
        }


        public FormOfForwardPage() : base()
        { }
        


    }
}
