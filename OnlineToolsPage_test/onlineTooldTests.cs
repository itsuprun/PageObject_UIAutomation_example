using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace OnlineToolsPage
{
    [TestFixture]
    public class OnlineToolsTests
    {
        private IWebDriver driver;
        private string _url = "http://emn178.github.io/online-tools/";
        
        [SetUp]
        public void TestInitialize()
        {
            var options = new ChromeOptions();
            options.AddArgument("start-maximized");
            
            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl(_url);
        }

        [TearDown]
        public void TestFinalize()
        {
            driver.Quit();
        }

        [Test]
        public void sha256Test()
        {
            var onlineToolsPage = new OnlineToolsPage(driver);
            onlineToolsPage.ClickButton(onlineToolsPage.sha256Button);
            onlineToolsPage.fillInputArea(onlineToolsPage.inputArea,"nvdnsjjasn");
            onlineToolsPage.ClickButton(onlineToolsPage.checkButton);
            onlineToolsPage.ClickButton(onlineToolsPage.hashButton);
            Assert.IsTrue(onlineToolsPage.sha256TestPassed);
        }
        
        
    }
}