﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Pages;
using System.Threading;

namespace Framework.Steps
{
    public class LetterPageSteps
    {
        LetterPage letterPage = new LetterPage();

        public void GoByLinkToConfirm()
        {                      
            letterPage.btLink.Click();
            letterPage.SwitchToLast();
            Thread.Sleep(1000);
            letterPage.btConfirm.Click();
            letterPage.SwitchToFirst();
        }

        public bool ConfirmEmoticons()
        {
           bool first = letterPage.btFirstEmoticonInLetter.Display();
           bool second = letterPage.btSecondEmoticonInLetter.Display();
            return first && second;
        }

    }
}
