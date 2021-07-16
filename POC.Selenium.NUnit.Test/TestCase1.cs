using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace POC.Selenium.NUnit.Test
{
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
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}
