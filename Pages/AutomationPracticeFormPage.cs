using OpenQA.Selenium;

namespace CloudQAFormAutomation.Pages
{
    public class AutomationPracticeFormPage
    {
        private readonly IWebDriver driver;

        public AutomationPracticeFormPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement FirstName => driver.FindElement(By.Name("firstname"));
        public IWebElement MaleRadio => driver.FindElement(By.XPath("//input[@value='Male']"));
        public IWebElement ReadingCheckbox => driver.FindElement(By.XPath("//input[@value='Reading']"));

        public void FillFirstName(string name) => FirstName.SendKeys(name);
        public void SelectMaleGender()
        {
            if (!MaleRadio.Selected) MaleRadio.Click();
        }
        public void SelectReadingHobby()
        {
            if (!ReadingCheckbox.Selected) ReadingCheckbox.Click();
        }
    }
}
