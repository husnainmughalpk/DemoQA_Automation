using DemoQA_Automation.Base;
using OpenQA.Selenium;

namespace DemoQA_Automation.Pages
{
    public class RadioButtonPage : BasePage
    {
        private By YesRadioButton = By.Id("yesRadio");
        private By ImpressiveRadioButton = By.Id("impressiveRadio");
        private By ResultText = By.ClassName("text-success");

        public RadioButtonPage(IWebDriver driver) : base(driver)
        {
        }

        public void OpenRadioButtonPage()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/radio-button");
        }

        public void SelectYes()
        {
            Click(YesRadioButton);
        }

        public void SelectImpressive()
        {
            Click(ImpressiveRadioButton);
        }

        public string GetResultText()
        {
            return driver.FindElement(ResultText).Text;
        }
    }
}