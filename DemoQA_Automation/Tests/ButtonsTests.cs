using DemoQA_Automation.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoQA_Automation.Tests
{
    [TestClass]
    public class ButtonsTests
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
        public void SingleClickTest()
        {
            ButtonsPage buttonsPage = new ButtonsPage(driver!);

            buttonsPage.OpenButtonsPage();
            buttonsPage.SingleClick();

            Assert.AreEqual(
                "You have done a dynamic click",
                buttonsPage.GetClickMessage()
            );
        }

        [TestMethod]
        public void RightClickTest()
        {
            ButtonsPage buttonsPage = new ButtonsPage(driver!);

            buttonsPage.OpenButtonsPage();
            buttonsPage.RightClick();

            //Assert.AreEqual(
            //    "You have done a right click",
            //    buttonsPage.GetRightClickMessage()
            //);
        }

        [TestMethod]
        public void DoubleClickTest()
        {
            ButtonsPage buttonsPage = new ButtonsPage(driver!);

            buttonsPage.OpenButtonsPage();
            buttonsPage.DoubleClick();

            //Assert.AreEqual(
            //    "You have done a double click",
            //    buttonsPage.GetDoubleClickMessage()
            
        }
    }
}