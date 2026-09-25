using DemoQA_Automation.Base;
using OpenQA.Selenium;

namespace DemoQA_Automation.Pages
{
    public class LinksPage : BasePage
    {
        private By HomeLink = By.Id("simpleLink");
        private By DynamicHomeLink = By.Id("dynamicLink");

        private By CreatedLink = By.Id("created");
        private By NoContentLink = By.Id("no-content");
        private By MovedLink = By.Id("moved");
        private By BadRequestLink = By.Id("bad-request");
        private By UnauthorizedLink = By.Id("unauthorized");
        private By ForbiddenLink = By.Id("forbidden");
        private By NotFoundLink = By.Id("invalid-url");

        private By ResponseMessage = By.Id("()");

        public LinksPage(IWebDriver driver) : base(driver)
        {
        }

        public void OpenLinksPage()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/links");
        }

        public void ClickHome()
        {
            Click(HomeLink);
        }

        public void ClickDynamicHome()
        {
            Click(DynamicHomeLink);
        }

        public void ClickCreated()
        {
            Click(CreatedLink);
        }

        public void ClickNoContent()
        {
            Click(NoContentLink);
        }

        public void ClickMoved()
        {
            Click(MovedLink);
        }

        public void ClickBadRequest()
        {
            Click(BadRequestLink);
        }

        public void ClickUnauthorized()
        {
            Click(UnauthorizedLink);
        }

        public void ClickForbidden()
        {
            Click(ForbiddenLink);
        }

        public void ClickNotFound()
        {
            Click(NotFoundLink);
        }

        public string GetResponseMessage()
        {
            return driver.FindElement(ResponseMessage).Text;
        }

        public string GetCurrentUrl()
        {
            return driver.Url;
        }
    }
}