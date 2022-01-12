using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace NunitSelenium.TestCases.Helpers
{
    public class SetUpSteps
    {
        public IWebDriver driver;
        public SetUpSteps(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebDriver FirstSteps()
        {
            var browserType = TestContext.Parameters.Get("Browser", "chrome");

            string browserName = browserType;

            switch (browserName)
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;

                case "firefox":
                    driver = new FirefoxDriver();
                    break;

                default:
                    break;
            }

            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            return driver;
        }
    }
}
