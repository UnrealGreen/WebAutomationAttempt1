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

            driver2.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

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

            driver2.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
            var party = driver2.FindElement(By.XPath("//*[@id=\"tab-content-1\"]/div/div[1]/marriage-party/div/div[1]/div[1]/div/select"));
            party.Click();
            party.SendKeys(Keys.ArrowDown);
            party.SendKeys(Keys.Enter);
            party.SendKeys(Keys.Tab);

            //Entering the Party A Gender - Successful

            driver2.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            var Gender = driver2.FindElement(By.XPath("//*[@id=\"tab-content-1\"]/div/div[1]/marriage-party/div/div[1]/div[2]/div/select"));
            Gender.Click();
            Gender.SendKeys(Keys.ArrowDown);
            Gender.SendKeys(Keys.Enter);
            Gender.SendKeys(Keys.Tab);

            //Entering lastname, firstname - Successful
            driver2.FindElement(By.XPath("//*[@id=\"tab-content-1\"]/div/div[1]/marriage-party/div/div[2]/div[1]/input")).SendKeys("Test");

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-1\"]/div/div[1]/marriage-party/div/div[2]/div[3]/input")).SendKeys("Test");

            //Entering Residence Address, City, Parish/County, State, ZIP - Successful

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-1\"]/div/div[1]/marriage-party/div/div[3]/div/div[1]/input")).SendKeys("900 North Market");

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-1\"]/div/div[1]/marriage-party/div/div[3]/div/div[2]/input")).SendKeys("Bossier");

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-1\"]/div/div[1]/marriage-party/div/div[3]/div/div[3]/input")).SendKeys("Webster");

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-1\"]/div/div[1]/marriage-party/div/div[3]/div/div[4]/input")).SendKeys("Lousiana");

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-1\"]/div/div[1]/marriage-party/div/div[3]/div/div[5]/input")).SendKeys("71055");

            //Entering Phone Number, Email, Race, Date of Birth, City - Successful

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-1\"]/div/div[1]/marriage-party/div/div[4]/div/div[1]/input")).SendKeys("318-700-1000");

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-1\"]/div/div[1]/marriage-party/div/div[4]/div/div[2]/input")).SendKeys("none@gmail.com");

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-1\"]/div/div[1]/marriage-party/div/div[4]/div/div[3]/input")).SendKeys("White");

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-1\"]/div/div[1]/marriage-party/div/div[4]/div/div[4]/input")).SendKeys("04/11/1995");

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-1\"]/div/div[1]/marriage-party/div/div[4]/div/div[5]/input")).SendKeys("Bossier");

            //Entering Mother Name and Birthplace - Successful

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-1\"]/div/div[1]/marriage-party/div/div[5]/div[2]/div[1]/input")).SendKeys("Debby");

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-1\"]/div/div[1]/marriage-party/div/div[5]/div[2]/div[2]/input")).SendKeys("Texas");

            //Pressing Next button for Party A - Successful

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-1\"]/div/div[2]/button")).SendKeys(Keys.Enter);

            //Enter the same information for Party B

            //Groom and Gender - Successful
            

            driver2.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var partyB = driver2.FindElement(By.XPath("//*[@id=\"tab-content-2\"]/div/div[1]/div/marriage-party/div[1]/div[1]/div[1]/div/select"));
            partyB.SendKeys(Keys.Enter);
            partyB.SendKeys(Keys.ArrowDown);
            partyB.SendKeys(Keys.Enter);
            partyB.SendKeys(Keys.Tab);


            driver2.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
            var GenderB = driver2.FindElement(By.XPath("//*[@id=\"tab-content-2\"]/div/div[1]/div/marriage-party/div[1]/div[1]/div[2]/div/select"));
            GenderB.SendKeys(Keys.Enter);
            GenderB.SendKeys(Keys.ArrowDown);
            GenderB.SendKeys(Keys.Enter);
            GenderB.SendKeys(Keys.Tab);

            //Lastname, Firstname - Successful
            driver2.FindElement(By.XPath("//*[@id=\"tab-content-2\"]/div/div[1]/div/marriage-party/div[1]/div[2]/div[1]/input")).SendKeys("Test");

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-2\"]/div/div[1]/div/marriage-party/div[1]/div[2]/div[3]/input")).SendKeys("Test");
            //Resideence Address, City, Parish/County, State, ZIP - Successful

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-2\"]/div/div[1]/div/marriage-party/div[1]/div[3]/div/div[1]/input")).SendKeys("900 North Market");

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-2\"]/div/div[1]/div/marriage-party/div[1]/div[3]/div/div[2]/input")).SendKeys("Bossier");

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-2\"]/div/div[1]/div/marriage-party/div[1]/div[3]/div/div[3]/input")).SendKeys("Webster");

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-2\"]/div/div[1]/div/marriage-party/div[1]/div[3]/div/div[4]/input")).SendKeys("Lousiana");

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-2\"]/div/div[1]/div/marriage-party/div[1]/div[3]/div/div[5]/input")).SendKeys("71055");

            //Phone Number, Email, Race, Date of Birth, City

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-2\"]/div/div[1]/div/marriage-party/div[1]/div[4]/div/div[1]/input")).SendKeys("318-700-1000");

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-2\"]/div/div[1]/div/marriage-party/div[1]/div[4]/div/div[2]/input")).SendKeys("none@gmail.com");

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-2\"]/div/div[1]/div/marriage-party/div[1]/div[4]/div/div[3]/input")).SendKeys("White");

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-2\"]/div/div[1]/div/marriage-party/div[1]/div[4]/div/div[4]/input")).SendKeys("04/11/1995");

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-2\"]/div/div[1]/div/marriage-party/div[1]/div[4]/div/div[5]/input")).SendKeys("Bossier");

            //MotherName and Birthplace

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-2\"]/div/div[1]/div/marriage-party/div[1]/div[5]/div[2]/div[1]/input")).SendKeys("Martha");

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-2\"]/div/div[1]/div/marriage-party/div[1]/div[5]/div[2]/div[2]/input")).SendKeys("Colorodo");

            //Pressing Next button for Party B

            driver2.FindElement(By.XPath("//*[@id=\"tab-content-2\"]/div/div[2]/button[2]")).SendKeys(Keys.Enter);

            //Click Next on the "Covenant Marriage" page. 
            driver2.FindElement(By.XPath("//*[@id=\"tab-content-3\"]/div/div[2]/button[2]")).SendKeys(Keys.Enter);

            //Add notes to clerk
            driver2.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
            driver2.FindElement(By.XPath("//*[@id=\"notes\"]")).SendKeys("Automated Test");

            //Click Submit 
            driver2.FindElement(By.XPath("//*[@id=\"submitbtn\"]")).SendKeys(Keys.Enter);


















        }

    }
}