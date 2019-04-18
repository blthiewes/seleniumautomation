﻿using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumAutomationStandard
{
    public class CreateUserPage
    {
        public static void GoTo()
        {
            var source = Driver.Instance.PageSource;
            Driver.Instance.SwitchTo().ParentFrame().SwitchTo().Frame(1);
            source = Driver.Instance.PageSource;
            var createButton = Driver.Instance.FindElement(By.Name("doCreate"));
            createButton.Click();
        }

        public static CreateUserCommand CreateUser(string username)
        {
            return new CreateUserCommand(username);
        }
    }
}
