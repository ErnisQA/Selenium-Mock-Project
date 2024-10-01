
using Allure.Xunit.Attributes.Steps;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using TestFrameworkCore.Helper;

namespace MockProject.Page {
    public class ProjectsPage : BasePage {
        public ProjectsPage(IWebDriver _driver) : base(_driver) {
        }


        // Locator:
        // Create Function:
        private By xpathClickProjectsNavMenu = By.XPath("//span[contains(text(), 'Projects')]");
        private By xpathClickAddButton = By.XPath("//a[contains(@class, 'btn-sm m-0')]");
        private By xpathInputTitle = By.XPath("//input[@name= 'title']");
        private By xpathInputEstimatedHour = By.XPath("//input[@name= 'budget_hours']");
        private By xpathInputStartDate = By.XPath("//input[@name = 'start_date']");
        private By xpathInputEndDate = By.XPath("//input[@name = 'end_date']");
        private By xpathInputSummary = By.XPath("//textarea[@id = 'summary']");
        private By xpathInputDescription = By.XPath("//td[@class = 'k-editable-area']");
        private By xpathClickSaveButton = By.XPath("//span[contains(text(), 'Save')]");
        private By xpathInputClient = By.XPath("//span[@id = 'select2-client_id-container']");
        private By xpathSelectClientElement = By.XPath("//ul[@id = 'select2-client_id-results']/li");
        private By xpathInputPriority = By.XPath("//span[contains(@id, 'priority')]");
        private By xpathSelectPriorityElement = By.XPath("//ul[contains(@id, 'priority')]/li");
        private By xpathInputTeam = By.XPath("//ul[@class = 'select2-selection__rendered']");
        private By xpathSelectTeamElement = By.XPath("//ul[@class = 'select2-results__options']/li");

        private By xpathProjectDisplay(string title) => By.XPath($"//a[contains(text(), '{title}')]");
        private IWebElement inputDescription => driver.FindElement(xpathInputDescription);


        // Update and Delete Function (List View):
        private By xpathClickListViewButton = By.XPath("//a[contains(@class, 'btn-primary btn-icon m-0')]/i[@class = 'fas fa-list-ul']");
        private By xpathClickDeleteButton = By.XPath("//button[contains(@class, 'waves-light delete')]");
        private By xpathClickConfirmButton = By.XPath("//span[contains(text(), 'Confirm')]");
        private By xpathSpaceToHover = By.XPath("//div[contains(@class, 'overlay-edit')]");
        private By xpathClickUpdateProjectButton = By.XPath("//span[contains(text(), 'Update Project')]");
        private By xpathClickViewDetails = By.XPath("//button[contains(@class, 'waves-effect waves-light')]/i[@class = 'feather icon-arrow-right']");
        private By xpathClickEditButton = By.XPath("//a[@id = 'pills-edit-tab']");
        private By xpathInputUpdate_StartDate = By.XPath("//input[@name = 'start_date']");
        private By xpathInputUpdate_EndDate = By.XPath("//input[@name = 'end_date']");
        private By xpathInputUpdate_Client = By.XPath("//span[@id = 'select2-client_id-container']");
        private By xpathUpdate_ClientElement = By.XPath("//ul[@id = 'select2-client_id-results']/li");
        private By xpathInputUpdate_Team = By.XPath("//ul[@class = 'select2-selection__rendered']");
        private By xpathUpdate_TeamElement = By.XPath("//ul[@class = 'select2-results__options']/li");
        private By xpathInputUpdate_Summary = By.XPath("//form[@id ='update_project']//textarea[@name= 'summary']");
        private By xpathInputUpdate_Title = By.XPath("//input[@name= 'title']");
        private By xpathInputUpdate_Description = By.XPath("//td[@class = 'k-editable-area']/textarea[@id = 'description']");
        private By xpathIframeDescription = By.XPath("//table[@role = 'presentation']//iframe");
        private By xpathDescriptionInput = By.XPath("//body");
        private By xpathSuccessUpdateMessage = By.XPath("//div[contains(text(), 'Project updated.')]");
        private By xpathSuccessDeleteMessage = By.XPath("//div[contains(text(), 'Project deleted.')]");


