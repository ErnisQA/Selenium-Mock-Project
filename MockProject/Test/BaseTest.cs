
using Allure.Net.Commons;
using Allure.Xunit.Attributes.Steps;
using OpenQA.Selenium;
using System.Runtime.CompilerServices;
using TestFrameworkCore.Helper;
using WebDriverHelper.Helper;

namespace MockProject.Test {
    public class BaseTest : XunitContextBase, IDisposable, IClassFixture<AssemblyTest> {
        protected BrowserHelper browser;
        protected IWebDriver driver => browser?.driver;
        public virtual void SetupPage() {

        }

        [ModuleInitializer]
        public static void SetupReport() {
            XunitContext.EnableExceptionCapture();
        }


        // Test Initialize:
        //[AllureBefore("Setup browser")]
        public BaseTest(ITestOutputHelper output) : base(output) {
            browser = new BrowserHelper();
            var url = ConfigurationHelper.GetConfig<string>("url");
            browser.OpenBrowser(url);
            SetupPage();
        }

        // Test Cleanup:
        [AllureAfter("Close browser")]
        public void Dispose() {
            if (Context.TestException != null) {
                string screenshotBase64 = browser.CaptureScreenshotBase64();
                string fileName = "screenshot" + DateTime.Now.ToFileTimeUtc();
                AllureApi.AddAttachment(fileName, "image/png", Convert.FromBase64String(screenshotBase64));
            }
            browser.CloseBrowser();
            driver.Dispose();
        }
    }
}
