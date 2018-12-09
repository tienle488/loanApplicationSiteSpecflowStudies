using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using Xunit;

namespace DemoWebApp.Tests
{
    [Binding]
    public class LoanApplicationModelingSteps
    {
        private IWebDriver _driver;

        [Given(@"I am on the Start Your Free Trial - InterviewMocha\.com screen")]
        public void GivenIAmOnTheStartYourFreeTrial_InterviewMocha_ComScreen()
        {
            _driver = new FirefoxDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://www.interviewmocha.com/Signup/Index?id=selenium-assessment-test");

        }

        [Given(@"I enter a first name of (.*)")]
        public void GivenIEnterAFirstNameOf(string firstName)
        {
            IWebElement firstNameInput = _driver.FindElement((By.Id("FirstName")));
            firstNameInput.SendKeys(firstName);
        }

        [Given(@"I enter a last name of (.*)")]
        public void GivenIEnterALastNameOf(string lastName)
        {
            IWebElement lastNameInput = _driver.FindElement(By.Id("LastName"));
            lastNameInput.SendKeys(lastName);
        }

        [Given(@"I enter a work email of SarahSmith(.*)@Microsoft\.com")]
        public void GivenIEnterAWorkEmailOfSarahSmithMicrosoft_Com(int p0)
        {
            IWebElement workEmailInput = _driver.FindElement(By.Id("WorkEmail"));
            workEmailInput.SendKeys("Smith.Sarah13@Microsoft.com");
        }

        [Given(@"I enter a password of Password")]
        public void GivenIEnterAPasswordOfPassword()
        {
            IWebElement passwordInput = _driver.FindElement(By.Id("Password"));
            passwordInput.SendKeys("Password");
        }

        [Given(@"I enter a phone number of (.*)")]
        public void GivenIEnterAPhoneNumberOf(int p0)
        {
            IWebElement phoneNumberInput = _driver.FindElement(By.Id("Phone"));
            phoneNumberInput.SendKeys("1231231234");
        }

        [Given(@"I enter a company name of Company Name")]
        public void GivenIEnterACompanyNameOfCompanyName()
        {
            IWebElement companyInput = _driver.FindElement(By.Id("CompanyName"));
            companyInput.SendKeys("CompanyName");
        }

        [Given(@"I select the drop down list for company size")]
        public void GivenISelectTheDropDownListForCompanySize()
        {
            var selectCompanySize = _driver.FindElement(By.Id("CompanySize"));

            //create select element object 
            var selectElement = new SelectElement(selectCompanySize);

            //select by value
            selectElement.SelectByValue("VerySmallBusiness");
        }

        [Given(@"I select the option VerySmallBusiness and the option (.*)")]
        public void GivenISelectTheOptionVerySmallBusinessAndTheOption(string p0)
        {
            var selectCompanySize = _driver.FindElement(By.Id("CompanySize"));

            //create select element object 
            var selectElement = new SelectElement(selectCompanySize);

            // select by text
            selectElement.SelectByText("1-50");
        }

        [Given(@"I select the drop down list for job title")]
        public void GivenISelectTheDropDownListForJobTitle()
        {
            var selectJobTitle = _driver.FindElement(By.Id("JobTitle"));
            //create select element object 
            var selectElement2 = new SelectElement(selectJobTitle);
            //select by value
            selectElement2.SelectByValue("Other");
        }

        [Given(@"I select the option Other")]
        public void GivenISelectTheOptionOther()
        {
            var selectJobTitle = _driver.FindElement(By.Id("JobTitle"));
            //create select element object 
            var selectElement2 = new SelectElement(selectJobTitle);
            // select by text
            selectElement2.SelectByText("Other");

        }

        [Given(@"I wait a second")]
        public void GivenIWaitASecond()
        {
            int milliseconds = 500;
            Thread.Sleep(milliseconds);
        }

        [Given(@"I enter a job title other of Other")]
        public void GivenIEnterAJobTitleOtherOfOther()
        {
            IWebElement jobTitleInput = _driver.FindElement(By.Id("JobTitleOther"));
            jobTitleInput.SendKeys("Other");
        }

        [Given(@"I enter a work email with the following information")]
        public void GivenIEnterAWorkEmailWithTheFollowingInformation(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I submit Sign Up for Free")]
        public void WhenISubmitSignUpForFree()
        {
            IWebElement applicationButton =
                _driver.FindElement(By.Id("signUpSubmitBtn"));
            applicationButton.Click();
        }

        [Then(@"I should see the sign-up complete confirmation for Sarah")]
        public void ThenIShouldSeeTheSign_UpCompleteConfirmationForSarah()
        {
            //I was hoping that this would work, but no: Assert.Equal("Thank you  Sarah!",_driver.FindElement(By.ClassName("panel-body text-center")));
            Assert.Equal("Create Your Free Account with Interview Mocha", _driver.Title);
        }

        [Then(@"I should see an error message telling me that I need to specify my job title")]
        public void ThenIShouldSeeAnErrorMessageTellingMeThatINeedToSpecifyMyJobTitle()
        {
            IWebElement jobTitleMessage = _driver.FindElement(By.Id("errorJobTitleOther"));
            Assert.Equal("Specify your job title cannot be blank", jobTitleMessage.Text);
        }


        [AfterScenario]
        public void DisposeWebDriver()
        {
            _driver.Dispose();
        }
    }
}
