using Mazaady_task.Drivers;
using OpenQA.Selenium.Interactions;
using Xunit;
using Xunit.Priority;

namespace Mazaady_task.Base
{
    [TestCaseOrderer(PriorityOrderer.Name, PriorityOrderer.Assembly)]
    public class BasePage
    {
        public IWebDriver driver;
        public Actions action;
        public IJavaScriptExecutor javaScriptExecutor;


        public BasePage()
        {
            driver = DriverProvider.GetDriver();
            action = new Actions(driver);
            javaScriptExecutor = (IJavaScriptExecutor)driver;
            PageFactory.InitElements(DriverProvider.driver, this);

        }

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(DriverProvider.driver, this);

        }


        ~BasePage()
        {
            DriverProvider.CloseDriver();
        }

    }
}
