using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace RequestPlatformUiTests
{
    public class RequestPlatformUiTests
    {
        [Fact]
        public void StartApplication()
        {
            using (IWebDriver driver = new FirefoxDriver()) { 
            driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://request-platform-stage.services-exchange.com");
                //IWebElement applicationButton = driver.FindElement(By.ClassName("btn --fluid --accent"));
                IWebElement applicationButton = driver.FindElement(By.CssSelector(".btn.--fluid.--accent"));
                applicationButton.Click();

            }
        }
    }
}