using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Begineer_WebTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NavigateToWebSite()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://clerkconnectdevtest.azurewebsites.net/myaccount");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            driver.FindElement(By.Name("email"));

            Assert.Pass();
        }
    }
}