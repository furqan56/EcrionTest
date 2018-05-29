using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using BridgeSuite.Ecrion.Service;
using Ecrion.Test.Helper;
using java.net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using NHtmlUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using Keys = OpenQA.Selenium.Keys;

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
            var xml = File.ReadAllText("..\\..\\Files\\Rubidoux\\final_notice.xml");
            var request = new WebRequest(new URL(EcrionServiceHelper.HtmlServiceUri.ToString()), new HttpMethod(com.gargoylesoftware.htmlunit.HttpMethod.POST));
            request.SetAdditionalHeader("Content-Type", "application/json");
            request.RequestBody = JsonConvert.SerializeObject(new { xml = xml, templateName = "Rubidoux_Final_Notice:final_notice.epr" });
            var page = new WebClient().GetPage(request);
        }


        [TestMethod]
        public void VerifyHeaderNameInPdf()
        {
            var xml = ReadXml("..\\..\\Files\\Rubidoux\\final_notice.xml");
            driver.Navigate().GoToUrl(EcrionServiceHelper.BaseUri);
            driver.FindElement(By.Name("TemplateName")).SendKeys("Rubidoux_Final_Notice:final_notice.epr");
            Clipboard.SetText(xml);
            driver.FindElement(By.Name("Xml")).SendKeys(Keys.Control+"v");
            driver.FindElement(By.Id("submitButton")).Click();
        }

        private string ReadXml(string path)
        {
            var document = XDocument.Parse(File.ReadAllText(path));
            return document.ToString(SaveOptions.DisableFormatting);
        }


        [TestCleanup]
        public void TearDown()
        {
            driver.Close();
        }

    }
}
