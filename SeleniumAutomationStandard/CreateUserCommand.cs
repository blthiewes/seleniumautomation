using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAutomationStandard
{
    public class CreateUserCommand
    {
        private string username;
        private string firstName;
        private string lastName;
        private string email;
        private string password;
        private string role;

        public CreateUserCommand(string username)
        {
            this.username = username;
            this.firstName = "firstName";
            this.lastName = "lastName";
            this.email = "test@test.com";
            this.password = "password1";
            this.role = "guest";
        }

        public CreateUserCommand WithFirstName(string firstName)
        {
            this.firstName = firstName;
            return this;
        }

        public CreateUserCommand WithLastName(string v)
        {
            this.lastName = v;
            return this;
        }

        public void Save()
        {
            var source = Driver.Instance.PageSource;
            Driver.Instance.FindElement(By.Name("login")).SendKeys(username);
            Driver.Instance.FindElement(By.Name("firstName")).SendKeys(firstName);
            Driver.Instance.FindElement(By.Name("lastName")).SendKeys(lastName);
            Driver.Instance.FindElement(By.Name("password")).SendKeys(password);
            Driver.Instance.FindElement(By.Name("emailAddress")).SendKeys(email);
            var select = new SelectElement(Driver.Instance.FindElement(By.Name("rights_id")));
            select.SelectByText(role);
            Driver.Instance.FindElement(By.Name("do_update")).Click();
            
        }

        public CreateUserCommand WithRole(string v)
        {
            this.role = v;
            return this;
        }

        public CreateUserCommand WithPassword(string v)
        {
            this.password = v;
            return this;
        }

        public CreateUserCommand WithEmail(string v)
        {
            this.email = v;
            return this;
        }
    }
}