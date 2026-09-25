using DemoQA_Automation.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoQA_Automation.Tests
{
    [TestClass]
    public class BrokenLinksImagesTests
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
        public void ValidImageTest()
        {
            BrokenLinksImagesPage brokenPage =
                new BrokenLinksImagesPage(driver!);

            brokenPage.OpenBrokenLinksImagesPage();

            //Assert.IsTrue(
            //    brokenPage.IsValidImageDisplayed()
            //);
        }

        [TestMethod]
        public void BrokenImageTest()
        {
            BrokenLinksImagesPage brokenPage =
                new BrokenLinksImagesPage(driver!);

            brokenPage.OpenBrokenLinksImagesPage();

            //Assert.IsTrue(
            //    brokenPage.IsBrokenImage()
            //);
        }

        [TestMethod]
        public void ValidLinkTest()
        {
            BrokenLinksImagesPage brokenPage =
                new BrokenLinksImagesPage(driver!);

            brokenPage.OpenBrokenLinksImagesPage();

            brokenPage.ClickValidLink();

            //Assert.AreEqual(
            //    "https://the-internet.herokuapp.com/status_codes/500",
            //    brokenPage.GetCurrentUrl()
           
        }

        [TestMethod]
        public void BrokenLinkTest()
        {
            BrokenLinksImagesPage brokenPage =
                new BrokenLinksImagesPage(driver!);

            brokenPage.OpenBrokenLinksImagesPage();

            brokenPage.ClickBrokenLink();

            //Assert.AreEqual(
            //    "https://demoqa.com/broken",
            //    brokenPage.GetCurrentUrl()
           
        }
    }
}