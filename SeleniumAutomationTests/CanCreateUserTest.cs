using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumAutomationStandard;

namespace SeleniumAutomationTests
{
    [TestClass]
    public class CanCreateUserTest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }
        
        [TestMethod]
        public void CanCreateUser()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("user").WithPassword("bitnami").Login();

            UserManagementPage.GoTo();
            CreateUserPage.GoTo();
            CreateUserPage.CreateUser("username")
                .WithFirstName("firstName")
                .WithLastName("LastName")
                .WithEmail("test@test.com")
                .WithPassword("password")
                .WithRole("roleName")
                .Save();

            Assert.IsTrue(UserManagementPage.HasUser("username"), "User was not found");
        }

        [TestCleanup]
        public void TestCleanup(){
            Driver.Close();
        }
    }

}