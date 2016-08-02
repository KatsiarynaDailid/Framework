using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Elements;
using OpenQA.Selenium;
using Core;
using Core.Driver;
using Core.Extensions;


namespace Framework.Pages
{
   public class ThemesPage : AbstractPage
    {
        public ThemesPage() : base()
        {
             
        }


        public Link lnSetTheme
        {
            get
            {
                return new Link(By.XPath("//a[contains(text(),'Set Theme.')]"));
            }
        }

        public Button btMyPhotos
        {
            get
            {
                return new Button(By.XPath("//div[contains(text(),'My Photos')]"));
            }
        }

        //Upload a photo
        public Button btUploadAPhoto
        {
            get
            {
                return new Button(By.XPath("//div[@class='a-ki']/div[contains(text(),'Upload a photo')]"));
            }
        }

        //Select a photo from your computer
        public Button btSelectPhoto
        {
            get
            {
                return new Button(By.XPath("//div[contains(text(),'Select a photo from your computer')]"));
            }
        }

        public Span spErrorOfExtension
        {
            get
            {
                return new Span(By.XPath("//div[contains(text(),'Selected file [001_1.zip] is not supported for upload.')]"));
            }
        }

        public Button btCloseFirstWindow
        {
            get
            {
                return new Button(By.XPath("//div[@aria-label='Close']"));
            }
        }

        public Button btCloseSecondWindow
        {
            get
            {
                return new Button(By.XPath("//div[@class='Kj-JD-K7 Kj-JD-K7-GIHV4 a80']/span[@aria-label='Close']"));
            }
        }
        public void SwitchFrame()
        {
            Driver.DriverInstance().SwitchTo().Frame(Driver.DriverInstance().FindElement(By.XPath("//iframe[@class='KA-JQ']"),10));
         
        }
        

    }
}
