using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestingUnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public IWebDriver driver;
        public readonly string site;
        public UnitTest1()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            site = "https://mango-flower-00e2aa010.azurestaticapps.net/";
        }
        [TestMethod]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl(site);
            System.Threading.Thread.Sleep(2000);
            var blueBox = driver.FindElement(By.ClassName("color-blue"));
            blueBox.Click();
            System.Threading.Thread.Sleep(2000);
            var container = driver.FindElement(By.ClassName("color-container"));

            Assert.AreEqual("color-container color-blue", container.GetAttribute("class"));
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }
    }
}