        // Search Function:
        private By xpathInputSearchTextbox = By.XPath("//div[@id = 'xin_table_filter']//input[@type= 'search']");


        private IWebElement inputUpdate_Summary => driver.FindElement(xpathInputUpdate_Summary);
        private IWebElement inputUpdate_Client => driver.FindElement(xpathInputUpdate_Client);
        private IWebElement inputUpdate_Team => driver.FindElement(xpathInputUpdate_Team);
        private IWebElement inputUpdate_Title => driver.FindElement(xpathInputUpdate_Title);
        private IWebElement inputUpdate_Description => driver.FindElement(xpathInputUpdate_Description);


        // Delete and Update Button:
        private IWebElement elementSpace => driver.FindElement(xpathSpaceToHover);
        private IWebElement deleteButton => driver.FindElement(xpathClickDeleteButton);
        private IWebElement confirmButton => driver.FindElement(xpathClickConfirmButton);
        private IWebElement viewsDetailsButton => driver.FindElement(xpathClickViewDetails);


        // Navigate Function In Projects Page::
        private By xpathClickCalenderButton = By.XPath("//a[contains(@class, 'nav-link')]/span[contains(@class, 'icon-calendar')]");
        private By xpathCalenderBoardDisplay = By.XPath("//div[contains(@class, 'basic-view')]");
        private By xpathCalenderLabel = By.XPath("//ul[@class=  'breadcrumb']/li[contains(text(), 'Calendar')]");
        private By xpathEventsLabelDisplay = By.XPath("//div[@id = 'external-events']");
        private By xpathClickKanbanBoardButton = By.XPath("//a[contains(@class, 'nav-link')]/span[contains(@class, 'fa-tasks')]");
        private By xpathKanbanBoardLabel = By.XPath("//ul[@class=  'breadcrumb']/li[contains(text(), 'Kanban Board')]");


        // Update and Delete Function (Grid View):
        //private By xpathClickGridViewButton = By.XPath();
        private By xpathClickViewProjectButton = By.XPath("//button[contains(@class, 'txt-muted')]/i[contains(@class, 'fa-eye')]");
        private By xpathClickOptionButton = By.XPath("//button[@id= 'dropdown3']");
        private By xpathClickViewProjectInOption = By.XPath("//a[@class= 'dropdown-item']/i[contains(@class, 'feather icon-eye')]");



        // Method Interact With Locator:
        [AllureStep("Click On Projects navigation menu")]
        public void ClickProjectsNavMenu() {
            driver.FindElement(xpathClickProjectsNavMenu).Click();
        }


        [AllureStep("Click Add New button")]
        public void ClickAddButton() {
            driver.FindElement(xpathClickAddButton).Click();
        }


        [AllureStep("Input Title")]
        public void InputTitle(string title) {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    driver.FindElement(xpathInputTitle).SendKeys(title);
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathInputTitle} not found after 60 seconds");

        }


