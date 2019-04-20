using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumAutomationStandard;
using SeleniumAutomationStandard.Pages;

namespace SeleniumAutomationTests
{
    [TestClass]
    public class CanCreateUserTest : BaseTest
    {
        [TestMethod]
        public void CanCreateUser()
        {
            UserManagementPage.GoTo();
            CreateUserPage.GoTo();
            var username = "username" + System.Guid.NewGuid().ToString();
            CreateUserPage.CreateUser(username)
                .WithFirstName("firstName")
                .WithLastName("LastName")
                .WithEmail("test@test.com")
                .WithPassword("password")
                .WithRole("guest")
                .Save();

            Assert.IsTrue(UserManagementPage.HasUser(username), "User was not found");
        }
    }

}