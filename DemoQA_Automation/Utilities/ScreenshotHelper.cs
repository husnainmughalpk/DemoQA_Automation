using OpenQA.Selenium;

namespace DemoQA_Automation.Utilities
{
    public static class ScreenshotHelper
    {
        public static void TakeScreenshot(IWebDriver driver, string testName)
        {
            string folderPath = ConfigReader.GetScreenshotPath();
            Console.WriteLine($"Screenshot Path: {Path.GetFullPath(folderPath)}");

            // Folder nahi hai toh banao
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            string fileName = $"{testName}_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.png";
            string fullPath = Path.Combine(folderPath, fileName);

            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(fullPath);

            Console.WriteLine($"Screenshot saved: {fullPath}");
        }
    }
}