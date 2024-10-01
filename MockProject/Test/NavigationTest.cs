
using Allure.Xunit.Attributes.Steps;
using FluentAssertions;
using MockProject.Page;

namespace MockProject.Test {
    public class NavigationTest : BaseTest {
        protected LoginPage loginPage;
        protected NavigationPage navigationPage;
        public override void SetupPage() {
            loginPage = new LoginPage(driver);
            navigationPage = new NavigationPage(driver);
        }

        // Pre-Condition (Initialize):
        [AllureBefore]
        public NavigationTest(ITestOutputHelper output) : base(output) {
            loginPage.LoginWithUsernameAndPassword();
        }


        [Fact(DisplayName = "Verify Navigate To Department Dashboard")]
        public void VerifyNavigateToDepartmentDashboard() {

            try {
                // Navigate to Department Dashboard
                navigationPage.ClickNavigateOtherPagesButton();
                navigationPage.NavigateToDepartment();

                // Verify Department Dashboard is displayed:
                navigationPage.DepartmentLabelDisplay().Should().Be("Department");
            }
            catch (Exception ex) {
                Console.WriteLine($"An error occurred while navigating to the Department Dashboard: {ex.Message}");
                throw; // Re-throw the original exception for further handling
            }
        }


        [Fact(DisplayName = "Verify Navigate To Designation Dashboard")]
        public void VerifyNavigateToDesignationDashboard() {
            try {
                // Click and Navigate to Designation Dashboard
                navigationPage.ClickNavigateOtherPagesButton();
                navigationPage.NavigateToDesignation();

                // Verify Designation Dashboard is displayed:
                navigationPage.DesignationLabelDisplay().Should().Be("Designation");
            }
            catch (Exception ex) {
                Console.WriteLine($"An error occurred while navigating to the Designation Dashboard: {ex.Message}");
                throw; // Re-throw the original exception for further handling
            }
        }


        [Fact(DisplayName = "Verify Navigate To Set Roles Dashboard")]
        public void VerifyNavigateToSetRolesDashboard() {
            try {
                // Click and Navigate to Set Roles Dashboard
                navigationPage.ClickNavigateOtherPagesButton();
                navigationPage.NavigateToSetRoles();

                // Verify Set Roles Dashboard is displayed:
                navigationPage.SetRolesLabelDisplay().Should().Be("Staff Roles");
            }
            catch (Exception ex) {
                Console.WriteLine($"An error occurred while navigating to the Set Roles Dashboard: {ex.Message}");
                throw; // Re-throw the original exception for further handling
            }
        }


        [Fact(DisplayName = "Verify Navigate To Office Shifts Dashboard")]
        public void VerifyNavigateToOfficeShiftsDashboard() {
            try {
                // Click and Navigate to Office Shifts Dashboard
                navigationPage.ClickNavigateOtherPagesButton();
                navigationPage.NavigateToOfficeShifts();

                // Verify Office Shifts Dashboard is displayed:
                navigationPage.OfficeShiftsLabelDisplay().Should().Be("Shift & Scheduling");
            }
            catch (Exception ex) {
                Console.WriteLine($"An error occurred while navigating to the Office Shifts Dashboard: {ex.Message}");
                throw; // Re-throw the original exception for further handling
            }
        }

        [Fact(DisplayName = "Verify Navigate To Competencies Dashboard")]
        public void VerifyNavigateToCompetenciesDashboard() {
            try {
                // Click and Navigate to Competencies Dashboard
                navigationPage.ClickNavigateOtherPagesButton();
                navigationPage.NavigateToCompetencies();

                // Verify Competencies Dashboard is displayed:
                navigationPage.CompetenciesLabelDisplay().Should().Be("Category");
            }
            catch (Exception ex) {
                Console.WriteLine($"An error occurred while navigating to the Competencies Dashboard: {ex.Message}");
                throw; // Re-throw the original exception for further handling
            }
        }
    }
}
