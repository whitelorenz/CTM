using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using CTM.Support;

namespace CTM.Pages
{
    class YourPreferencesPage
    {
        [FindsBy(How = How.TagName, Using = "h2")]
        public IWebElement header;

        [FindsBy(How = How.CssSelector, Using = "span[class=\"icon tariff-all\"]")]
        public IWebElement allTariffs;

        [FindsBy(How = How.CssSelector, Using = "span[class=\"icon payment-all\"]")]
        public IWebElement allPayments;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"Email\"]")]
        public IWebElement email;

        [FindsBy(How = How.Id, Using = "terms-label")]
        public IWebElement terms;

        [FindsBy(How = How.Id, Using = "email-submit")]
        public IWebElement nextBt;

        public YourPreferencesPage()
        {
            PageFactory.InitElements(Browser.Driver(), this);
        }
    }
}
