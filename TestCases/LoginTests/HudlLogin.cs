using NUnit.Framework;
using NunitSelenium.Pages;
using NunitSelenium.TestCases.Helpers;
using OpenQA.Selenium;


namespace NunitSelenium.TestCases
{
    public class BaseClass
    {
        //contains driver setup, globals etc.
        public IWebDriver driver;
        public string browserName = "";

        [SetUp]
        public void Setup()
        {
            SetUpSteps sp = new SetUpSteps(driver);
            driver = sp.FirstSteps();
        }
    }

    [TestFixture(Description = "Login Test Suite")]
    public class HudlLogin : BaseClass
    {
        ExpectedConditionWaits Ecw => new ExpectedConditionWaits(driver);
        LoginPage Lp => new LoginPage(driver);
        HomePage Hp => new HomePage(driver);
        ScreenShot ScreenShot => new ScreenShot(driver);

        readonly HudlAccess Ha = new HudlAccess();

        [SetUp]
        public void Login()
        {
            //nav to the site
            driver.Navigate().GoToUrl(Ha.LoginUrl);
            //verify the form displays
            Ecw.WaitForElementToBeClickableByType("id", "logIn", 15);
        }

        [TearDown]
        public void End()
        {
            ScreenShot.takeScreenShot();
            driver.Close();
            driver.Quit();
        }

        [Test]
        public void ShouldBeAbleToLogin()
        {
            //login
            Lp.Login(Ha.Email, Ha.Password);
            //verify
            Ecw.WaitForTitleContains("Home - Hudl", 30);
        }

        [Test]
        public void ShouldBeAbleToCheckLoginFieldsWithNoEntry()
        {
            //login w/o info
            Lp.ClickLogin();

            //verify need help displays
            Ecw.WaitForElementIsVisibleByType("xpath", "//a[contains(text(),'" + Ha.NeedHelpMessage + "')]", 30);
        }

        [Test]
        public void ShouldBeAbleToCheckLoginInvalidEmailPassword()
        {
            //login
            Lp.Login("test@test.com", "password123");

            //verify need help displays
            Ecw.WaitForElementIsVisibleByType("xpath", "//a[contains(text(),'" + Ha.NeedHelpMessage + "')]", 30);
        }

        [Test]
        public void ShouldBeAbleToLogout()
        {
            //contains some to do examples to show hardine examples...

            //TODO: consolidate login action
            //login 
            Lp.Login(Ha.Email, Ha.Password);
            Ecw.WaitForTitleContains("Home - Hudl", 30);

            //TODO: consolidate logout action
            //logout
            Hp.Logout();

            //TODO: verify the login page displays - param the title
            Ecw.WaitForTitleContains("Hudl: We Help Teams and Athletes Win", 30);
        }

        //Support Methods
        //use this section for test fixture specific

    }
}
