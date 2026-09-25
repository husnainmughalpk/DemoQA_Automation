using DemoQA_Automation.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoQA_Automation.Tests
{
    [TestClass]
    public class AlertsTests
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
        public void SimpleAlert_ShowsCorrectTextAndAccepts()
        {
            AlertsPage alertsPage = new AlertsPage(driver!);
            alertsPage.OpenAlertsPage();

            alertsPage.ClickSimpleAlertButton();

            IAlert alert = driver!.SwitchTo().Alert();
            Assert.AreEqual("You clicked a button", alert.Text);

            alert.Accept();
        }

        [TestMethod]
        public void ConfirmAlert_AcceptShowsOkResult()
        {
            AlertsPage alertsPage = new AlertsPage(driver!);
            alertsPage.OpenAlertsPage();

            alertsPage.ClickConfirmButton();

            IAlert alert = driver!.SwitchTo().Alert();
            Assert.AreEqual("Do you confirm action?", alert.Text);

            alert.Accept();

            string resultText = alertsPage.GetConfirmResultText();
            Assert.AreEqual("You selected Ok", resultText);
        }

        [TestMethod]
        public void ConfirmAlert_DismissShowsCancelResult()
        {
            AlertsPage alertsPage = new AlertsPage(driver!);
            alertsPage.OpenAlertsPage();

            alertsPage.ClickConfirmButton();

            IAlert alert = driver!.SwitchTo().Alert();
            alert.Dismiss();

            string resultText = alertsPage.GetConfirmResultText();
            Assert.AreEqual("You selected Cancel", resultText);
        }

        [TestMethod]
        public void PromptAlert_SendTextAndAcceptShowsResult()
        {
            AlertsPage alertsPage = new AlertsPage(driver!);
            alertsPage.OpenAlertsPage();

            alertsPage.ClickPromptButton();

            IAlert alert = driver!.SwitchTo().Alert();
            Assert.AreEqual("Please enter your name", alert.Text);

            alert.SendKeys("Husnain");
            alert.Accept();

            string resultText = alertsPage.GetPromptResultText();
            Assert.AreEqual("You entered Husnain", resultText);
        }
    }
}