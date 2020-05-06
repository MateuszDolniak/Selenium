using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testowanie_Selenium
{
    [TestFixture]
    public class CompareLoginLink
    {
        private IWebDriver driver;
        public string homeURL;


        [Test(Description = "Test sprawdza czy odnośnik do logowania istnieje.")]
        public void Login_is_on_home_page()
        {


            homeURL = "https://www.SauceLabs.com";
            driver.Navigate().GoToUrl(homeURL);
            WebDriverWait wait = new WebDriverWait(driver,
System.TimeSpan.FromSeconds(15));
            wait.Until(driver =>
driver.FindElement(By.XPath("//header[@id='headerMainNav']//nav[@class='nav-container']/ul[@class='nav-navigation-list']//ul[@class='nav-action-list-items']//a[@href='https://accounts.saucelabs.com/']")));
            IWebElement element =
driver.FindElement(By.XPath("//header[@id='headerMainNav']//nav[@class='nav-container']/ul[@class='nav-navigation-list']//ul[@class='nav-action-list-items']//a[@href='https://accounts.saucelabs.com/']"));
            Assert.AreEqual("Sign in", element.GetAttribute("text"));


        }


        [TearDown]
        public void TearDownTest()
        {
            driver.Close();
        }


        [SetUp]
        public void SetupTest()
        {
            homeURL = "http://SauceLabs.com";
            driver = new ChromeDriver();

        }


    }
}
