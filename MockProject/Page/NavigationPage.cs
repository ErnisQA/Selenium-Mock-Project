
using Allure.Xunit.Attributes.Steps;
using OpenQA.Selenium;

namespace MockProject.Page {
    public class NavigationPage : BasePage {
        public NavigationPage(IWebDriver _driver) : base(_driver) {
        }


        // Locator:
        private By xpathNavigateOtherPagesButton = By.XPath("//h6[@class = 'm-b-0 dropdown-toggle']");
        private By xpathNavigateToDepartment = By.XPath("//span[contains(text(), 'Department')]");
        private By xpathNavigateToDesignation = By.XPath("//span[contains(text(), 'Designation')]");
        private By xpathNavigateToSetRoles = By.XPath("//span[contains(text(), 'Set Roles')]");
        private By xpathNavigateToOfficeShifts = By.XPath("//span[contains(text(), 'Office Shifts')]");
        private By xpathNavigateToCompetencies = By.XPath("//span[contains(text(), 'Competencies')]");
        private By xpathNavigateToNeedMoreHelp = By.XPath("//a[contains(text(), 'Need more help?')]");
        private By xpathDepartmentLabel = By.XPath("//ul[@class = 'breadcrumb']/li[contains(text(), 'Department')]");
        private By xpathDesignationLabel = By.XPath("//ul[@class = 'breadcrumb']/li[contains(text(), 'Designation')]");
        private By xpathSetRolesLabel = By.XPath("//ul[@class = 'breadcrumb']/li[contains(text(), 'Staff Roles')]");
        private By xpathOfficeShiftsLabel = By.XPath("//ul[@class = 'breadcrumb']/li[contains(text(), 'Shift & Scheduling')]");
        private By xpathCompetenciesLabel = By.XPath("//ul[@class = 'breadcrumb']/li[contains(text(), 'Category')]");



        // Method Interact With Locator:
        [AllureStep("Click Profile Completeness dropdown button")]
        public void ClickNavigateOtherPagesButton() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    driver.FindElement(xpathNavigateOtherPagesButton).Click();
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathNavigateOtherPagesButton} not found after 60 seconds");
        }


        [AllureStep("Click on Department")]
        public void NavigateToDepartment() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    driver.FindElement(xpathNavigateToDepartment).Click();
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathNavigateToDepartment} not found after 60 seconds");
        }


        [AllureStep("Click on Designation")]
        public void NavigateToDesignation() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    driver.FindElement(xpathNavigateToDesignation).Click();
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathNavigateToDesignation} not found after 60 seconds");
        }


        [AllureStep("Click on Set Roles")]
        public void NavigateToSetRoles() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    driver.FindElement(xpathNavigateToSetRoles).Click();
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathNavigateToSetRoles} not found after 60 seconds");
        }


        [AllureStep("Click on Office Shifts")]
        public void NavigateToOfficeShifts() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    driver.FindElement(xpathNavigateToOfficeShifts).Click();
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathNavigateToOfficeShifts} not found after 60 seconds");
        }


        [AllureStep("Click on Competencies")]
        public void NavigateToCompetencies() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    driver.FindElement(xpathNavigateToCompetencies).Click();
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathNavigateToCompetencies} not found after 60 seconds");
        }


        [AllureStep("Click on Need More Help")]
        public void NavigateToNeedMoreHelp() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    driver.FindElement(xpathNavigateToNeedMoreHelp).Click();
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathNavigateToNeedMoreHelp} not found after 60 seconds");
        }


        [AllureStep("Department label is displayed")]
        public string DepartmentLabelDisplay() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    return driver.FindElement(xpathDepartmentLabel).Text;
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathDepartmentLabel} not found after 60 seconds");
        }


        [AllureStep("Designation label is displayed")]
        public string DesignationLabelDisplay() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    return driver.FindElement(xpathDesignationLabel).Text;
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathDesignationLabel} not found after 60 seconds");
        }


        [AllureStep("Set Roles label is displayed")]
        public string SetRolesLabelDisplay() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    return driver.FindElement(xpathSetRolesLabel).Text;
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathSetRolesLabel} not found after 60 seconds");
        }


        [AllureStep("Office Shifts label is displayed")]
        public string OfficeShiftsLabelDisplay() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    return driver.FindElement(xpathOfficeShiftsLabel).Text;
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathOfficeShiftsLabel} not found after 60 seconds");
        }


        [AllureStep("Competencies label is displayed")]
        public string CompetenciesLabelDisplay() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    return driver.FindElement(xpathCompetenciesLabel).Text;
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathCompetenciesLabel} not found after 60 seconds");
        }
    }
}
