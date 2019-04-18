using System;
using OpenQA.Selenium;

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
            var loginInput = Driver.Instance.FindElement(By.Name("login"));
            loginInput.SendKeys(username);
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