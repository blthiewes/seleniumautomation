using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumAutomationStandard;

namespace SeleniumAutomationTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var class1 = new Class1();
            class1.Go();
        }
    }

}