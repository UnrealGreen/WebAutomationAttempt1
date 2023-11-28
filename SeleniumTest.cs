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

        /*
        public void ProcessingE_Recording()
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

            //Press Enter on the E-Recording Ok screen - Successful
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
            var CloseButton = driver.FindElement(By.XPath("/html/body/div[7]/md-dialog/form/md-dialog-actions/button"));
            CloseButton.Click();

            //Submit an E-Recording
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);







        }
        */

        public void MarriageApplication()
        {
            //Navigate to Website - Successful
            IWebDriver driver2 = new ChromeDriver();
            driver2.Navigate().GoToUrl("https://clerkconnectdevtest.azurewebsites.net/myaccount");

            driver2.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);

            //Click on Marriage application - Successful
            driver2.FindElement(By.XPath("//*[@id=\"loginWelcome\"]/div[3]/table/tbody/tr[24]/td[12]/a")).Click();

            //Selecting the wedding date - Successful
            var datePicker = driver2.FindElement(By.XPath("/html/body/div[4]/div[1]/div/div[1]/div/div/div[3]/div/md-datepicker/div[1]/button"));
            datePicker.Click();
            driver2.FindElement(By.TagName("body")).SendKeys(Keys.Enter);


            //Selecting the submit button - Successful
            driver2.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver2.FindElement(By.XPath("/html/body/div[4]/div[1]/div/div[1]/div/div/div[3]/button")).Click();

            //Entering the Party A as Groom - Successful

            driver2.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            var party = driver2.FindElement(By.XPath("//*[@id=\"tab-content-1\"]/div/div[1]/marriage-party/div/div[1]/div[1]/div/select"));
            party.Click();
            party.SendKeys(Keys.ArrowDown);
            party.SendKeys(Keys.Enter);
            party.SendKeys(Keys.Tab);

            //Entering the Party A as Groom - Successful

            driver2.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            var Gender = driver2.FindElement(By.XPath("//*[@id=\"tab-content-1\"]/div/div[1]/marriage-party/div/div[1]/div[2]/div/select"));
            Gender.Click();
            Gender.SendKeys(Keys.ArrowDown);
            Gender.SendKeys(Keys.Enter);
            Gender.SendKeys(Keys.Tab);

            //Entering lastname, firstname - Successful
            driver2.FindElement(By.XPath("//*[@id=\"tab-content-1\"]/div/div[1]/marriage-party/div/div[2]/div[1]/input")).SendKeys("Test");

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-1\"]/div/div[1]/marriage-party/div/div[2]/div[3]/input")).SendKeys("Test");

            //Entering Residence Address, City, Parish/County, State, ZIP

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-1\"]/div/div[1]/marriage-party/div/div[3]/div/div[1]/input")).SendKeys("900 North Market");

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-1\"]/div/div[1]/marriage-party/div/div[3]/div/div[2]/input")).SendKeys("Bossier");

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-1\"]/div/div[1]/marriage-party/div/div[3]/div/div[3]/input")).SendKeys("Webster");

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-1\"]/div/div[1]/marriage-party/div/div[3]/div/div[4]/input")).SendKeys("Lousiana");

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-1\"]/div/div[1]/marriage-party/div/div[3]/div/div[5]/input")).SendKeys("71055");

















        }

    }
}