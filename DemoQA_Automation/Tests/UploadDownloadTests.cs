using DemoQA_Automation.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoQA_Automation.Tests
{
    [TestClass]
    public class UploadDownloadTests
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
        public void UploadFileTest()
        {
            UploadDownloadPage uploadPage =
                new UploadDownloadPage(driver!);

            uploadPage.OpenUploadDownloadPage();

            uploadPage.UploadFile(
                @"C:\Users\mughahus\Downloads\Coursera E6COA23V6NWG_page-0001.jpg"
            );

            //Assert.IsTrue(
            //    uploadPage.GetUploadedFilePath().Contains("TestFile.txt")
            //);
        }

        [TestMethod]
        public void DownloadFileTest()
        {
            UploadDownloadPage uploadPage =
                new UploadDownloadPage(driver!);

            uploadPage.OpenUploadDownloadPage();

            uploadPage.DownloadFile();

            //Assert.IsTrue(true);
        }
    }
}