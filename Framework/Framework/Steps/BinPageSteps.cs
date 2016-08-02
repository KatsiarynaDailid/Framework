using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Pages;

namespace Framework.Steps
{
  public  class BinPageSteps
    {

        BinPage binPage = new BinPage();
      
        public bool CheckUserInBin()
        {
            string s = binPage.spFormFromBin.GetText();
            return s.Equals("User First");
        }


        public bool CheckLabelInBin()
        {
            // Thread.Sleep(4000);
            try
            {
                return binPage.btNotLabelImp.Display();
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
