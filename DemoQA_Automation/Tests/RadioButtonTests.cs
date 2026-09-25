using DemoQA_Automation.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoQA_Automation.Tests
{
    [TestClass]
    public class RadioButtonTests
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
        public void YesRadioButtonTest()
        {
            RadioButtonPage radioButtonPage = new RadioButtonPage(driver!);

            radioButtonPage.OpenRadioButtonPage();
            radioButtonPage.SelectYes();

            Assert.AreEqual(
                "Yes",
                radioButtonPage.GetResultText()
            );
        }

        [TestMethod]
        public void ImpressiveRadioButtonTest()
        {
            RadioButtonPage radioButtonPage = new RadioButtonPage(driver!);
            radioButtonPage.OpenRadioButtonPage();
            radioButtonPage.SelectImpressive();

            Assert.AreEqual(
                "Impressive", radioButtonPage.GetResultText()
            );
        }
    }
}