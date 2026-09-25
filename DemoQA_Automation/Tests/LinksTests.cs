using DemoQA_Automation.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoQA_Automation.Tests
{
    [TestClass]
    public class LinksTests
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
        public void HomeLinkTest()
        {
            LinksPage linksPage = new LinksPage(driver!);

            linksPage.OpenLinksPage();
            linksPage.ClickHome();

            //Assert.AreEqual(
            //    "https://demoqa.com/",
            //    linksPage.GetCurrentUrl()
            //);
        }

        [TestMethod]
        public void DynamicHomeLinkTest()
        {
            LinksPage linksPage = new LinksPage(driver!);

            linksPage.OpenLinksPage();
            linksPage.ClickDynamicHome();

            //Assert.AreEqual(
            //    "https://demoqa.com/",
            //    linksPage.GetCurrentUrl()
            //);
        }

        [TestMethod]
        public void CreatedLinkTest()
        {
            LinksPage linksPage = new LinksPage(driver!);

            linksPage.OpenLinksPage();
            linksPage.ClickCreated();

            //Assert.IsTrue(
            //    linksPage.GetResponseMessage().Contains("201")
            //);
        }

        [TestMethod]
        public void NoContentLinkTest()
        {
            LinksPage linksPage = new LinksPage(driver!);

            linksPage.OpenLinksPage();
            linksPage.ClickNoContent();

            //Assert.IsTrue(
            //    linksPage.GetResponseMessage().Contains("204")
            //);
        }

        [TestMethod]
        public void MovedLinkTest()
        {
            LinksPage linksPage = new LinksPage(driver!);

            linksPage.OpenLinksPage();
            linksPage.ClickMoved();

            //Assert.IsTrue(
            //    linksPage.GetResponseMessage().Contains("301")
            //);
        }

        [TestMethod]
        public void BadRequestLinkTest()
        {
            LinksPage linksPage = new LinksPage(driver!);

            linksPage.OpenLinksPage();
            linksPage.ClickBadRequest();

            //Assert.IsTrue(
            //    linksPage.GetResponseMessage().Contains("400")
            //);
        }

        [TestMethod]
        public void UnauthorizedLinkTest()
        {
            LinksPage linksPage = new LinksPage(driver!);

            linksPage.OpenLinksPage();
            linksPage.ClickUnauthorized();

            //Assert.IsTrue(
            //    linksPage.GetResponseMessage().Contains("401")
            //);
        }

        [TestMethod]
        public void ForbiddenLinkTest()
        {
            LinksPage linksPage = new LinksPage(driver!);

            linksPage.OpenLinksPage();
            linksPage.ClickForbidden();

            //Assert.IsTrue(
            //    linksPage.GetResponseMessage().Contains("403")
            //);
        }

        [TestMethod]
        public void NotFoundLinkTest()
        {
            LinksPage linksPage = new LinksPage(driver!);

            linksPage.OpenLinksPage();
            linksPage.ClickNotFound();

            //Assert.IsTrue(
            //    linksPage.GetResponseMessage().Contains("404")
            //);
        }
    }
}