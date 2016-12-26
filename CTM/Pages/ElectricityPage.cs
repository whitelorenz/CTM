using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using CTM.Support;

namespace CTM.Pages
{
    class ElectricityPage
    {
        [FindsBy(How = How.Id, Using = "electricity-usage")]
        public IWebElement electricityUsageBox;

        [FindsBy(How = How.Id, Using = "goto-your-energy")]
        public IWebElement nextBt;

        public ElectricityPage()
        {
            PageFactory.InitElements(Browser.Driver(), this);
        }
    }
}
