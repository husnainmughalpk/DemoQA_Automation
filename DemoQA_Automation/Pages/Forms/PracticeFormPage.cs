using DemoQA_Automation.Base;
using OpenQA.Selenium;

namespace DemoQA_Automation.Pages
{
    public class PracticeFormPage : BasePage
    {
        private By FirstName = By.Id("firstName");
        private By LastName = By.Id("lastName");
        private By Email = By.Id("userEmail");
        private By MaleGender = By.XPath("//label[@for='gender-radio-1']");
        private By Mobile = By.Id("userNumber");

        private By Subjects = By.Id("subjectsInput");

        private By SportsHobby = By.XPath("//label[@for='hobbies-checkbox-1']");

        private By CurrentAddress = By.Id("currentAddress");

        private By SubmitButton = By.Id("submit");

        private By SubmissionModal = By.ClassName("modal-content");

        public PracticeFormPage(IWebDriver driver) : base(driver)
        {
        }

        public void OpenPracticeFormPage()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
        }

        public void EnterFirstName(string firstName)
        {
            Type(FirstName, firstName);
        }

        public void EnterLastName(string lastName)
        {
            Type(LastName, lastName);
        }

        public void EnterEmail(string email)
        {
            Type(Email, email);
        }

        public void SelectMale()
        {
            Click(MaleGender);
        }

        public void EnterMobile(string mobile)
        {
            Type(Mobile, mobile);
        }

        public void EnterSubject(string subject)
        {
            Type(Subjects, subject);
            driver.FindElement(Subjects).SendKeys(Keys.Enter);
        }

        public void SelectSports()
        {
            Click(SportsHobby);
        }

        public void EnterCurrentAddress(string address)
        {
            Type(CurrentAddress, address);
        }

        public void SubmitForm()
        {
            ScrollToElement(SubmitButton);
            Click(SubmitButton);
        }

        public string GetSubmissionData()
        {
            return driver.FindElement(SubmissionModal).Text;
        }
    }
}