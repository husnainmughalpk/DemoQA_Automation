using DemoQA_Automation.Base;
using OpenQA.Selenium;

namespace DemoQA_Automation.Pages
{
    public class BrokenLinksImagesPage : BasePage
    {
        private By ValidImage = By.XPath("//*[@id=\"root\"]/div/div/div/div[2]/div[1]/img[1]");
        private By BrokenImage = By.XPath("//*[@id=\"root\"]/div/div/div/div[2]/div[1]/img[2]");
        private By ValidLink = By.XPath("//a[text()='Click Here for Valid Link']");
        private By BrokenLink = By.XPath("//a[text()='Click Here for Broken Link']");

        public BrokenLinksImagesPage(IWebDriver driver) : base(driver)
        {
        }

        public void OpenBrokenLinksImagesPage()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/broken");
        }

        public void ClickValidLink()
        {
            Click(ValidLink);
        }

        public void ClickBrokenLink()
        {
            Click(BrokenLink);
        }

        public bool IsValidImageDisplayed()
        {
            IWebElement image = driver.FindElement(ValidImage);

            return Convert.ToBoolean(
                ((IJavaScriptExecutor)driver).ExecuteScript(
                    "return arguments[0].complete && arguments[0].naturalWidth > 0;",
                    image)
            );
        }

        public bool IsBrokenImage()
        {
            IWebElement image = driver.FindElement(BrokenImage);

            return Convert.ToBoolean(
                ((IJavaScriptExecutor)driver).ExecuteScript(
                    "return arguments[0].complete && arguments[0].naturalWidth === 0;",
                    image)
            );
        }

        public string GetCurrentUrl()
        {
            return driver.Url;
        }
    }
}
