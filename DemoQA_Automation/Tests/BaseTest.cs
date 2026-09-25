// Base/BaseTest.cs — final update
using DemoQA_Automation.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoQA_Automation.Base
{
    public class BaseTest
    {
        protected IWebDriver driver = null!;

        // TestContext se test name aur status milta hai MSTest mein
        public TestContext TestContext { get; set; } = null!;

        [TestInitialize]
        public void Setup()
        {
            string browser = ConfigReader.GetBrowser();
            int wait = ConfigReader.GetImplicitWait();

            driver = browser.ToLower() switch
            {
                "chrome" => new ChromeDriver(),
                _ => new ChromeDriver()
            };

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait =
                TimeSpan.FromSeconds(wait);
        }

        [TestCleanup]
        public void Cleanup()
        {
           
            if (TestContext.CurrentTestOutcome == UnitTestOutcome.Failed)
            {
                ScreenshotHelper.TakeScreenshot(driver, TestContext.TestName!);
            }

            driver?.Quit();
        }
    }
}