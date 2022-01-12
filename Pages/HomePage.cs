using OpenQA.Selenium;

namespace NunitSelenium.Pages
{
    public class HomePage
    {
        private readonly IWebDriver driver;

        public IWebElement UserName_textbox => driver.FindElement(By.Id("email"));

        public IWebElement Display_Name => driver.FindElement(By.CssSelector("div[class='hui-globaluseritem__display-name']"));
        public IWebElement Logout_Link => driver.FindElement(By.LinkText("Log Out"));

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public HomePage Logout()
        {
            Display_Name.Click();
            Logout_Link.Click();

            return this;
        }
    }
}


