using Allure.Net.Commons;

namespace MockProject.Test
{
    public class AssemblyTest
    {
        public AssemblyTest()
        {
            AllureLifecycle.Instance.CleanupResultDirectory();
        }
    }
}
