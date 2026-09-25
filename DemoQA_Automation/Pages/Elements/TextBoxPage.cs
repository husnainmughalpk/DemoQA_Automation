using DemoQA_Automation.Base;
using OpenQA.Selenium;

namespace DemoQA_Automation.Pages
{
    public class TextBoxPage : BasePage
    {
        private By FullName = By.Id("userName");
        private By Email = By.Id("userEmail");
        private By CurrentAddress = By.Id("currentAddress");
        private By PermanentAddress = By.Id("permanentAddress");

        private By SubmitBtn = By.Id("submit");

        private By NameOutput = By.Id("name");
        private By EmailOutput = By.Id("email");
        private By CurrentAddressOutput = By.Id("currentAddress");
        private By PermanentAddressOutput = By.Id("permanentAddress");


        public TextBoxPage(IWebDriver driver) : base(driver)
        {
        }


        public void TextBox(
            string fullName,
            string email,
            string currentAddress,
            string permanentAddress)
        {
            Type(FullName, fullName);
            Type(Email, email);
            Type(CurrentAddress, currentAddress);
            Type(PermanentAddress, permanentAddress);
            ScrollToElement(SubmitBtn);

            Click(SubmitBtn);
        }


        public string GetName()
        {
            return GetText(NameOutput);
        }

        public string GetEmail()
        {
            return GetText(EmailOutput);
        }

        public string GetCurrentAddress()
        {
            return GetText(CurrentAddressOutput);
        }

        public string GetPermanentAddress()
        {
            return GetText(PermanentAddressOutput);
        }
    }
}