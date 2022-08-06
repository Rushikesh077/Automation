using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
namespace SeleniumAutomation
{
   public class Test
    {
         OpenQA.Selenium.IWebDriver driver;
        

        [SetUp]
        public void StartBrowser()
        {
            
            driver = new ChromeDriver("D:\\Automation\\SeleniumAutomation\\packages\\Selenium.Chrome.WebDriver.85.0.0\\driver");
            
        }

        [Test]
        public void DemoTest()
        {
            driver.Url = "https://www.google.co.in/";
            driver.Navigate().GoToUrl(driver.Url);
            driver.Manage().Window.Maximize();
            int x = driver.WindowHandles.Count;
            Console.WriteLine(x);
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
