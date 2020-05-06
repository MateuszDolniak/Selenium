using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Testowanie_Selenium
{
    class CheckThatAudiobookCatIsAvailable
    {
        public IWebDriver driver;
        [Test(Description = "Test sprawdza czy kategoria Audiobook jest dostępna.")]
        public void CheckAudio()
        {
            var checkAudioBook = new LoginWindowcs(driver);
            checkAudioBook.CheckAudioBook();
        }
        [SetUp]
        public void SetupOrderBook()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://helion.pl/users/index.cgi";
            var login = new LoginWindowcs(driver);
            login.LoginToHelion("testowanieseleniumugn3231@gmail.com", "Zaq12wsx&");
        }
        public void cleanUp()
        {
            driver.Close();
        }

    }
}
