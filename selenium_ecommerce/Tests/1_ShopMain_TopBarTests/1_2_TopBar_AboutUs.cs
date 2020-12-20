using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace selenium_ecommerce.Tests._1_ShopMain_TopBarTests
{
    public class _1_2_TopBar_AboutUs : SoyalabItems
    {
        IWebElement element;
        const string expectedName = "About Us";
        const string expectedPhoneNumber = "703.172.3412";
        const string expectedEmail = "hello@example.com";

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

            /* Find "AboutUs" item and click on it. */
            element = wait.Until(condition =>
            {
                try
                {
                    var elementFound = condition.FindElement(By.XPath(XPathDct["AboutUs"]));
                    return elementFound;
                }
                catch (NoSuchElementException elementNotFoundExc)
                {
                    log.Error("Can't find 'AboutUs' item.");
                    throw elementNotFoundExc;
                }
            });

            Assert.True(element.Text == expectedName, "'AboutUs' element is not as expected.");

            element.Click();

            /* Find "ContactUs" item and check if phone number and email is as expected. */
            var element2 = wait.Until(condition =>
            {
                try
                {
                    var elementFound = condition.FindElement(By.XPath(XPathDct["ContactUs"]));
                    return elementFound;
                }
                catch (NoSuchElementException elementNotFoundExc)
                {
                    log.Error("Can't find 'ContactUs' item.");
                    throw elementNotFoundExc;
                }
            });

            Assert.True(element2.Text.Contains(expectedPhoneNumber), "'ContactUs - Phone Number' element is not as expected.");
            Assert.True(element2.Text.Contains(expectedEmail), "'ContactUs - Email' element is not as expected.");
        }

        [TearDown]
        public void CloseBrowser()
        {
            Driver.Close();
        }
    }
}
