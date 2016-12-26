using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CTM.Support
{
    public class Browser
    {
        private static IWebDriver driver;
        public static string TestURL = "https://energy.comparethemarket.com/energy/v2/?AFFCLIE=TST";

        public static IWebDriver Driver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
            }
            return driver;
        }
    }
}
