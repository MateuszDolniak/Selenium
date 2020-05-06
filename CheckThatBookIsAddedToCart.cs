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
    class CheckThatBookIsAddedToCart
    {
        public IWebDriver driver;
        [Test(Description = "Test dodaje książke do koszyka.")]

        public void GetBook()
        {

            var newBook = new LoginWindowcs(driver);
            newBook.SearchForBook("czysty kod");

            var newCard = new LoginWindowcs(driver);
            newCard.GetBookToCard();

        }
        [SetUp]

        public void AddToCard()
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
