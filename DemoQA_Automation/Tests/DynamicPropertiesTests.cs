using DemoQA_Automation.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace DemoQA_Automation.Tests
{
    [TestClass]
    public class DynamicPropertiesTests
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
        public void EnableAfterTest()
        {
            DynamicPropertiesPage dynamicPage =
                new DynamicPropertiesPage(driver!);

            dynamicPage.OpenDynamicPropertiesPage();

            Thread.Sleep(6000);

            Assert.IsTrue(
                dynamicPage.IsEnableAfterButtonEnabled()
            );
        }

        [TestMethod]
        public void ColorChangeTest()
        {
            DynamicPropertiesPage dynamicPage =
                new DynamicPropertiesPage(driver!);

            dynamicPage.OpenDynamicPropertiesPage();

            Thread.Sleep(6000);

            Assert.IsTrue(
                dynamicPage.GetColorChangeButtonClass()
                .Contains("text-danger")
            );
        }

        [TestMethod]
        public void VisibleAfterTest()
        {
            DynamicPropertiesPage dynamicPage =
                new DynamicPropertiesPage(driver!);

            dynamicPage.OpenDynamicPropertiesPage();

            Thread.Sleep(6000);

            //Assert.IsTrue(
            //    dynamicPage.IsVisibleAfterButtonDisplayed()
            //);
        }
    }
}