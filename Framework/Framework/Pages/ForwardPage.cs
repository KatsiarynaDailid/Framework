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
    public class ForwardPage : AbstractPage
    {
        //https://mail-settings.google.com/mail/u/0/?scd=1&mfea=006f41fcff4b52510e30de753fdc3128c2d8d9493cac9809a08846ecbca57d17d259&fws=I1t6v6id0t87ncuQYiZSL2aS68k&iuhs=1&ui=2&view=mfwa&ik=82b2a13c2c&at=AF6bupPuBXatJIqKVpy3LbamkW5WgOYfVg&pli=1

       public Button btAddForward
        {
            get
            {
                return new Button(By.XPath("//input[@value='Add a forwarding address']"), "Add Forward");
            }
        }
        public TextArea txtAddress
        {
            get
            {
                return new TextArea(By.XPath("//*[@class='PN']/input"), "Address");
            }
        }
        public Button btNext
        {
            get
            {
                return new Button(By.XPath("//button[@name='next']"), "Next");
            }
        }
        public Button btProceed
        {
            get
            {
                return new Button(By.XPath("//input[@value='Proceed']"), "Proceed");
            }
        }
        public Button btOk
        {
            get
            {
                return new Button(By.Name("ok"), "Ok");
            }
        }
        public RadioButton rbForward
        {
            get
            {
                return new RadioButton(By.XPath("//span[contains(.,'Forward a copy of incoming mail to')]/../preceding-sibling::td/input"), "Forward");
            }
        }
        public Button btFilter
        {
            get
            {
                return new Button(By.XPath("//div[6]/div/table/tbody/tr/td[2]/div/div[3]/span"), "Filter");
            }
        }
        public Button btSaveChange
        {
            get
            {
                return new Button(By.XPath("/html/body/div[7]/div[3]/div/div[2]/div[1]/div[2]/div/div/div/div[2]/div[1]/div[1]/div/div/div/div/div/div/div[6]/div/table/tbody/tr[4]/td/div/button[1]"), "Save Change");
            }
        }


        public Button btOptions
        {
            get
            {
                return new Button(By.XPath("//td[@class='C6']/span/select"), "Options");
            }
        }

        public Button btRemove
        {
            get
            {
                return new Button(By.XPath("//td[@class='C6']/span/select/option[@value='2']"), "Remove");
            }
        }


        public Button btOkRemove
        {
            get
            {
                return new Button(By.Name("ok"), "Ok remove");
            }
        }
        public ForwardPage() : base()
        { }

    }
}
