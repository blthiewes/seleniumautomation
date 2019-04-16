using System.IO;
using System.Reflection;
using OpenQA.Selenium.Chrome;

namespace SeleniumAutomationStandard
{
    public class DashboardPage
    {
        public void Go()
        {

            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            {
                driver.Navigate().GoToUrl(@"http://facebook.com");
            }
        }
    }
}
