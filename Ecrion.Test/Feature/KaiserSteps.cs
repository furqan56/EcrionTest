using System;
using TechTalk.SpecFlow;

namespace Ecrion.Test.Feature
{
    [Binding]
    public class KaiserSteps
    {
        [Given(@"the XML for Kaiser Outreach Template")]
        public void GivenTheXmlForKaiserOutreachTemplate()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"template generated from Ecrion")]
        public void WhenTemplateGeneratedFromEcrion()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"PDF should render on Kaiser Outreach Template with XML Data")]
        public void ThenPdfShouldRenderOnKaiserOutreachTemplateWithXmlData()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
