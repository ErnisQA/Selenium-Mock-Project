using Allure.Xunit.Attributes.Steps;
using FluentAssertions;
using MockProject.Page;
using TestFrameworkCore.Helper;

namespace MockProject.Test {
    public class ProjectsTest : BaseTest {
        protected LoginPage loginPage;
        protected ProjectsPage projectsPage;

        public override void SetupPage() {
            loginPage = new LoginPage(driver);
            projectsPage = new ProjectsPage(driver);
        }

        // Pre-Condition (Initialize):
        [AllureBefore("Login with valid account")]
        public ProjectsTest(ITestOutputHelper output) : base(output) {
            loginPage.LoginWithUsernameAndPassword();
        }


        [Theory(DisplayName = "Verify Add Project With Valid Test Data")]
        [MemberData(nameof(Projects_TestData))]
        public void VerifyAddProject(string title, string estimatedHour, string summary, string description, bool isProjectDisplay) {
            try {
                // Navigate to Projects Page:
                projectsPage.ClickProjectsNavMenu();

                // Click Add Project button:
                projectsPage.ClickAddButton();

                // Input information to all fields (Excel import):
                projectsPage.Input_AllFields(title, estimatedHour, summary, description);

                // Click Save button:
                projectsPage.ClickSaveButton();

                // Search => View Project Details:
                projectsPage.ViewProjectDetail(title);

                // Click Edit => Check All fields after created:
                projectsPage.ClickEditButton();

                // Verify new project successfully added: 
                projectsPage.isProjectCreated(title, estimatedHour, summary).Should().Be(isProjectDisplay);
            }
            catch (Exception ex) {
                Console.WriteLine($"An error occurred while adding the project: {ex.Message}");
                throw; // Re-throw the original exception for further handling
            }
        }
        public static IEnumerable<object[]> Projects_TestData {
            get {
                return new ExcelHelper(Path.Combine("Resources", "Projects_TestData.xlsx")).GetProjectsData();
            }
        }



        [Fact(DisplayName = "Verify Delete Project")]
        public void VerifyDeleteProject() {
            try {
                // Navigate to Projects Page:
                projectsPage.ClickProjectsNavMenu();

                // Switch to List View:
                projectsPage.ClickListViewButton();

                // Click Delete Button:
                projectsPage.ClickDeleteButton();

                // Verify Success Message is displayed:
                projectsPage.IsDeleteSuccessMessageDisplay(10).Should().BeTrue();
            }
            catch (Exception ex) {
                Console.WriteLine($"An error occurred while deleting the project: {ex.Message}");
                throw; // Re-throw the original exception for further handling
            }
        }


        [Fact(DisplayName = "Verify Update Project")]
        public void VerifyUpdateProject() {
            try {
                // Navigate to Projects Page: 
                projectsPage.ClickProjectsNavMenu();

                // Create new Project => Update:
                projectsPage.Update_Project();

                // Verify Success Message is displayed:
                projectsPage.IsUpdateSuccessMessageDisplay(10).Should().BeTrue();
            }
            catch (Exception ex) {
                Console.WriteLine($"An error occurred while updating the project: {ex.Message}");
                throw; // Re-throw the original exception for further handling
            }
        }

        [Fact(DisplayName = "Verify Navigate To Calender Dasboard")]
        public void VerifyNavigateToCalenderDashboard() {
            try {
                // Navigate to Projects Page: 
                projectsPage.ClickProjectsNavMenu();

                // Click to Calender button:
                projectsPage.ClickCalenderButton();

                // Verify Calender Dashboard is displayed:
                projectsPage.IsCalenderBoardDisplayDisplay(10).Should().BeTrue();
                projectsPage.CalenderLabelDisplay().Should().Be("Calendar");
                projectsPage.IsEventsLabelDisplay(10).Should().BeTrue();
            }
            catch (Exception ex) {
                Console.WriteLine($"An error occurred while navigating to the Calendar Dashboard: {ex.Message}");
                throw; // Re-throw the original exception for further handling
            }
        }

        [Fact(DisplayName = "Verify Navigate To Kanban Board")]
        public void VerifyNavigateToKanbanBoard() {
            try {
                // Navigate to Projects Page: 
                projectsPage.ClickProjectsNavMenu();

                // Click to Kanban button:
                projectsPage.ClickKanbanBoardButton();

                // Verify Kanban Board is displayed:
                projectsPage.KanbanBoardLabelDisplay().Should().Be("Kanban Board");
            }
            catch (Exception ex) {
                Console.WriteLine($"An error occurred while navigating to the Kanban Board: {ex.Message}");
                throw; // Re-throw the original exception for further handling
            }
        }
    }
}

