using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using CTM.Support;

namespace CTM.Pages
{
    class EnergyPage
    {
        [FindsBy(How = How.Id, Using = "electricity-current-spend")]
        public IWebElement electricityUsageBox;

        [FindsBy(How = How.Id, Using = "gas-current-spend")]
        public IWebElement gasUsageBox;

        [FindsBy(How = How.Id, Using = "goto-your-energy")]
        public IWebElement nextBt;

        [FindsBy(How = How.Id, Using = "electricity-dont-know-check")]
        public IWebElement electricityNotKnown;

        [FindsBy(How = How.Id, Using = "gas-dont-know-check")]
        public IWebElement gasNotKnown;

        public EnergyPage()
        {
            PageFactory.InitElements(Browser.Driver(), this);
        }
    }
}
