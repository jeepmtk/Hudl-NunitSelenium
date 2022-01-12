using System;
using NunitSelenium.TestCases;
using OpenQA.Selenium;

namespace NunitSelenium.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;

        public IWebElement UserName_textbox => driver.FindElement(By.Id("email"));
        public IWebElement Password_textbox => driver.FindElement(By.Id("password"));
        public IWebElement Login_button => driver.FindElement(By.Id("logIn"));

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public LoginPage Login(string name, string password)
        {
            UserName_textbox.Clear();
            UserName_textbox.SendKeys(name);
            Password_textbox.Clear();
            Password_textbox.SendKeys(password);
            Login_button.Click();

            return this;
        }

        public LoginPage ClickLogin()
        {
            Login_button.Click();

            return this;
        }
    }
}

