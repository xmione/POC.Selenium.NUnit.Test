using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace POC.Selenium.NUnit.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.demoqa.com";
        }
    }
}
