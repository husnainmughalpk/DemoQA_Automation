using DemoQA_Automation.Base;
using OpenQA.Selenium;

namespace DemoQA_Automation.Pages
{
    public class CheckBoxPage : BasePage
    {
        private By HomeCheckbox = By.XPath("//span[text()='Home']");
        private By ResultText = By.Id("display-result mt-4");

        public CheckBoxPage(IWebDriver driver) : base(driver)
        {
        }

        public void CheckHome()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/checkbox");

            Click(HomeCheckbox);
        }

        public string GetCheckboxText()
        {
            return driver.FindElement(ResultText).Text;
        }
    }
}