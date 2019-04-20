using System;
using OpenQA.Selenium;
using SeleniumAutomationStandard.Selenium;

namespace SeleniumAutomationStandard
{
    public class LoginCommand
    {
        private string username;
        private string password;


        public LoginCommand(string username)
        {
            this.username = username;
        }

        public LoginCommand WithPassword(string password)
        {
            this.password = password;
            return this;
        }

        public void Login()
        {
            var pageSource = Driver.Instance.PageSource;
            var loginInput = Driver.Instance.FindElement(By.Id("tl_login"));
            loginInput.SendKeys(username);
            var passwordInput = Driver.Instance.FindElement(By.Id("tl_password"));
            passwordInput.SendKeys(password);
            var loginButton = Driver.Instance.FindElement(By.XPath("//input[@value='Login']"));
            loginButton.Click();
        }
    }
}