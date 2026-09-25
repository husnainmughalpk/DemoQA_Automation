using DemoQA_Automation.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoQA_Automation.Tests
{
    [TestClass]
    public class PracticeFormTests
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
        public void FillForm_SubmitsAndShowsCorrectDataInModal()
        {
            PracticeFormPage practiceFormPage = new PracticeFormPage(driver!);
            practiceFormPage.OpenPracticeFormPage();

            practiceFormPage.EnterFirstName("John");
            practiceFormPage.EnterLastName("Doe");
            practiceFormPage.EnterEmail("john.doe@example.com");
            practiceFormPage.SelectMale();
            practiceFormPage.EnterMobile("9876543210");
            practiceFormPage.EnterSubject("Maths");
            practiceFormPage.SelectSports();
            practiceFormPage.EnterCurrentAddress("123 Main Street, Lahore");

            practiceFormPage.SubmitForm();

            string modalText = practiceFormPage.GetSubmissionData();

            StringAssert.Contains(modalText, "John Doe");
            StringAssert.Contains(modalText, "john.doe@example.com");
            StringAssert.Contains(modalText, "Male");
            StringAssert.Contains(modalText, "9876543210");
            StringAssert.Contains(modalText, "Maths");
            StringAssert.Contains(modalText, "Sports");
            StringAssert.Contains(modalText, "123 Main Street, Lahore");
        }
    }
}