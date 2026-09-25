using DemoQA_Automation.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoQA_Automation.Tests
{
    [TestClass]
    public class FramesTests
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
        public void Frame1_ShowsExpectedText()
        {
            FramesPage framesPage = new FramesPage(driver!);
            framesPage.OpenFramesPage();

            framesPage.SwitchToFrame1();
            string frame1Text = framesPage.GetHeadingTextInsideFrame();
            Assert.AreEqual("This is a sample page", frame1Text);

            framesPage.SwitchToDefaultContent();
        }

        [TestMethod]
        public void Frame2_ShowsExpectedText()
        {
            FramesPage framesPage = new FramesPage(driver!);
            framesPage.OpenFramesPage();

            framesPage.SwitchToFrame2();
            string frame2Text = framesPage.GetHeadingTextInsideFrame();
            Assert.AreEqual("This is a sample page", frame2Text);

            framesPage.SwitchToDefaultContent();
        }
    }
}