using OpenQA.Selenium;

namespace MockProject.Page
{
    public class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver _driver)
        {
            driver = _driver;
        }
    }
}
