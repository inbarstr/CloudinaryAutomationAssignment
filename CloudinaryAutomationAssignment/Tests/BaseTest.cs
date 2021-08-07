using CloudinaryAutomationAssignment.Common;
using CloudinaryAutomationAssignment.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Xml;

namespace CloudinaryAutomationAssignment.Tests
{
    [TestClass]
    public class BaseTest
    {
        public static ConfigData configData = new ConfigData();
        public IWebDriver webDriver;

        public BaseTest()
        {
        }

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testName)
        {
            var doc = new XmlDocument();

            doc.Load("CloudinaryAutomationAssignment_ConfigData.xml");
            var xmlNode = doc.DocumentElement.SelectSingleNode("Url");
            configData.Url = xmlNode.InnerText;

            xmlNode = doc.DocumentElement.SelectSingleNode("User");
            var userName = xmlNode.SelectSingleNode("userName").InnerText;
            var password = xmlNode.SelectSingleNode("password").InnerText;
            configData.User = new User() { UserName = userName, Password = password };
        }

        public void OpenBrowser(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Firefox:
                    webDriver = new FirefoxDriver();
                    break;
                case BrowserType.Chrome:
                default:
                    webDriver = new ChromeDriver();
                    break;
            }

            if (webDriver != null)
            {
                webDriver.Navigate().GoToUrl(configData.Url);
                webDriver.Manage().Window.Maximize();
            }
        }

        [TestCleanup]
        public void AssemblyCleanup()
        {
            webDriver.Quit();
        }
    }
}
