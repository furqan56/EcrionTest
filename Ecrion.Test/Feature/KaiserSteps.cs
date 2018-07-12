using System;
using Ecrion.Test.Helper;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Ecrion.Test.Feature
{
    [Binding]
    public class KaiserSteps
    {
        private ChromeDriver _driver;

        [Given(@"the XML for Kaiser Outreach Template")]
        public void GivenTheXmlForKaiserOutreachTemplate()
        {
            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--headless");
            _driver = new ChromeDriver(options);
        }

        [When(@"template generated from Ecrion")]
        public void WhenTemplateGeneratedFromEcrion()
        {
            var xml = EcrionServiceHelper.ReadXml(".\\..\\Ecrion.Test\\Files\\Kaiser\\KaiserSureNet_OutReach.xml");
            _driver.Navigate().GoToUrl(EcrionServiceHelper.BaseUri);
            _driver.FindElement(By.Name("TemplateName")).SendKeys("KP:KP_B12_BS_PROD.xfd");
            _driver.FindElement(By.Name("Xml")).SendKeys(xml);
            _driver.FindElement(By.Id("submitButton")).Click();
        }

        [Then(@"PDF should render on Kaiser Outreach Template with XML Data")]
        public void ThenPdfShouldRenderOnKaiserOutreachTemplateWithXmlData()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
