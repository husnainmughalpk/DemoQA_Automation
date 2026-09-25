using OpenQA.Selenium;

namespace DemoQA_Automation.Base
{
    public class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        protected void Type(By locator, string value)
        {
            driver.FindElement(locator).SendKeys(value);
        }

        protected void Click(By locator)
        {
            driver.FindElement(locator).Click();
        }

        protected string GetText(By locator)
        {
            return driver.FindElement(locator).Text;
        }

        protected bool IsDisplayed(By locator)
        {
            return driver.FindElement(locator).Displayed;
        }

        public void ScrollToElement(By locator)
        {
            IWebElement element = driver.FindElement(locator);

            ((IJavaScriptExecutor)driver).ExecuteScript(
                "arguments[0].scrollIntoView({block: 'center'});",
                element);
        }
    }
}