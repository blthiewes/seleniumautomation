using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumAutomationStandard.Navigation;
using SeleniumAutomationStandard.Selenium;

namespace SeleniumAutomationStandard.Pages
{
    public class UserManagementPage
    {
        public static void GoTo()
        {
            MenuBar.UserManagement.Select();
        }

        public static bool HasUser(string v)
        {
            var pageSource = Driver.Instance.PageSource;
            var userLink = Driver.Instance.FindElement(By.LinkText(v));
            return userLink != null;
        }
    }
}
