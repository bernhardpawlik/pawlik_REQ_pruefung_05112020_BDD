using System;
using TechTalk.SpecFlow;
using Xunit;
using Xunit.Sdk;

namespace pawlik_REQ_pruefung_05112020
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        double v1;
        double res;

        [Given(@"the number is Pi")]
        public void GivenTheNumberIsPi()
        {
            v1 = Math.PI;
        }
        
        [When(@"sinus is called")]
        public void WhenSinusIsCalled()
        {
            res = Math.Sin(v1);
        }
        
        [When(@"cosinus is called")]
        public void WhenCosinusIsCalled()
        {
            res = Math.Cos(v1);
        }
        
        [When(@"tangens is called")]
        public void WhenTangensIsCalled()
        {
            res = Math.Tan(v1);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.Equal(p0, res, 5);
        }
    }
}
