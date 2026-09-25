using DemoQA_Automation.Base;
using OpenQA.Selenium;

namespace DemoQA_Automation.Pages
{
    public class UploadDownloadPage : BasePage
    {
        private By UploadButton = By.Id("uploadFile");
        private By UploadedFilePath = By.Id("uploadedFilePath");
        private By DownloadButton = By.Id("downloadButton");

        public UploadDownloadPage(IWebDriver driver) : base(driver)
        {
        }

        public void OpenUploadDownloadPage()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/upload-download");
        }

        public void UploadFile(string filePath)
        {
            driver.FindElement(UploadButton).SendKeys(filePath);
        }

        public string GetUploadedFilePath()
        {
            return driver.FindElement(UploadedFilePath).Text;
        }

        public void DownloadFile()
        {
            Click(DownloadButton);
        }
    }
}