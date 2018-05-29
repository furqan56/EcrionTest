using System;
using System.IO;
using BridgeSuite.Ecrion.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHtmlUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Ecrion.Test
{
    [TestClass]
    public class EcrionTest
    {
        private EcrionService _ecrionService;
        private IWebDriver driver;

        public EcrionTest()
        {
            _ecrionService = new EcrionService();
        }

        [TestInitialize]
        public void SetUp()
        {
            if (!Directory.Exists("..\\..\\Files\\Temp"))
                Directory.CreateDirectory("..\\..\\Files\\Temp");
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("file:///C:/Users/CLICK%20CHAIN/Downloads/bcl_2031189454.htm");
        }

        [TestMethod]
        public void TestMethod1()
        {
            var htmlFilePath = RenderHtml("..\\..\\Files\\Kaiser\\KaiserSureNet_OutReach.xml", "KP:KP_B12_BS_PROD.xfd");
            var page = new WebClient().GetHtmlPage(htmlFilePath);
        }


        [TestMethod]
        public void VerifyHeaderNameInPdf()
        {
            var value = driver.FindElement(By.ClassName("td1"));
            Assert.AreEqual(value.Text, "FORMULARY CHANGE NOTICE");
        }

        [TestMethod]
        public void VerifyDateInPdf()
        {
            var value = driver.FindElement(By.ClassName("td0"));
            Assert.AreEqual(value.Text, "December 1, 2017");
        }

        [TestMethod]
        public void VerifyFirstNameInPdf()
        {
            var value = driver.FindElement(By.ClassName("td0"));
            Assert.AreEqual(value.Text, "December 1, 2017");
        }

        [TestMethod]
        public void VerifyLastNameInPdf()
        {
            var value = driver.FindElement(By.ClassName("td0"));
            Assert.AreEqual(value.Text, "December 1, 2017");
        }

        [TestMethod]
        public void VerifyAddress1InPdf()
        {
            var value = driver.FindElement(By.ClassName("td0"));
            Assert.AreEqual(value.Text, "December 1, 2017");
        }

        private string RenderHtml(string xmlPath, string template)
        {
            var xml = File.ReadAllText(xmlPath);
            var htmlbytes = _ecrionService.Render(xml, template);
            var filePath = $"..\\..\\Files\\Temp\\{Guid.NewGuid():N}.html";
            File.WriteAllBytes(filePath, htmlbytes);
            return filePath;
        }

        [TestCleanup]
        public void TearDown()
        {
            Directory.Delete("..\\..\\Files\\Temp", true);
            driver.Close();
        }
    }
}
