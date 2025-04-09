using CloudQAFormAutomation.Drivers;
using CloudQAFormAutomation.Pages;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace CloudQAFormAutomation.Tests
{
    public class FormFieldTest
    {
        public static void RunTest()
        {
            IWebDriver driver = ChromeDriverSetup.GetDriver();

            try
            {
                driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");
                Thread.Sleep(2000); // Ideally use WebDriverWait

                var formPage = new AutomationPracticeFormPage(driver);
                formPage.FillFirstName("John");
                formPage.SelectMaleGender();
                formPage.SelectReadingHobby();

                Thread.Sleep(3000); // Visual confirmation
            }
            catch (Exception ex)
            {
                Console.WriteLine("Test Failed: " + ex.Message);
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
