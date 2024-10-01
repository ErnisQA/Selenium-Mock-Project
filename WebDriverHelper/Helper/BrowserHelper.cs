
using OpenQA.Selenium;
using System.Configuration;
using TestFrameworkCore.Helper;
using static WebDriverHelper.Helper.FactoryDriverHelper;

namespace WebDriverHelper.Helper {
    public class BrowserHelper {
        public IWebDriver driver;

        public void OpenBrowser(string url = null, string browserType = null) {
            try {
                // If no browserType is provided, attempt to get it from the config
                if (string.IsNullOrEmpty(browserType)) {
                    browserType = ConfigurationHelper.GetConfig<string>("browser");

                    if (string.IsNullOrEmpty(browserType)) {
                        throw new Exception("Browser type not specified in configuration or passed as a parameter.");
                    }
                }

                // Try to parse the browser type
                if (!Enum.TryParse<BrowserType>(browserType, ignoreCase: true, out var browser)) {
                    throw new ArgumentException($"Invalid browser type: {browserType}");
                }

                // Initialize the driver
                driver = FactoryDriverHelper.InitDriver(browser);
                if (driver == null) {
                    throw new Exception("Failed to initialize the web driver.");
                }

                // Maximize the browser window
                driver.Manage().Window.Maximize();

                // If a URL is provided, navigate to it
                if (!string.IsNullOrEmpty(url)) {
                    GoToURL(url);
                }

                // Set the implicit wait timeout
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }
            catch (ConfigurationErrorsException ex) {
                Console.WriteLine($"Error retrieving configuration: {ex.Message}");
            }
            catch (ArgumentException ex) {
                Console.WriteLine($"Invalid browser type: {ex.Message}");
            }
            catch (WebDriverException ex) {
                Console.WriteLine($"WebDriver error: {ex.Message}");
            }
            catch (Exception ex) {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

        }
        public void GoToURL(string url) {
            driver.Navigate().GoToUrl(url);
        }

        public string CaptureScreenshotBase64() {
            // Convert WebDriver object to ITakesScreenshot
            ITakesScreenshot screenshotDriver = (ITakesScreenshot)driver;

            // Take the screenshot
            Screenshot screenshot = screenshotDriver.GetScreenshot();

            return screenshot.AsBase64EncodedString;
        }

        public void CloseBrowser() {
            if (driver is null) {
                return;
            }
            driver.Quit();
        }

        public void NavigateBack() {
            driver.Navigate().Back();
        }

    }
}
