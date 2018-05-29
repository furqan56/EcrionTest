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
using OpenQA.Selenium.Support.Extensions;

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
            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--headless");
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
            var xml = File.ReadAllText("..\\..\\Files\\Kaiser\\KaiserSureNet_OutReach.xml");
            var value = driver.FindElement(By.ClassName("td1"));
            Assert.AreEqual(value.Text, "FORMULARY CHANGE NOTICE");
        }


        [TestCleanup]
        public void TearDown()
        {
            driver.Close();
        }

    }
}
