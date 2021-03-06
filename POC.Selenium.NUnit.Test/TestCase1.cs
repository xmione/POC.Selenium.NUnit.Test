using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace POC.Selenium.NUnit.Test
{
    [TestFixture]
    class TestCase1
    {
        IWebDriver driver;
        
        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }
        
        [Test]
        public void OpenAppTest()
        {
            driver.Url = "https://www.demoqa.com";

            Assert.Pass();
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}
