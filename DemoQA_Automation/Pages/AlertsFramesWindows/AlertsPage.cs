using DemoQA_Automation.Base;
using OpenQA.Selenium;

namespace DemoQA_Automation.Pages
{
    public class AlertsPage : BasePage
    {
        private readonly By alertButton = By.Id("alertButton");
        private readonly By timerAlertButton = By.Id("timerAlertButton");
        private readonly By confirmButton = By.Id("confirmButton");
        private readonly By confirmResult = By.Id("confirmResult");
        private readonly By promptButton = By.Id("promtButton"); // DemoQA's actual id has this typo
        private readonly By promptResult = By.Id("promptResult");

        public AlertsPage(IWebDriver driver) : base(driver) { }

        public void OpenAlertsPage()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/alerts");
        }

        public void ClickSimpleAlertButton()
        {
            Click(alertButton);
        }

        public void ClickTimerAlertButton()
        {
            Click(timerAlertButton);
        }

        public void ClickConfirmButton()
        {
            Click(confirmButton);
        }

        public void ClickPromptButton()
        {
            Click(promptButton);
        }

        public string GetConfirmResultText()
        {
            return driver.FindElement(confirmResult).Text;
        }

        public string GetPromptResultText()
        {
            return driver.FindElement(promptResult).Text;
        }
    }
}