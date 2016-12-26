using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using CTM.Support;

namespace CTM.Pages
{
    class EnergyCalculatorPage
    {
        [FindsBy(How = How.CssSelector, Using = "span[class=\"icon bedrooms-3-4\"]")]
        public IWebElement threeBedroomsIco;

        [FindsBy(How = How.CssSelector, Using = "span[class=\"icon occupants-3-4\"]")]
        public IWebElement threeOccupantsIco;

        [FindsBy(How = How.CssSelector, Using = "span[class=\"icon energy-electricity\"]")]
        public IWebElement electricityHeatingIco;

        [FindsBy(How = How.CssSelector, Using = "span[class=\"icon temp-temperate\"]")]
        public IWebElement temperateIco;

        [FindsBy(How = How.CssSelector, Using = "span[class=\"icon insulation-well-wrapped\"]")]
        public IWebElement wellWrappedIco;

        [FindsBy(How = How.CssSelector, Using = "span[class=\"icon cooking-electricty\"]")]
        public IWebElement electricityIco;

        [FindsBy(How = How.CssSelector, Using = "span[class=\"icon occupied-evenings-weekends\"]")]
        public IWebElement eveningWeekendsIco;

        [FindsBy(How = How.Id, Using = "goto-person-details-button")]
        public IWebElement nextBt;

        public EnergyCalculatorPage()
        {
            PageFactory.InitElements(Browser.Driver(), this);
        }
    }
}
