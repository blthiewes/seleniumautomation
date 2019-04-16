using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumAutomationStandard;

namespace SeleniumAutomationTests
{
    [TestClass]
    public class LoginTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }
        
        [TestMethod]
        public void Admin_User_Can_Login()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("user").WithPassword("bitnami").Login();

            //Assert.IsTrue(Class1.IsAt, "Failed to login");
        }
    }

}