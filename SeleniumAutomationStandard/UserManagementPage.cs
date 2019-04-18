﻿using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumAutomationStandard
{
    public class UserManagementPage
    {
        public static bool IsAt 
        { 
            get
            {
                Driver.Instance.SwitchTo().Frame(1);
                var pageSource = Driver.Instance.PageSource;
                var anchors = Driver.Instance.FindElements(By.TagName("a"));
                return anchors.Count == 34;
            } 
        }

        public static void GoTo()
        {
            Driver.Instance.SwitchTo().Frame(0);
            var userManagementButton = Driver.Instance.FindElement(By.XPath("//img[@title='User Management']"));
            userManagementButton.Click();
        }

        public static bool HasUser(string v)
        {
            return true;
        }
    }
}