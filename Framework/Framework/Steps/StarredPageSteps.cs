using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Pages;
using System.Threading;

namespace Framework.Steps
{
   public class StarredPageSteps
    {

        StarredPage starredPage = new StarredPage();

        public bool CheckIfItIsStarredPage(string url)
        {
            Thread.Sleep(2000);
            string currUrl = starredPage.GetCurrentUrl();
           // Console.WriteLine(currUrl);
            return currUrl.Equals(url);
        }

        public bool CheckTheTopic(string topic)
        {           
            return topic.Equals(starredPage.spTopic.GetText());
        }

    }
}
