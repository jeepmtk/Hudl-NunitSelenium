using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NunitSelenium.TestCases
{
    class ExpectedConditionWaits
    {
        // Expected Condition Waits 
        private readonly IWebDriver driver;

        public ExpectedConditionWaits(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void WaitForTitleIs(string title, int time)
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TitleIs(title));

        }

        public void WaitForElementPresentByType(string type, string path, int time)
        {


            if (type.Equals("css"))
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(path)));
            }

            else if (type.Equals("id"))
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(path)));
            }

            if (type.Equals("xpath"))
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(path)));
            }

            if (type.Equals("linktext"))
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText(path)));
            }
        }

        public void WaitForElementToBeClickableByType(string type, string path, int time)
        {

            if (type.Equals("css"))
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(path)));
            }

            else if (type.Equals("id"))
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(path)));
            }

            if (type.Equals("xpath"))
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(path)));
            }

            if (type.Equals("linktext"))
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.LinkText(path)));
            };
        }

        public void WaitForInvisibilityOfElementLocatedByType(string type, string path, int time)
        {

            if (type.Equals("css"))
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.CssSelector(path)));
            }

            else if (type.Equals("id"))
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id(path)));
            }

            if (type.Equals("xpath"))
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.XPath(path)));
            }

            if (type.Equals("linktext"))
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.LinkText(path)));
            };
        }
        public void WaitForElementIsVisibleByType(string type, string path, int time)
        {

            if (type.Equals("css"))
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(path)));
            }

            else if (type.Equals("id"))
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(path)));
            }

            if (type.Equals("xpath"))
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(path)));
            }

            if (type.Equals("linktext"))
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.LinkText(path)));
            };
        }

        //Text waits
        public void WaitForTextToBePresentInElementLocatedByType(string type, string path, string text, int time)
        {

            if (type.Equals("css"))
            {
                Console.WriteLine(type);
                Console.WriteLine(path);
                Console.WriteLine(text);
                Console.WriteLine(time);

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElementLocated(By.CssSelector(path), text));
            }

            else if (type.Equals("id"))
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElementLocated(By.Id(path), text));
            }

            if (type.Equals("xpath"))
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElementLocated(By.XPath(path), text));
            }

            if (type.Equals("linktext"))
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElementLocated(By.LinkText(path), text));
            };
        }

        //Url waits
        public void WaitForUrlMatches(string url, int time)
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlMatches(url));

        }

        public void WaitForUrlContains(string url, int time)
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains(url));

        }

        public void WaitForUrlToBe(string url, int time)
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe(url));

        }

        public void WaitForTitleContains(string title, int time)
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TitleContains(title));

        }
        public void WaitForSeconds(int seconds)
        {
            Thread.Sleep(seconds);
        }
    }
}


