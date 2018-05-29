using Ecrion.Test.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

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
            //Clipboard.SetText(xml);
            //_driver.FindElement(By.Name("Xml")).SendKeys(Keys.Control + "v");
            _driver.FindElement(By.Name("Xml")).SendKeys(xml);
            _driver.FindElement(By.Id("submitButton")).Click();
        
        }

        [Then(@"PDF should render Member Billing Information")]
        public void ThenPdfShouldRenderMemberBillingInformation()
        {
            var billingValue = _driver.FindElement(By.Id("5296062")).Text;
            var accountNumber = _driver.FindElement(By.Id("5452081")).Text;
            var lateChargesValue = _driver.FindElement(By.Id("4972147")).Text;
            var dueDate = _driver.FindElement(By.Id("4647461")).Text;
            Assert.AreEqual("200.46", billingValue);
            Assert.AreEqual("10100300", accountNumber);
            Assert.AreEqual("1.00", lateChargesValue);
            Assert.AreEqual("12/13/2016", dueDate);

            _driver.Close();
        }
    }
}
