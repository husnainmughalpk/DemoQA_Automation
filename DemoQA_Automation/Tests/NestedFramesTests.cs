using DemoQA_Automation.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoQA_Automation.Tests
{
    [TestClass]
    public class NestedFramesTests
    {
        private IWebDriver? driver;

        [TestInitialize]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void Cleanup()
        {
            driver?.Quit();
        }

        [TestMethod]
        public void ParentAndChildFrame_ShowExpectedText()
        {
            NestedFramesPage nestedFramesPage = new NestedFramesPage(driver!);
            nestedFramesPage.OpenNestedFramesPage();

            nestedFramesPage.SwitchToParentFrame();
            string parentText = nestedFramesPage.GetCurrentFrameBodyText();
            StringAssert.Contains(parentText, "Parent frame");

            nestedFramesPage.SwitchToChildFrame();
            string childText = nestedFramesPage.GetCurrentFrameBodyText();
            StringAssert.Contains(childText, "Child Iframe");

            nestedFramesPage.SwitchToDefaultContent();
        }
    }
}