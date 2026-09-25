using System;
using DemoQA_Automation.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DemoQA_Automation.Pages
{
    public class ModalDialogsPage : BasePage
    {
        private readonly By showSmallModalButton = By.Id("showSmallModal");
        private readonly By smallModalTitle = By.Id("example-modal-sizes-title-sm");
        private readonly By closeSmallModalButton = By.Id("closeSmallModal");

        private readonly By showLargeModalButton = By.Id("showLargeModal");
        private readonly By largeModalTitle = By.Id("example-modal-sizes-title-lg");
        private readonly By closeLargeModalButton = By.Id("closeLargeModal");

        public ModalDialogsPage(IWebDriver driver) : base(driver) { }

        public void OpenModalDialogsPage()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/modal-dialogs");
        }

        public void ClickShowSmallModal()
        {
            Click(showSmallModalButton);
        }

        public void ClickShowLargeModal()
        {
            Click(showLargeModalButton);
        }

        public string GetSmallModalTitleText()
        {
            return WaitForNonEmptyText(smallModalTitle);
        }

        public string GetLargeModalTitleText()
        {
            return WaitForNonEmptyText(largeModalTitle);
        }

        public void CloseSmallModal()
        {
            Click(closeSmallModalButton);
        }

        public void CloseLargeModal()
        {
            Click(closeLargeModalButton);
        }

        // The modal fades in, so the title element can exist in the DOM slightly
        // before its text is actually populated. Wait for real text instead of
        // reading it the instant after the click.
        private string WaitForNonEmptyText(By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            return wait.Until(d =>
            {
                string text = d.FindElement(locator).Text;
                return string.IsNullOrEmpty(text) ? null : text;
            });
        }
    }
}