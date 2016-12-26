using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using CTM.Support;

namespace CTM.Pages
{
    public class YourSupplierPage
    {
        [FindsBy(How = How.Id, Using = "find-postcode")]
        public IWebElement findPostcodeBt;

        [FindsBy(How = How.Id, Using = "your-postcode")]
        public IWebElement postcodeBox;

        [FindsBy(How = How.Id, Using = "goto-your-supplier-details")]
        public IWebElement nextBt;

        [FindsBy(How = How.CssSelector, Using = "span[class=\"icon have-bill-no\"]")]
        public IWebElement noBillBt;

        [FindsBy(How = How.CssSelector, Using = "span[class=\"icon have-bill-yes\"]")]
        public IWebElement haveBillBt;

        public YourSupplierPage()
        {
            PageFactory.InitElements(Browser.Driver(), this);
        }
    }
}
