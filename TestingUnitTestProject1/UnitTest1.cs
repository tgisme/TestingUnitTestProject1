using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Drawing.Imaging;
//using System.Drawing.Imaging.ScreenshotImageFormat.Png;
//using OpenQA.Selenium.ScreenshotImageFormat;
using System.IO;
using System.Net.Http;

namespace TestingUnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public IWebDriver driver;
        public readonly string site;
        public string testtest = "I am testing this";
        //private TestContext testContextInstance;
        //public TestContext TestContext
        //{
        //    get
        //    {
        //        return testContextInstance;
        //    }
        //    set
        //    {
        //        testContextInstance = value;
        //    }
        //}
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


            //var filePath = $"{TestContext.TestDir}//{TestContext.TestName}99.jpg";
            //var filePath = ("C:/temp/Screenshot.png", ImageFormat.Png);
            //var filePath = "C:\\Users\\taylo\\source\\repos\\TestingUnitTestProject1\\TestResults\\Screenshot.png";

            //Screenshot image = ((ITakesScreenshot)driver).GetScreenshot();
            //image.SaveAsFile(filePath, OpenQA.Selenium.ScreenshotImageFormat.Png);

            //TestContext.AddTestAttachment(filePath);
            //TestContext.AddResultFile(filePath);
            //using (HttpClient client = new HttpClient())
            //{
            //    using (resource)
            //    {
            //        using (resource)
            //        {

            //        }
            //    }

            //}
            Assert.AreEqual("color-container color-blue", container.GetAttribute("class"));
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

    }
}
