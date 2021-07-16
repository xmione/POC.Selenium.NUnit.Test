/*========================================================================
   Below is the break-up of the things that we plan to achieve in the test
1. Open DuckDuckGo in Chrome browser.
2. Locate search box.
3. Enter search query ‘LambdaTest’.
4. Execute the search operation.
5. Free up the resources.
 ========================================================================*/

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace POC.Selenium.NUnit
{
    public class Browse_SearchElementById_TypeKeys_Submit
    {
        IWebDriver webDriver;
        public void Init_Browser()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
        }
        public string Title
        {
            get { return webDriver.Title; }
        }
        public void Goto(string url)
        {
            webDriver.Url = url;
        }
        public void Close()
        {
            webDriver.Quit();
        }
        public IWebDriver getDriver
        {
            get { return webDriver; }
        }
    }
    class NUnit_Demo_1
    {
        Browse_SearchElementById_TypeKeys_Submit brow = new Browse_SearchElementById_TypeKeys_Submit();
        String test_url = "https://www.duckduckgo.com";
        IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {
            brow.Init_Browser();
        }

        [Test]
        public void Browse_SearchElementById_TypeKeys_Submit()
        {
            brow.Goto(test_url);
            System.Threading.Thread.Sleep(4000);

            driver = brow.getDriver;

            IWebElement element = driver.FindElement(By.XPath("//*[@id='search_form_input_homepage']")); // locating the search box by id

            element.SendKeys("LambdaTest"); // type in keys in the search box e.g.: LambdaTest

            /* Submit the Search */
            element.Submit(); 

            /* Perform wait to check the output */
            System.Threading.Thread.Sleep(2000);
        }

        [TearDown]
        public void close_Browser()
        {
            brow.Close();
        }
    }
}