using DemoQA_Automation.Base;
using OpenQA.Selenium;

namespace DemoQA_Automation.Pages
{
    public class NestedFramesPage : BasePage
    {
        private readonly By parentFrame = By.Id("frame1");
        private readonly By childFrame = By.TagName("iframe");

        public NestedFramesPage(IWebDriver driver) : base(driver) { }

        public void OpenNestedFramesPage()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/nestedframes");
        }

        public void SwitchToParentFrame()
        {
            driver.SwitchTo().Frame(driver.FindElement(parentFrame));
        }

        public void SwitchToChildFrame()
        {
            // Called while already inside the parent frame's context
            driver.SwitchTo().Frame(driver.FindElement(childFrame));
        }

        public void SwitchToDefaultContent()
        {
            driver.SwitchTo().DefaultContent();
        }

        public string GetCurrentFrameBodyText()
        {
            return driver.FindElement(By.TagName("body")).Text;
        }
    }
}