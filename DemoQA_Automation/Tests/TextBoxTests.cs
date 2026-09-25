using DemoQA_Automation.Base;
using DemoQA_Automation.Pages;
using DemoQA_Automation.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoQA_Automation.Tests
{
    [TestClass]
    public class TextBoxTests : BaseTest
    {
        private IWebDriver? driver;

        [TestInitialize]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://demoqa.com/text-box");
        }

        [TestMethod]
        public void TextBoxTest()
        {
            TextBoxPage textBoxPage = new TextBoxPage(driver!);

            textBoxPage.TextBox(
                "Husnain",
                "test@gmail.com",
                "Lahore",
                "Lahore"
            );


            Assert.AreEqual("Name:Husnain", textBoxPage.GetName());
            Assert.AreEqual("Email:test@gmail.com", textBoxPage.GetEmail());
            Assert.AreEqual("Current Address :Lahore", textBoxPage.GetCurrentAddress());
            Assert.AreEqual("Permananet Address :Lahore", textBoxPage.GetPermanentAddress());
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