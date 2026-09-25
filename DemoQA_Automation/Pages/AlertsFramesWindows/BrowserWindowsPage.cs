using DemoQA_Automation.Base;
using OpenQA.Selenium;

namespace DemoQA_Automation.Pages
{
    public class BrowserWindowsPage : BasePage
    {
        private readonly By newTabButton = By.Id("tabButton");
        private readonly By newWindowButton = By.Id("windowButton");
        private readonly By newWindowMessageButton = By.Id("messageWindowButton");
        private readonly By sampleHeading = By.Id("sampleHeading");

        public BrowserWindowsPage(IWebDriver driver) : base(driver) { }

        public void OpenBrowserWindowsPage()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/browser-windows");
        }

        public void ClickNewTab()
        {
            Click(newTabButton);
        }

        public void ClickNewWindow()
        {
            Click(newWindowButton);
        }

        public void ClickNewWindowMessage()
        {
            Click(newWindowMessageButton);
        }

        public string GetSampleHeadingText()
        {
            return driver.FindElement(sampleHeading).Text;
        }

        public string GetBodyText()
        {
            
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            return js.ExecuteScript("return document.body.innerText;")?.ToString() ?? string.Empty;
        }
    }
}