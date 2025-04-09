using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CloudQAFormAutomation.Drivers
{
    public static class ChromeDriverSetup
    {
        public static IWebDriver GetDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("start-maximized");
            return new ChromeDriver(options);
        }
    }
}
