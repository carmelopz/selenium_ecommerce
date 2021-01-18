using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace selenium_ecommerce.Tests._2_ShopMain_HeaderRightMenuTests
{
    public class _2_1_HeaderRightMenu_Account : SoyalabItems
    {
        IWebElement element;

        [SetUp]
        public void StartBrowser()
        {
            SetupLogger();
            SetupSelenium(windowSizeX: 1500, windowSizeY: 1000);
            Driver.Navigate().GoToUrl(SiteAddress);
        }

        [Test]
        public void Test()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));

            /* Find "AccountLoginButton", and click on it. This action will open login popup. */
            element = wait.Until(condition =>
            {
                try
                {
                    var elementFound = condition.FindElement(By.XPath(XPathDct["AccountLoginButton"]));
                    return elementFound;
                }
                catch (NoSuchElementException elementNotFoundExc)
                {
                    log.Error("Can't find 'Zaloguj sie' item.");
                    throw elementNotFoundExc;
                }
            });

            element.Click();

            /* Find "LoginPopupUserName", and enter user name. */
            element = wait.Until(condition =>
            {
                try
                {
                    var elementFound = condition.FindElement(By.XPath(XPathDct["LoginPopupUserName"]));
                    return elementFound;
                }
                catch (NoSuchElementException elementNotFoundExc)
                {
                    log.Error("Can't find 'username' item.");
                    throw elementNotFoundExc;
                }
            });

            element.SendKeys(UserTestName);

            /* Find "LoginPopupUserPassword", and enter user password. */
            element = wait.Until(condition =>
            {
                try
                {
                    var elementFound = condition.FindElement(By.XPath(XPathDct["LoginPopupUserPassword"]));
                    return elementFound;
                }
                catch (NoSuchElementException elementNotFoundExc)
                {
                    log.Error("Can't find 'password' item.");
                    throw elementNotFoundExc;
                }
            });

            element.SendKeys(UserTestPassword);

            /* Find "LoginPopupLoginButton", and click on it. This action will log user and open account subpage. */
            element = wait.Until(condition =>
            {
                try
                {
                    var elementFound = condition.FindElement(By.XPath(XPathDct["LoginPopupLoginButton"]));
                    return elementFound;
                }
                catch (NoSuchElementException elementNotFoundExc)
                {
                    log.Error("Can't find 'Zaloguj sie button' item.");
                    throw elementNotFoundExc;
                }
            });

            element.Click();

            /* Check by url if the appropriate page is displayed after logging in. */
            Assert.AreEqual("https://www.soyalab.pl/my-account-2/", Driver.Url);
        }

        [TearDown]
        public void CloseBrowser()
        {
            Driver.Close();
        }
    }
}
