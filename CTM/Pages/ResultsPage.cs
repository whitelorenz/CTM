using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using CTM.Support;

namespace CTM.Pages
{
    class ResultsPage
    {
        [FindsBy(How = How.TagName, Using = "h2")]
        public IWebElement header;

        public ResultsPage()
        {
            PageFactory.InitElements(Browser.Driver(), this);
        }
    }
}

