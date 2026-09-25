using DemoQA_Automation.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoQA_Automation.Tests
{
    [TestClass]
    public class ModalDialogsTests
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
        public void SmallModal_ShowsTitleAndCloses()
        {
            ModalDialogsPage modalDialogsPage = new ModalDialogsPage(driver!);
            modalDialogsPage.OpenModalDialogsPage();

            modalDialogsPage.ClickShowSmallModal();

            string titleText = modalDialogsPage.GetSmallModalTitleText();
            Assert.AreEqual("Small Modal", titleText);

            modalDialogsPage.CloseSmallModal();
        }

        [TestMethod]
        public void LargeModal_ShowsTitleAndCloses()
        {
            ModalDialogsPage modalDialogsPage = new ModalDialogsPage(driver!);
            modalDialogsPage.OpenModalDialogsPage();

            modalDialogsPage.ClickShowLargeModal();

            string titleText = modalDialogsPage.GetLargeModalTitleText();
            Assert.AreEqual("Large Modal", titleText);

            modalDialogsPage.CloseLargeModal();
        }
    }
}