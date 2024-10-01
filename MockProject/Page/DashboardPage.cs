using Allure.Xunit.Attributes.Steps;
using OpenQA.Selenium;
using TestFrameworkCore.Helper;

namespace MockProject.Page {
    public class DashboardPage : BasePage {
        public DashboardPage(IWebDriver _driver) : base(_driver) {
        }


        // Locator:
        private By xpathDashboardPageDisplay = By.XPath("//a[contains(@class, 'rounded-pill')]");
        private By xpathClickLogOutButton = By.XPath("//a[contains(@class, 'rounded-pill')]");



        // Method Interact With Locator:
        [AllureStep("Verify Dashboard Page is displayed")]
        public bool IsDashboardPageDisplay(int timeout = 1) {
            try {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
                return driver.FindElement(xpathDashboardPageDisplay).Displayed;
            }
            catch {
                return false;
            }
            finally {
                int defaultTimeout = int.Parse(ConfigurationHelper.GetConfig<string>("timeout"));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(defaultTimeout);
            }
        }


        [AllureStep("Click on LogOut button")]
        public void ClickLogOutButton() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    driver.FindElement(xpathClickLogOutButton).Click();
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathClickLogOutButton} not found after 60 seconds");
        }
    }
}
