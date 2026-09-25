using DemoQA_Automation.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace DemoQA_Automation.Pages
{
    public class ButtonsPage : BasePage
    {
        private By DoubleClickButton = By.Id("doubleClickBtn");
        private By RightClickButton = By.Id("rightClickBtn");
        private By ClickMeButton = By.XPath("//button[text()='Click Me']");

        private By DoubleClickMessage = By.Id("doubleClickMessage");
        private By RightClickMessage = By.Id("rightClickMessage");
        private By ClickMessage = By.Id("dynamicClickMessage");

        public ButtonsPage(IWebDriver driver) : base(driver)
        {
        }

        public void OpenButtonsPage()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/buttons");
        }

        public void DoubleClick()
        {
            IWebElement button = driver.FindElement(DoubleClickButton);

            ScrollToElement(DoubleClickButton);

            Actions actions = new Actions(driver);
            actions.DoubleClick(button).Perform();
        }

        public void RightClick()
        {
            IWebElement button = driver.FindElement(RightClickButton);

            ScrollToElement(RightClickButton);

            Actions actions = new Actions(driver);
            actions.ContextClick(button).Perform();
        }

        public void SingleClick()
        {
            Click(ClickMeButton);
        }

        public string GetDoubleClickMessage()
        {
            return driver.FindElement(DoubleClickMessage).Text;
        }

        public string GetRightClickMessage()
        {
            return driver.FindElement(RightClickMessage).Text;
        }

        public string GetClickMessage()
        {
            return driver.FindElement(ClickMessage).Text;
        }
    }
}