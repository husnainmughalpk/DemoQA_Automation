using DemoQA_Automation.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoQA_Automation.Tests
{
    [TestClass]
    public class WebTablesTests 
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
        public void AddRecordTest()
        {
            WebTablesPage webTablesPage = new WebTablesPage(driver!);

            webTablesPage.OpenWebTablesPage();

            webTablesPage.AddRecord(
                "Husnain",
                "Mughal",
                "husnain@gmail.com",
                "25",
                "50000",
                "SQA"
            );

            Assert.AreEqual("Husnain", webTablesPage.GetFirstName());
            Assert.AreEqual("Mughal", webTablesPage.GetLastName());
            Assert.AreEqual("husnain@gmail.com", webTablesPage.GetEmail());
            Assert.AreEqual("25", webTablesPage.GetAge());
            Assert.AreEqual("50000", webTablesPage.GetSalary());
            Assert.AreEqual("SQA", webTablesPage.GetDepartment());

        }
    }
}