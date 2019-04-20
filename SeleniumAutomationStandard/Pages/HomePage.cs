using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumAutomationStandard.Selenium;

namespace SeleniumAutomationStandard.Pages
{
    public class HomePage
    {
        public static bool IsAt 
        { 
            get
            {
                Driver.Instance.SwitchTo().Frame(1);
                var pageSource = Driver.Instance.PageSource;
                var listGroups = Driver.Instance.FindElements(By.TagName("a"));
                return listGroups.Count == 34;
            } 
        }

        public void Go()
        {

            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            {
                driver.Navigate().GoToUrl(@"http://facebook.com");
            }
        }
    }
}