        [AllureStep("Input Title")]
        public void InputRandom_Title() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    string title = RandomHelper.RandomText();
                    driver.FindElement(xpathInputTitle).SendKeys(title);
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathInputTitle} not found after 60 seconds");

        }


        [AllureStep("Input Title")]
        public void InputUpdate_Title() {
            string title = RandomHelper.RandomText();
            inputUpdate_Title.Clear();
            inputUpdate_Title.SendKeys(title);
        }


        [AllureStep("Input Estimated Hour")]
        public void InputEstimatedHour(string estimatedHour) {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    driver.FindElement(xpathInputEstimatedHour).SendKeys(estimatedHour);
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathInputEstimatedHour} not found after 60 seconds");

        }


        [AllureStep("Input Estimated Hour")]
        public void InputRandom_EstimatedHour() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    string estimatedHour = RandomHelper.RandomNumber();
                    driver.FindElement(xpathInputEstimatedHour).SendKeys(estimatedHour);
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathInputEstimatedHour} not found after 60 seconds");

        }


        [AllureStep("Input Estimated Hour")]
        public void InputUpdate_EstimatedHour() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    int randomIndex = new Random().Next(0, 500);
                    string randomEstimatedHour = randomIndex.ToString();
                    IWebElement element = driver.FindElement(xpathInputEstimatedHour);
                    element.Clear();
                    element.SendKeys(randomEstimatedHour);
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathInputEstimatedHour} not found after 60 seconds");

        }


        [AllureStep("Input Summary")]
        public void InputSummary(string summary) {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    driver.FindElement(xpathInputSummary).SendKeys(summary);
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathInputEstimatedHour} not found after 60 seconds");

        }


        [AllureStep("Input Summary")]
        public void InputRandom_Summary() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    string summary = RandomHelper.RandomText();
                    driver.FindElement(xpathInputSummary).SendKeys(summary);
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathInputSummary} not found after 60 seconds");

        }


        [AllureStep("Input Summary")]
        public void InputUpdate_Summary() {

            // Clear the existing text in the input field
            inputUpdate_Summary.Clear();

            // Generate random text using RandomHelper class
            string summary = RandomHelper.RandomText();

            // Type the generated random text into the input field
            inputUpdate_Summary.SendKeys(summary);
        }


        [AllureStep("Input Description")]
        public void InputDescription(string description) {
            Actions actions = new Actions(driver);

            actions.Click(inputDescription).SendKeys(description).Perform();
        }


        [AllureStep("Input Description")]
        public void InputRandom_Description() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    string description = RandomHelper.RandomText();
                    Actions actions = new Actions(driver);
                    IWebElement description_Textbox = driver.FindElement(xpathInputDescription);
                    actions.Click(description_Textbox).SendKeys(description).Perform();
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathInputDescription} not found after 60 seconds");

        }


        [AllureStep("Input Description")]
        public void InputUpdate_Description() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    string description = RandomHelper.RandomText();

                    IWebElement iframe = driver.FindElement(xpathIframeDescription);
                    driver.SwitchTo().Frame(iframe);

                    driver.FindElement(xpathDescriptionInput).SendKeys(description);
                    driver.SwitchTo().DefaultContent();
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathIframeDescription} not found after 60 seconds");

        }


        [AllureStep("Click On Save button")]
        public void ClickSaveButton() {
            driver.FindElement(xpathClickSaveButton).Click();
        }


        [AllureStep("Input Client")]
        public void InputClient() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    driver.FindElement(xpathInputClient).Click();
                    IList<IWebElement> clientsList = driver.FindElements(xpathSelectClientElement);
                    if (clientsList.Count > 0) {
                        int randomIndex = new Random().Next(0, clientsList.Count);
                        IWebElement randomElement = clientsList[randomIndex];
                        randomElement.Click();
                    }
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathSelectClientElement} not found after 60 seconds");

        }


        [AllureStep("Input Client")]
        public void InputUpdate_Client() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    inputUpdate_Client.Click();
                    IList<IWebElement> clientsList = driver.FindElements(xpathUpdate_ClientElement);
                    if (clientsList.Count > 0) {
                        int randomIndex = new Random().Next(0, clientsList.Count);
                        IWebElement randomElement = clientsList[randomIndex];
                        randomElement.Click();
                    }
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathUpdate_ClientElement} not found after 60 seconds");

        }


        [AllureStep("Input Priority")]
        public void InputPriority() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    driver.FindElement(xpathInputPriority).Click();
                    IList<IWebElement> priorityList = driver.FindElements(xpathSelectPriorityElement);
                    if (priorityList.Count > 0) {
                        int randomIndex = new Random().Next(0, priorityList.Count);
                        IWebElement randomElement = priorityList[randomIndex];
                        randomElement.Click();
                    }
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathSelectPriorityElement} not found after 60 seconds");

        }


        [AllureStep("Input Start Date")]
        public void Input_StartDate() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    IWebElement dateTimeBox = driver.FindElement(xpathInputStartDate);
                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    string dateTimeValue = RandomHelper.RandomDate();
                    js.ExecuteScript("arguments[0].value = arguments[1];", dateTimeBox, dateTimeValue);
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathInputStartDate} not found after 60 seconds");

        }


        [AllureStep("Input End Date")]
        public void Input_EndDate() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    IWebElement dateTimeBox = driver.FindElement(xpathInputEndDate);
                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    string dateTimeValue = RandomHelper.RandomDate();
                    js.ExecuteScript("arguments[0].value = arguments[1];", dateTimeBox, dateTimeValue);
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathInputEndDate} not found after 60 seconds");

        }


        [AllureStep("Input Team")]
        public void InputTeam() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    driver.FindElement(xpathInputTeam).Click();

                    IList<IWebElement> teamList = driver.FindElements(xpathSelectTeamElement);
                    if (teamList.Count > 0) {
                        int randomIndex = new Random().Next(0, teamList.Count);
                        IWebElement randomElement = teamList[randomIndex];
                        randomElement.Click();
                    }
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathSelectTeamElement} not found after 60 seconds");

        }


        [AllureStep("Input Team")]
        public void InputUpdate_Team() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    inputUpdate_Team.Click();

                    IList<IWebElement> teamList = driver.FindElements(xpathUpdate_TeamElement);
                    if (teamList.Count > 0) {
                        int randomIndex = new Random().Next(0, teamList.Count);
                        IWebElement randomElement = teamList[randomIndex];
                        randomElement.Click();
                    }
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathUpdate_TeamElement} not found after 60 seconds");

        }


        [AllureStep("Verify New Project is displayed")]
        public bool IsProjectDisplay(string title) {
            try {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                return driver.FindElement(xpathProjectDisplay(title)).Displayed;
            }
            catch {
                return false;
            }
            finally {
                int defaultTimeout = int.Parse(ConfigurationHelper.GetConfig<string>("timeout"));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(defaultTimeout);
            }
        }


        [AllureStep("Click on List View button")]
        public void ClickListViewButton() {
            IWebElement oldElement = driver.FindElement(xpathClickListViewButton);
            try {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                wait.Until(ExpectedConditions.StalenessOf(oldElement));
            }
            catch (Exception) {

            }
            driver.FindElement(xpathClickListViewButton).Click();
        }


        [AllureStep("Click on Delete button")]
        public void ClickDeleteButton() {
            // Create Action Class:
            Actions actions = new Actions(driver);

            // Hover to element and click Delete button:
            actions.MoveToElement(elementSpace).Click(deleteButton).Perform();

            // Click Confirm button to delete:
            confirmButton.Click();
        }


        [AllureStep("Click on View Details")]
        public void ClickViewDetails() {
            // Create Action Class:
            Actions actions = new Actions(driver);

            // Hover to element and click Delete button:
            actions.MoveToElement(elementSpace).Click(viewsDetailsButton).Perform();

        }


        [AllureStep("Click on Edit button")]
        public void ClickEditButton() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    driver.FindElement(xpathClickEditButton).Click();
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathClickEditButton} not found after 60 seconds");

        }


        [AllureStep("Click on Update Project button")]
        public void ClickUpdateProjectButton() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    driver.FindElement(xpathClickUpdateProjectButton).Click();
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathClickUpdateProjectButton} not found after 60 seconds");

        }


        public void Update_Project() {
            ClickAddButton();
            InputRandom_Title();
            InputRandom_EstimatedHour();
            InputRandom_Summary();
            InputRandom_Description();
            Input_StartDate();
            Input_EndDate();
            InputClient();
            InputTeam();
            ClickSaveButton();
            ClickProjectsNavMenu();
            ClickListViewButton();
            ClickViewDetails();
            ClickEditButton();
            InputUpdate_Title();
            InputUpdate_EstimatedHour();
            InputUpdate_StartDate();
            InputUpdate_EndDate();
            InputUpdate_Summary();
            InputUpdate_Description();
            InputUpdate_Client();
            InputUpdate_Team();
            ClickUpdateProjectButton();
        }


        [AllureStep("Input StartDate")]
        public void InputUpdate_StartDate() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    IWebElement dateTimeBox = driver.FindElement(xpathInputUpdate_StartDate);
                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    string dateTimeValue = RandomHelper.RandomDate();
                    js.ExecuteScript("arguments[0].value = arguments[1];", dateTimeBox, dateTimeValue);
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathInputUpdate_StartDate} not found after 60 seconds");

        }


        [AllureStep("Input EndDate")]
        public void InputUpdate_EndDate() {
            DateTime maxTime = DateTime.Now.AddMinutes(1);

            while (DateTime.Now < maxTime) {
                try {
                    IWebElement dateTimeBox = driver.FindElement(xpathInputUpdate_EndDate);
                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    string dateTimeValue = RandomHelper.RandomDate();
                    js.ExecuteScript("arguments[0].value = arguments[1];", dateTimeBox, dateTimeValue);
                }
                catch (Exception ex) {
                    // Log other exceptions if necessary
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            throw new Exception($"{xpathInputUpdate_EndDate} not found after 60 seconds");

        }


        [AllureStep("Verify Update Success Message is displayed")]
        public bool IsUpdateSuccessMessageDisplay(int timeout = 1) {
            try {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
                return driver.FindElement(xpathSuccessUpdateMessage).Displayed;
            }
            catch {
                return false;
            }
            finally {
                int defaultTimeout = int.Parse(ConfigurationHelper.GetConfig<string>("timeout"));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(defaultTimeout);
            }
        }


        [AllureStep("Verify Delete Success Message is displayed")]
        public bool IsDeleteSuccessMessageDisplay(int timeout = 1) {
            try {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
                return driver.FindElement(xpathSuccessDeleteMessage).Displayed;
            }
            catch {
                return false;
            }
            finally {
                int defaultTimeout = int.Parse(ConfigurationHelper.GetConfig<string>("timeout"));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(defaultTimeout);
            }
        }


        // Navigate Function:
        [AllureStep("Click on Calender menu")]
        public void ClickCalenderButton() {
            driver.FindElement(xpathClickCalenderButton).Click();
        }


        [AllureStep("Verify Calender board is displayed")]
        public bool IsCalenderBoardDisplayDisplay(int timeout = 1) {
            try {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
                return driver.FindElement(xpathCalenderBoardDisplay).Displayed;
            }
            catch {
                return false;
            }
            finally {
                int defaultTimeout = int.Parse(ConfigurationHelper.GetConfig<string>("timeout"));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(defaultTimeout);
            }
        }


        [AllureStep("Verify Event label is displayed")]
        public bool IsEventsLabelDisplay(int timeout = 1) {
            try {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
                return driver.FindElement(xpathEventsLabelDisplay).Displayed;
            }
            catch {
                return false;
            }
            finally {
                int defaultTimeout = int.Parse(ConfigurationHelper.GetConfig<string>("timeout"));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(defaultTimeout);
            }
        }


        [AllureStep("Verify Calender navigation label is displayed")]
        public string CalenderLabelDisplay() {
            return driver.FindElement(xpathCalenderLabel).Text;
        }


        [AllureStep("Click on KanbanBoard button")]
        public void ClickKanbanBoardButton() {
            driver.FindElement(xpathClickKanbanBoardButton).Click();
        }


        [AllureStep("Verify KanbanBoard navigation label is displayed")]
        public string KanbanBoardLabelDisplay() {
            return driver.FindElement(xpathKanbanBoardLabel).Text;
        }


        public void Input_AllFields(string title, string estimatedHour, string summary, string description) {
            InputTitle(title);
            InputEstimatedHour(estimatedHour);
            InputClient();
            InputPriority();
            Input_StartDate();
            Input_EndDate();
            InputSummary(summary);
            InputTeam();
            InputDescription(description);
        }


        [AllureStep("Input into Search Textbox")]
        public void InputSearchTextbox(string searchValue) {
            driver.FindElement(xpathInputSearchTextbox).SendKeys(searchValue);
        }


        public void ViewProjectDetail(string searchValue) {
            ClickListViewButton();
            InputSearchTextbox(searchValue);
            ClickViewDetails();
        }


        public string GetProjectTitle() {
            return driver.FindElement(xpathInputTitle).GetAttribute("value");
        }


        public string GetProjectEstimatedHour() {
            return driver.FindElement(xpathInputEstimatedHour).GetAttribute("value");
        }


        public string GetProjectSummary() {
            return driver.FindElement(xpathInputUpdate_Summary).Text;
        }

        public Boolean isProjectCreated(string title, string estimatedHour, string summary) {
            return GetProjectTitle().Equals(title) && GetProjectEstimatedHour().Equals(estimatedHour) && GetProjectSummary().Equals(summary);
        }
    }
}
