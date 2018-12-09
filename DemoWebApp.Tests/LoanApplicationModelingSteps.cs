using System;
using TechTalk.SpecFlow;

namespace DemoWebApp.Tests
{
    [Binding]
    public class LoanApplicationModelingSteps
    {
        [Given(@"I select the option VerySmallBusiness")]
        public void GivenISelectTheOptionVerySmallBusiness()
        {
            Console.WriteLine("implement GivenISelectTheOptionVerySmallBusiness()");
        }
        
        [Given(@"I select the option (.*)")]
        public void GivenISelectTheOption(string p0)
        {
            Console.WriteLine("implement GivenISelectTheOption(string p0)");
        }
        
        [Given(@"I have a condition")]
        public void GivenIHaveACondition()
        {
            Console.WriteLine("implement GivenIHaveACondition()");
        }
        
        [When(@"I do something with it")]
        public void WhenIDoSomethingWithIt()
        {
            Console.WriteLine("WhenIDoSomethingWithIt()");
        }
        
        [Then(@"I should expect")]
        public void ThenIShouldExpect()
        {
            Console.WriteLine("implement ThenIShouldExpect()");
        }
    }
}
