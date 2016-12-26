using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using CTM.Support;

namespace CTM.Pages
{
    class GasPage
    {
        [FindsBy(How = How.Id, Using = "gas-usage")]
        public IWebElement gasUsageBox;

        [FindsBy(How = How.Id, Using = "goto-your-energy")]
        public IWebElement nextBt;

        public GasPage()
        {
            PageFactory.InitElements(Browser.Driver(), this);
        }
    }
}
