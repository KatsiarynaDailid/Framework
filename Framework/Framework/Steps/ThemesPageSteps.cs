using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Pages;
using System.Windows.Forms;
using System.Threading;

namespace Framework.Steps
{
   public class ThemesPageSteps
    {
        
        ThemesPage themePage = new ThemesPage();

        public void SetTheme()
        {
            themePage.lnSetTheme.Click();
        }


        public void AddFileToThemes(string path)
        {
            themePage.btMyPhotos.Click();
            Thread.Sleep(2000);
            themePage.SwitchFrame();
            themePage.btUploadAPhoto.Click();
            
            Thread.Sleep(2000);
            Thread thread = new Thread(
               () =>
               {
                   Clipboard.SetText(path);
                   //Console.WriteLine(Clipboard.GetText());
               });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            themePage.btSelectPhoto.Click();
            Thread.Sleep(4000);
            SendKeys.SendWait("^(v)");
            Thread.Sleep(4000);
            SendKeys.SendWait("{ENTER}");


        }

        public void CloseWindows()
        {
            themePage.btCloseFirstWindow.Click();
            themePage.SwitchToDefault();
            themePage.btCloseSecondWindow.Click();
        }

        

        public bool WrongExtensionError()
        {         
            return themePage.spErrorOfExtension.Display();
        }
    }
}
