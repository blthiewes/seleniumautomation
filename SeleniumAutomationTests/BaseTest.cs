using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumAutomationStandard;

namespace SeleniumAutomationTests
{
    [TestClass]
    public abstract class BaseTest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
            LoginPage.GoTo();
            LoginPage.LoginAs("user").WithPassword("bitnami").Login();
        }

        [TestCleanup]
        public void TestCleanup(){
            Driver.Close();
        }
    }

}