using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace WebDriverHelper.Helper {
    public class FactoryDriverHelper {
        public enum BrowserType {
            CHROME,
            FIREFOX,
            EDGE
        }

        public static IWebDriver InitDriver(BrowserType browserType) {
            IWebDriver driver = null;

            try {
                switch (browserType) {
                    case BrowserType.CHROME:
                        new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
                        driver = new ChromeDriver();
                        break;

                    case BrowserType.FIREFOX:
                        new DriverManager().SetUpDriver(new FirefoxConfig(), VersionResolveStrategy.MatchingBrowser);
                        driver = new FirefoxDriver();
                        break;

                    case BrowserType.EDGE:
                        new DriverManager().SetUpDriver(new EdgeConfig(), VersionResolveStrategy.MatchingBrowser);
                        driver = new EdgeDriver();
                        break;

                    default:
                        throw new NotSupportedException($"Browser type {browserType} is not supported.");
                }
            }
            catch (DriverServiceNotFoundException ex) {
                Console.WriteLine($"Driver not found for {browserType}: {ex.Message}");
                throw new Exception($"Failed to initialize the driver for {browserType}. Ensure the driver is installed.", ex);
            }
            catch (WebDriverException ex) {
                Console.WriteLine($"WebDriver error: {ex.Message}");
                throw new Exception($"Failed to initialize the WebDriver for {browserType}.", ex);
            }
            catch (Exception ex) {
                Console.WriteLine($"An error occurred while initializing the driver: {ex.Message}");
                throw new Exception($"Failed to initialize the driver for {browserType}.", ex);
            }

            return driver;
        }
    }
}
