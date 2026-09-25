using System;
using DemoQA_Automation.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DemoQA_Automation.Tests
{
    [TestClass]
    public class BrowserWindowsTests
    {
        private IWebDriver? driver;

        [TestInitialize]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();

            // Disable the pop-up blocker: DemoQA's "New Window" buttons use window.open(),
            // which Chrome can silently block, leaving WindowHandles.Count stuck at 1.
            options.AddArgument("--disable-popup-blocking");

            // Newer Chrome versions block cross-origin DevTools WebSocket connections
            // by default. Without this, commands sent to a window opened via
            // window.open() (no target URL) can hang indefinitely instead of failing fast.
            options.AddArgument("--remote-allow-origins=*");

            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void Cleanup()
        {
            driver?.Quit();
        }

        // Waits until a new window handle actually appears, instead of assuming
        // it's there the instant after the click. Returns the new handle.
        private string WaitForNewWindowHandle(string originalWindow)
        {
            WebDriverWait wait = new WebDriverWait(driver!, TimeSpan.FromSeconds(10));
            wait.Until(d => d.WindowHandles.Count > 1);

            foreach (string handle in driver!.WindowHandles)
            {
                if (handle != originalWindow)
                {
                    return handle;
                }
            }

            throw new NoSuchWindowException("No new window handle appeared within the timeout.");
        }

        [TestMethod]
        public void NewTab_OpensSamplePage()
        {
            BrowserWindowsPage browserWindowsPage = new BrowserWindowsPage(driver!);
            browserWindowsPage.OpenBrowserWindowsPage();

            string originalWindow = driver!.CurrentWindowHandle;

            browserWindowsPage.ClickNewTab();

            string newWindow = WaitForNewWindowHandle(originalWindow);
            driver.SwitchTo().Window(newWindow);

            string headingText = browserWindowsPage.GetSampleHeadingText();
            Assert.AreEqual("This is a sample page", headingText);

            driver.Close();
            driver.SwitchTo().Window(originalWindow);
        }

        [TestMethod]
        public void NewWindow_OpensSamplePage()
        {
            BrowserWindowsPage browserWindowsPage = new BrowserWindowsPage(driver!);
            browserWindowsPage.OpenBrowserWindowsPage();

            string originalWindow = driver!.CurrentWindowHandle;

            browserWindowsPage.ClickNewWindow();

            string newWindow = WaitForNewWindowHandle(originalWindow);
            driver.SwitchTo().Window(newWindow);

            string headingText = browserWindowsPage.GetSampleHeadingText();
            Assert.AreEqual("This is a sample page", headingText);

            driver.Close();
            driver.SwitchTo().Window(originalWindow);
        }

        [TestMethod]
        public void NewWindowMessage_OpensWindowWithMessage()
        {
            BrowserWindowsPage browserWindowsPage = new BrowserWindowsPage(driver!);
            browserWindowsPage.OpenBrowserWindowsPage();

            string originalWindow = driver!.CurrentWindowHandle;

            browserWindowsPage.ClickNewWindowMessage();

            string newWindow = WaitForNewWindowHandle(originalWindow);
            driver.SwitchTo().Window(newWindow);

            string bodyText = browserWindowsPage.GetBodyText();
            StringAssert.Contains(bodyText, "This is a sample page");

            driver.Close();
            driver.SwitchTo().Window(originalWindow);
        }
    }
}