using DemoQA_Automation.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoQA_Automation.Tests
{
    [TestClass]
    public class CheckBoxTests
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
        public void CheckBoxTest()
        {
            CheckBoxPage checkBoxPage = new CheckBoxPage(driver!);

            checkBoxPage.CheckHome(); }

            //Assert.AreEqual(
            //    "You have selected :\r\nhome",
            //    checkBoxPage.GetCheckboxText()
            //);
        }
}