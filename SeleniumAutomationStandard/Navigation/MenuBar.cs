using OpenQA.Selenium;
using SeleniumAutomationStandard.Selenium;

namespace SeleniumAutomationStandard.Navigation
{
    public class MenuBar
    {
        public class UserManagement
        {
            public static void Select()
            {
            Driver.Instance.SwitchTo().Frame(0);
            var userManagementButton = Driver.Instance.FindElement(By.XPath("//img[@title='User Management']"));
            userManagementButton.Click();
            }
        }
    }
}
