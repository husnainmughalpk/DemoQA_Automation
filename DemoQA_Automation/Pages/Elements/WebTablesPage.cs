using DemoQA_Automation.Base;
using OpenQA.Selenium;

namespace DemoQA_Automation.Pages
{
    public class WebTablesPage : BasePage
    {
        private By AddButton = By.Id("addNewRecordButton");

        private By FirstName = By.Id("firstName");
        private By LastName = By.Id("lastName");
        private By Email = By.Id("userEmail");
        private By Age = By.Id("age");
        private By Salary = By.Id("salary");
        private By Department = By.Id("department");

        private By SubmitButton = By.Id("submit");

        private By FirstNameCell = By.XPath("//*[@id=\"root\"]/div/div/div/div[2]/div[1]/div[2]/table/tbody/tr[4]/td[1]");
        private By LastNameCell = By.XPath("//*[@id=\"root\"]/div/div/div/div[2]/div[1]/div[2]/table/tbody/tr[4]/td[2]");
        private By AgeCell = By.XPath("//*[@id=\"root\"]/div/div/div/div[2]/div[1]/div[2]/table/tbody/tr[4]/td[3]");
        private By EmailCell = By.XPath("//*[@id=\"root\"]/div/div/div/div[2]/div[1]/div[2]/table/tbody/tr[4]/td[4]");
        private By SalaryCell = By.XPath("//*[@id=\"root\"]/div/div/div/div[2]/div[1]/div[2]/table/tbody/tr[4]/td[5]");
        private By DepartmentCell = By.XPath("//*[@id=\"root\"]/div/div/div/div[2]/div[1]/div[2]/table/tbody/tr[4]/td[6]");


        public WebTablesPage(IWebDriver driver) : base(driver)
        {
        }

        public void OpenWebTablesPage()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/webtables");
        }

        public void AddRecord(
            string firstName,
            string lastName,
            string email,
            string age,
            string salary,
            string department)
        {
            Click(AddButton);

            Type(FirstName, firstName);
            Type(LastName, lastName);
            Type(Email, email);
            Type(Age, age);
            Type(Salary, salary);
            Type(Department, department);

            Click(SubmitButton);
        }

        public string GetFirstName()
        {
            return driver.FindElement(FirstNameCell).Text;
        }

        public string GetLastName()
        {
            return driver.FindElement(LastNameCell).Text;
        }

        public string GetEmail()
        {
            return driver.FindElement(EmailCell).Text;
        }

        public string GetAge()
        {
            return driver.FindElement(AgeCell).Text;
        }

        public string GetSalary()
        {
            return driver.FindElement(SalaryCell).Text;
        }

        public string GetDepartment()
        {
            return driver.FindElement(DepartmentCell).Text;
        }
    }
}