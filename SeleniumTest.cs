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
        public void NavigateToWebSiteLogin()
        {
            //Navigate to Website - Successful
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://clerkconnectdevtest.azurewebsites.net/myaccount");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            //Send Log-in information to Email and Password Fields - Sucessful
            var EmailLogin = driver.FindElement(By.Name("email"));
            EmailLogin.SendKeys("newgreenr70@gmail.com");

            //Send password to password field - Successful
            var PasswordLogin = driver.FindElement(By.Name("password"));
           PasswordLogin.SendKeys("Playstationvsxbox88!");

            //Click the the "Sign in" button - Successful
            var SignInButton = driver.FindElement(By.TagName("Button"));
            SignInButton.Click();

            //Open E-Recording - Successful
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            var ERecordingGO = driver.FindElement(By.XPath("//*[@id=\"mysubscriptiontable\"]/div/table/tbody/tr[1]/td[7]/a"));
            ERecordingGO.Click();

            //Press Enter on the E-Recording Ok screen
           





        }
    }
}