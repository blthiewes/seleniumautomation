using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumAutomationStandard;

namespace SeleniumAutomationTests
{
    [TestClass]
    public class LoginTest : BaseTest
    {
        [TestMethod]
        public void Admin_User_Can_Login()
        {
            Assert.IsTrue(HomePage.IsAt, "Failed to login");
        }
    }
}