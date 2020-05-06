using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Testowanie_Selenium
{
    class BookstoreTest
    {
        public IWebDriver driver;
        
        public static void Main()
        {
        }
        [Test]
        public void Test_01_Logon_Helion()
        {
            var loginWindow = new LoginWindowcs(driver);
            loginWindow.LoginToHelion("testowanieseleniumugn3231@gmail.com", "Zaq12wsx&");
        }
        [SetUp]
        public void SetUpTests()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://helion.pl/users/index.cgi";
        }
        [TearDown]
        public void cleanUp()
        {
            driver.Close();
        }

    }
     
}
