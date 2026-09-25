using DemoQA_Automation.Base;
using OpenQA.Selenium;

namespace DemoQA_Automation.Pages
{
    public class DynamicPropertiesPage : BasePage
    {
        private By EnableAfterButton = By.Id("enableAfter");
        private By ColorChangeButton = By.Id("colorChange");
        private By VisibleAfterButton = By.Id("visibleAfter");

        public DynamicPropertiesPage(IWebDriver driver) : base(driver)
        {
        }

        public void OpenDynamicPropertiesPage()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/dynamic-properties");
        }

        public bool IsEnableAfterButtonEnabled()
        {
            return driver.FindElement(EnableAfterButton).Enabled;
        }

        public string GetColorChangeButtonClass()
        {
            return driver.FindElement(ColorChangeButton)
                .GetAttribute("class") ?? "";
        }

        public bool IsVisibleAfterButtonDisplayed()
        {
            return driver.FindElement(VisibleAfterButton).Displayed;
        }
    }
}