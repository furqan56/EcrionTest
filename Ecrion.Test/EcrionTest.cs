using System;
using System.IO;
using BridgeSuite.Ecrion.Service;
using Ecrion.Test.Helper;
using java.net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
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
        }

        [TestMethod]
        public void TestMethod1()
        {
            var xml =File.ReadAllText("..\\..\\Files\\Kaiser\\KaiserSureNet_OutReach.xml");
            var request = new WebRequest(new URL(EcrionServiceHelper.HtmlServiceUri.ToString()),new HttpMethod(com.gargoylesoftware.htmlunit.HttpMethod.POST));
            request.SetAdditionalHeader("Content-Type", "application/json");
            request.RequestBody = JsonConvert.SerializeObject(new{xml= xml ,templateName= "KP:KP_B12_BS_PROD.xfd" });
            var page = new WebClient().GetPage(request);
        }


        [TestMethod]
        public void VerifyHeaderNameInPdf()
        {
            var value = driver.FindElement(By.ClassName("td1"));
            Assert.AreEqual(value.Text, "FORMULARY CHANGE NOTICE");
            driver.Navigate().GoToUrl("file:///C:/Users/CLICK%20CHAIN/Downloads/bcl_2031189454.htm");
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
