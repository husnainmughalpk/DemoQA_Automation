using DemoQA_Automation.Base;
using OpenQA.Selenium;

namespace DemoQA_Automation.Pages
{
    public class FramesPage : BasePage
    {
        private readonly By frame1 = By.Id("frame1");
        private readonly By frame2 = By.Id("frame2");
        private readonly By sampleHeading = By.Id("sampleHeading");

        public FramesPage(IWebDriver driver) : base(driver) { }

        public void OpenFramesPage()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/frames");
        }

        public void SwitchToFrame1()
        {
            driver.SwitchTo().Frame(driver.FindElement(frame1));
        }

        public void SwitchToFrame2()
        {
            driver.SwitchTo().Frame(driver.FindElement(frame2));
        }

        public void SwitchToDefaultContent()
        {
            driver.SwitchTo().DefaultContent();
        }

        public string GetHeadingTextInsideFrame()
        {
            return driver.FindElement(sampleHeading).Text;
        }
    }
}