using System;
using System.Windows.Forms;
using Ecrion.Test.Helper;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Keys = OpenQA.Selenium.Keys;

namespace Ecrion.Test.Feature
{
    [Binding]
    public class RubidouxSteps
    {
        private IWebDriver _driver;
        public RubidouxSteps()
        {

        }
        [Given(@"the XML with Member billing information")]
        public void GivenTheXmlWithMemberBillingInformation()
        {
            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--headless");
            _driver = new ChromeDriver(options);
        }

        [When(@"the Template generated from Ecrion")]
        public void WhenTheTemplateGeneratedFromEcrion()
        {
            var xml = EcrionServiceHelper.ReadXml(".\\..\\Ecrion.Test\\Files\\Rubidoux\\final_notice.xml");
            _driver.Navigate().GoToUrl(EcrionServiceHelper.BaseUri);
            _driver.FindElement(By.Name("TemplateName")).SendKeys("Rubidoux_Final_Notice:final_notice.epr");
            Clipboard.SetText(xml);
            _driver.FindElement(By.Name("Xml")).SendKeys(Keys.Control + "v");
            _driver.FindElement(By.Id("submitButton")).Click();
        }

        [Then(@"PDF should render Member Billing Information")]
        public void ThenPdfShouldRenderMemberBillingInformation()
        {
            _driver.Close();
        }
    }
}
