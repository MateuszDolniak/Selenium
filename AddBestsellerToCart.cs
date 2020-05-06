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
    class AddBestsellerToCart
    {

        public IWebDriver driver;

        [Test(Description = "Test dodaje bestsellery do koszyka.")]
        public void Bestseller()
        {
            var newBook = new LoginWindowcs(driver);
            newBook.SearchForBook("czysty kod");

            var checkDetails = new LoginWindowcs(driver);
            checkDetails.CheckBookDetails();

            var bestBook = new LoginWindowcs(driver);
            bestBook.BestsellerBook();
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
        [TearDown]

        public void cleanUp()
        {
            driver.Close();
        }
    }
}
