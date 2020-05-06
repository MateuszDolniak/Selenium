using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Testowanie_Selenium
{
    class LoginWindowcs
    {

        By loginTextBox = By.Name("loginemail");
        By passwordTextBox = By.Name("haslo");
        By loginButton = By.XPath("/html/body/div[3]/div/section/div[2]/div/form/fieldset/p[1]/button");
        By messageAfterLogon = By.CssSelector("#page-title > h1");
        By searchBook = By.Id("inputSearch");
        By searchButton = By.CssSelector("#szukanie > fieldset > a > button");
        By getBookToCart = By.CssSelector("#czykov > a > ins");
        By checkDetails = By.ClassName("czykov-link");
        By checkAudioBook = By.CssSelector("body > header > div > div.main-menu-container > nav.main-menu > ul > li:nth-child(4) > a");
        By bestBook = By.CssSelector("#left-big-col > div.book-details > div.title-group > div > ul > li.tag-bestseller.select_druk > a");

        IWebDriver _driver;
        public LoginWindowcs(IWebDriver driver)
        {
            _driver = driver;
        }
        public void LoginToHelion(string login, string password)
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _driver.FindElement(loginTextBox).SendKeys(login);
            _driver.FindElement(passwordTextBox).SendKeys(password);
            WebDriverWait localWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driver.FindElement(loginButton).Click();
            var test = _driver.FindElement(messageAfterLogon).Text;

            Assert.AreEqual("Witaj w Twoim koncie", test);
        }
        public void SearchForBook(string bookName)
        {
            _driver.FindElement(searchBook).SendKeys(bookName);
            _driver.FindElement(searchButton).Click();
        }

        public void GetBookToCard()
        {
            _driver.FindElement(getBookToCart).Click();
        }

        public void CheckBookDetails()
        {
            _driver.FindElement(checkDetails).Click();
        }

        public void CheckAudioBook()
        {
            _driver.FindElement(checkAudioBook).Click();
        }
        
        public void BestsellerBook()
        {
            _driver.FindElement(bestBook).Click();
        }

    }
}
