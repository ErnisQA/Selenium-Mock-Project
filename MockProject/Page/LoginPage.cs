
using Allure.Xunit.Attributes.Steps;
using OpenQA.Selenium;
using TestFrameworkCore.Helper;
using TestFrameworkCore.Model;

namespace MockProject.Page {
    public class LoginPage : BasePage {
        public LoginPage(IWebDriver _driver) : base(_driver) {
        }


        // Locator:
        private By xpathInputUsername = By.XPath("//input[@id= 'iusername']");
        private By xpathInputPassword = By.XPath("//input[@id= 'ipassword']");
        private By xpathClickLoginButton = By.XPath("//span[@class= 'ladda-label']");
        private By xpathErrorMessageDisplay = By.XPath("//div[contains(text(), 'Invalid Login Credentials.')]");
        private By xpathLoginPageDisplay = By.XPath("//a[@class ='f-w-400']");



        // Method Interact With Locator:
        [AllureStep("Input Username")]
        public void InputUsername(string username) {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    driver.FindElement(xpathInputUsername).SendKeys(username);
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathInputUsername} not found after 60 seconds");

        }


        [AllureStep("Input Password")]
        public void InputPassword(string password) {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    driver.FindElement(xpathInputPassword).SendKeys(password);
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathInputPassword} not found after 60 seconds");

        }


        [AllureStep("Click on Login button")]
        public void ClickLoginButton() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    driver.FindElement(xpathClickLoginButton).Click();
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathClickLoginButton} not found after 60 seconds");

        }


        [AllureStep("Verify Error Message is displayed")]
        public bool IsErrorMessageDisplay(int timeout = 1) {
            try {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
                return driver.FindElement(xpathErrorMessageDisplay).Displayed;
            }
            catch {
                return false;
            }
            finally {
                int defaultTimeout = int.Parse(ConfigurationHelper.GetConfig<string>("timeout"));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(defaultTimeout);
            }
        }


        [AllureStep("Verify Login Page is displayed")]
        public bool IsLoginPageDisplay(int timeout = 1) {
            try {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
                return driver.FindElement(xpathLoginPageDisplay).Displayed;
            }
            catch {
                return false;
            }
            finally {
                int defaultTimeout = int.Parse(ConfigurationHelper.GetConfig<string>("timeout"));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(defaultTimeout);
            }
        }


        public void LoginWithUsernameAndPassword() {
            UserLoginModel user = new UserLoginModel() {
                Username = ConfigurationHelper.GetConfig<string>("username"),
                Password = ConfigurationHelper.GetConfig<string>("password")
            };
            InputUsername(user.Username);
            InputPassword(user.Password);
            ClickLoginButton();
        }


        [AllureStep("Get Attribute Username")]
        public string GetAttribute_Username() {
            IWebElement textBox = driver.FindElement(xpathInputUsername);
            string textBoxValue = textBox.GetAttribute("value");
            return textBoxValue;
        }


        [AllureStep("Get Attribute Password")]
        public string GetAttribute_Password() {
            IWebElement textBox = driver.FindElement(xpathInputPassword);
            string textBoxValue = textBox.GetAttribute("value");
            return textBoxValue;
        }
    }
}
