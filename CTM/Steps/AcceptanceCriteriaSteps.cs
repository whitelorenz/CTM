using CTM.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System.Collections.ObjectModel;
using TechTalk.SpecFlow;
using Shouldly;
using OpenQA.Selenium.Support.UI;
using System;
using CTM.Pages;

namespace CTM.Steps
{
    [Binding]
    public class AcceptanceCriteriaSteps
    {
        YourSupplierPage yourSupplierPage;
        ElectricityPage electricityPage;
        GasPage gasPage;
        YourPreferencesPage preferencesPage;
        ResultsPage resultsPage;
        EnergyPage energyPage;
        EnergyCalculatorPage energyCalculatorPage;

        [Given]
        public void GivenIAmOnYourSupplierPage()
        {

            Browser.Driver().Navigate().GoToUrl(Browser.TestURL);
            yourSupplierPage = new YourSupplierPage();
        }
        
        [When]
        public void WhenIEnterMyPostcode()
        {
            if (yourSupplierPage.findPostcodeBt.Displayed)
            {
                yourSupplierPage.postcodeBox.SendKeys("PE2 6YS");
                yourSupplierPage.findPostcodeBt.Click();
            }
            WebDriverWait wait = new WebDriverWait(Browser.Driver(), TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("change-postcode")));
            yourSupplierPage = new YourSupplierPage();
        }

        [When]
        public void WhenIMoveToTheElectricityPage()
        {
            yourSupplierPage.nextBt.Click();
            WebDriverWait wait = new WebDriverWait(Browser.Driver(), TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("electricity-usage")));
            electricityPage = new ElectricityPage();
        }

        [When]
        public void WhenIPressNext()
        {
            IWebElement nextBtn = Browser.Driver().FindElement(By.Id("goto-your-energy"));
            nextBtn.Click();
        }
        
        [When]
        public void WhenIEnterMyElectricityUsage()
        {
            electricityPage.electricityUsageBox.SendKeys("100");
        }

        [When]
        public void WhenIMoveToTheGasPage()
        {
            electricityPage.nextBt.Click();
            WebDriverWait wait = new WebDriverWait(Browser.Driver(), TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("gas-usage")));
            gasPage = new GasPage();
        }


        [When]
        public void WhenIEnterMyGasUsage()
        {
            gasPage.gasUsageBox.SendKeys("100");
        }

        [When]
        public void WhenIMoveToYourPreferencesPage()
        {
            if (gasPage != null)
            {
                gasPage.nextBt.Click();
            }
            else if (energyPage != null)
            {
                energyPage.nextBt.Click();
            }
            else if (energyCalculatorPage != null)
            {
                energyCalculatorPage.nextBt.Click();
            }
            WebDriverWait wait = new WebDriverWait(Browser.Driver(), TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("email-submit")));
            preferencesPage = new YourPreferencesPage();
        }


        [When]
        public void WhenIFillInTheMandatoryFields()
        {
            preferencesPage.allTariffs.Click();
            preferencesPage.allPayments.Click();
            preferencesPage.email.SendKeys("abc@123.com");
            preferencesPage.terms.Click();
        }

        [When]
        public void WhenISubmitTheForm()
        {
            preferencesPage.nextBt.Click();
            WebDriverWait wait = new WebDriverWait(Browser.Driver(), TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("your-account-button")));
            resultsPage = new ResultsPage();
        }

        [When]
        public void WhenIDonTHaveMyBill()
        {
            yourSupplierPage.noBillBt.Click();
        }

        [When]
        public void WhenIHaveTheBill()
        {
            yourSupplierPage.haveBillBt.Click();
        }

        [When]
        public void WhenIMoveToYourSupplierPage()
        {
            yourSupplierPage.nextBt.Click();
            WebDriverWait wait = new WebDriverWait(Browser.Driver(), TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("gas-current-spend")));
            energyPage = new EnergyPage();
        }

        [When]
        public void WhenIEnterMyExpenditures()
        {
            if (!energyPage.electricityUsageBox.Enabled)
            {
                energyPage.electricityNotKnown.Click();
            }
            if (!energyPage.gasUsageBox.Enabled)
            {
                energyPage.gasNotKnown.Click();
            }
            energyPage.electricityUsageBox.SendKeys("50");
            energyPage.gasUsageBox.SendKeys("50");
        }
        
        [When]
        public void WhenIDonTKnowMyExpenditures()
        {
            energyPage.electricityNotKnown.Click();
            energyPage.gasNotKnown.Click();
        }

        [When]
        public void WhenIMoveToTheEnergyCalculator()
        {
            energyPage.nextBt.Click();
            energyPage = null;
            WebDriverWait wait = new WebDriverWait(Browser.Driver(), TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("goto-person-details-button")));
            energyCalculatorPage = new EnergyCalculatorPage();
        }
        
        [Then]
        public void ThenICanViewTheResultsPage()
        {
            resultsPage.header.Text.ShouldBe("Your Results");
        }
        
        [Then]
        public void ThePreferencesScreenIsDisplayed()
        {
            preferencesPage.header.Text.ShouldBe("Your Preferences");
        }
        
        [When]
        public void WhenICanWorkOutMyEnergyUsage()
        {
            energyCalculatorPage.threeBedroomsIco.Click();
            energyCalculatorPage.threeOccupantsIco.Click();
            energyCalculatorPage.electricityHeatingIco.Click();
            energyCalculatorPage.temperateIco.Click();
            energyCalculatorPage.threeBedroomsIco.Click();
            energyCalculatorPage.threeBedroomsIco.Click();
            energyCalculatorPage.threeBedroomsIco.Click();
        }
    }
}
