using FluentAssertions;
using MockProject.Page;
using System.Configuration;
using TestFrameworkCore.Helper;

namespace MockProject.Test {

    public class LoginTest : BaseTest {

        protected LoginPage loginPage;
        protected DashboardPage dashboardPage;

        public LoginTest(ITestOutputHelper output) : base(output) {
        }

        public override void SetupPage() {
            loginPage = new LoginPage(driver);
            dashboardPage = new DashboardPage(driver);
        }

        [Fact(DisplayName = "Verify Login With Valid User Information")]
        public void VerifyLoginWith_ValidUserInformation() {
            try {
                string username = ConfigurationHelper.GetConfig<string>("username");
                string password = ConfigurationHelper.GetConfig<string>("password");

                loginPage.InputUsername(username);
                loginPage.InputPassword(password);
                loginPage.ClickLoginButton();

                // Verify user can login with valid information:
                dashboardPage.IsDashboardPageDisplay(10).Should().BeTrue();
            }
            catch (ConfigurationErrorsException ex) {
                Console.WriteLine($"Configuration error: {ex.Message}");
                throw new Exception("Failed to retrieve configuration values for login.", ex);
            }
            catch (Exception ex) {
                Console.WriteLine($"An error occurred during login: {ex.Message}");
                throw; // Re-throw the original exception for further handling
            }
        }

        [Fact(DisplayName = "Verify Login With Invalid User Information")]
        public void VerifyLoginWith_InvalidUserInformation() {
            try {
                string username = ConfigurationHelper.GetConfig<string>("username");
                string invalidPassword = "invalidpassword";

                loginPage.InputUsername(username);
                loginPage.InputPassword(invalidPassword);
                loginPage.ClickLoginButton();

                // Verify Error Message is displayed:
                loginPage.IsErrorMessageDisplay(10).Should().BeTrue();

                // Verify user cannot login with invalid information:
                dashboardPage.IsDashboardPageDisplay(10).Should().BeFalse();
            }
            catch (ConfigurationErrorsException ex) {
                Console.WriteLine($"Configuration error: {ex.Message}");
                throw new Exception("Failed to retrieve configuration values for login.", ex);
            }
            catch (Exception ex) {
                Console.WriteLine($"An error occurred during the invalid login test: {ex.Message}");
                throw; // Re-throw the original exception for further handling
            }
        }

        [Fact(DisplayName = "Verify Complete Logout")]
        public void VerifyComplete_Logout() {
            try {
                string username = ConfigurationHelper.GetConfig<string>("username");
                string password = ConfigurationHelper.GetConfig<string>("password");

                loginPage.InputUsername(username);
                loginPage.InputPassword(password);
                loginPage.ClickLoginButton();

                // User Click Log Out Button:
                dashboardPage.ClickLogOutButton();

                // Verify Login Page is displayed after user log out:
                loginPage.IsLoginPageDisplay(10).Should().BeTrue();

                // Click Navigate Back on browser:
                browser.NavigateBack();

                // Verify "Username" and "Password" textbox is null:
                loginPage.GetAttribute_Username().Should().BeNullOrEmpty();
                loginPage.GetAttribute_Password().Should().BeNullOrEmpty();
            }
            catch (ConfigurationErrorsException ex) {
                Console.WriteLine($"Configuration error: {ex.Message}");
                throw new Exception("Failed to retrieve configuration values for logout verification.", ex);
            }
            catch (Exception ex) {
                Console.WriteLine($"An error occurred during logout verification: {ex.Message}");
                throw; // Re-throw the original exception for further handling
            }
        }
    }
}
