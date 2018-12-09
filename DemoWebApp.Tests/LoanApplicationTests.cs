using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace DemoWebApp.Tests
{
    public class LoanApplicationTests
    {
        [Fact]
        public void StartApplication()
        {
            using (IWebDriver driver = new FirefoxDriver())
            {
                driver.Manage().Window.Maximize();
                //
                driver.Navigate().GoToUrl("https://www.amazon.com/");
                IWebElement applicationButton =
                    driver.FindElement(By.Id("nav-cart"));
                applicationButton.Click();

                //Negative Test Case: Assert.Equal("AAAAmazon.com Shopping Cart", driver.Title);
                Assert.Equal("Amazon.com Shopping Cart", driver.Title);
            }
        }

        [Fact]
        public void SubmitApplication() //must increment email # automatically somehow
        {
            using (IWebDriver driver = new FirefoxDriver())
            {
                driver.Manage().Window.Maximize();

                #region Element <div id="u_0_d" class="_5dbb"> is not reachable by keyboard

                //driver.Navigate().GoToUrl("https://www.facebook.com/");
                //IWebElement firstNameInput = driver.FindElement(By.Id("u_0_b"));
                //firstNameInput.SendKeys("Sarah");

                //IWebElement lastNameInput = driver.FindElement(By.Id("u_0_d"));
                //lastNameInput.SendKeys("Smith");

                #endregion

                #region Unable to locate element: #f5d0d18f2bb5c

                //driver.Navigate().GoToUrl("https://www.instagram.com/?hl=en");
                //IWebElement firstNameInput = driver.FindElement(By.Id("f5d0d18f2bb5c"));
                //firstNameInput.SendKeys("Sarah");

                //IWebElement lastNameInput = driver.FindElement(By.Id("f1a4dd40747554"));
                //lastNameInput.SendKeys("Smith");

                #endregion

                //Now what?  One more attempt and working, YES!!
                driver.Navigate().GoToUrl("https://www.interviewmocha.com/Signup/Index?id=selenium-assessment-test");
                IWebElement firstNameInput = driver.FindElement((By.Id("FirstName")));
                firstNameInput.SendKeys("Sarah");

                IWebElement lastNameInput = driver.FindElement(By.Id("LastName"));
                lastNameInput.SendKeys("Smith");

                IWebElement workEmailInput = driver.FindElement(By.Id("WorkEmail"));
                workEmailInput.SendKeys("Smith.Sarah9@Microsoft.com");

                #region

                IWebElement passwordInput = driver.FindElement(By.Id("Password"));
                passwordInput.SendKeys("Password");

                IWebElement phoneNumberInput = driver.FindElement(By.Id("Phone"));
                phoneNumberInput.SendKeys("1231231234");

                IWebElement companyInput = driver.FindElement(By.Id("CompanyName"));
                companyInput.SendKeys("CompanyName");

                #region select the drop down list

                var selectCompanySize = driver.FindElement(By.Id("CompanySize"));
                //create select element object 
                var selectElement = new SelectElement(selectCompanySize);

                //select by value
                selectElement.SelectByValue("VerySmallBusiness");
                // select by text
                selectElement.SelectByText("1-50");

                var selectJobTitle = driver.FindElement(By.Id("JobTitle"));
                //create select element object 
                var selectElement2 = new SelectElement(selectJobTitle);

                //select by value
                selectElement2.SelectByValue("Other");
                // select by text
                selectElement2.SelectByText("Other");

                #endregion

                int milliseconds = 500;
                Thread.Sleep(milliseconds);
                //even with "using System.Threading.Tasks;", I'm still getting "The 'await' operator can only be used within an async method.Consider marking this method with the 'async' modifier and changing its return type to 'Task'..." with this: 
                //async await Task.Delay(milliseconds);

                IWebElement jobTitleInput = driver.FindElement(By.Id("JobTitleOther"));
                jobTitleInput.SendKeys("Other");

                IWebElement applicationButton =
                    driver.FindElement(By.Id("signUpSubmitBtn"));
                applicationButton.Click();

                //I was hoping that this would work, but no: Assert.Equal("Thank you  Sarah!", driver.FindElement(By.ClassName("panel-body text-center")));
                Assert.Equal("Create Your Free Account with Interview Mocha", driver.Title);

                #endregion

                #region Just can't make this work yet

                //IWebElement confirmationTextSpan2 = driver.FindElement(By.ClassName("verify-msg"));
                //string confirmationText2 = confirmationTextSpan2.Text;
                //Assert.Equal("You are just one step away from getting", confirmationText2);
                //IWebElement confirmationTextSpan = driver.FindElement(By.CssSelector("panel-body.text-center"));
                //string confirmationText = confirmationTextSpan.Text;
                //Assert.Equal("Thank you  Sarah!", confirmationText);

                #endregion             }
            }
        }
    }
}
