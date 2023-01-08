using OpenQA.Selenium.Chrome;

namespace Mazaady_task.Drivers
{
    [Binding]
    public class DriverProvider //Driver
    {
        public static IWebDriver driver;
        public data dt = new data();

        public static IWebDriver GetDriver()
        {
            return InitializeDriver();
        }

        private static IWebDriver InitializeDriver()
        {
            data dt = new data();
            if (driver == null)
            {
                var DeviceDriver = ChromeDriverService.CreateDefaultService();
                DeviceDriver.HideCommandPromptWindow = true;
                ChromeOptions options = new ChromeOptions();
                options.AddExcludedArgument("enable-automation");
                options.AddArgument("--disable-infobars");

                options.AddArgument("no-sandbox");
                options.AddArgument("single-process");
                options.AddArgument("disable-dev-shm-usage");
                options.AddArgument("incognito");
                options.AddArgument("disable-blink-features=AutomationControlled");
                options.AddAdditionalOption("useAutomationExtension", false);

                options.AddUserProfilePreference("download.default_directory", dt.folderPath);
                options.AddUserProfilePreference("intl.accept_languages", "nl");
                options.AddUserProfilePreference("disable-popup-blocking", "true");

                driver = new ChromeDriver(DeviceDriver, options);
                /////////////////////////////////////////
                ////driver = new FirefoxDriver();
                //// driver = new EdgeDriver();

                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://staging.mazaady.com/login");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            }
            return driver;
        }

        public static void CloseDriver()
        {
            if (driver != null)
            {
                driver.Close();
                driver.Quit();
            }
        }


    }
}
