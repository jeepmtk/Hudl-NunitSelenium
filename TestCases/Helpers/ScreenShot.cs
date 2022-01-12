using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NunitSelenium.Pages;
using NunitSelenium.TestCases.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace NunitSelenium.TestCases.Helpers
{
    public class ScreenShot
    {
        public IWebDriver driver;

        public ScreenShot(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void takeScreenShot()
        {
            //Checks to see if there were any errors in the scenario and if there were, take a screenshot of the browser
            if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Passed)
            {
                string fileName = TestContext.CurrentContext.Test.Name.ToString() + ".png";
                //takes the screenshot
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                string setPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\ScreenShotOnFail\\";
                //adds the date to the name file
                string runName = fileName + "-" + DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss") + ".png";
                //combines the path
                string path = System.IO.Path.Combine(setPath, runName);
                //saves the file
                ss.SaveAsFile(path, OpenQA.Selenium.ScreenshotImageFormat.Png);

                Console.Write("See the screen shot on fail for this scenario at " + path);
                TestContext.AddTestAttachment(path, "My Screenshot");
            }
        }
    }
}
