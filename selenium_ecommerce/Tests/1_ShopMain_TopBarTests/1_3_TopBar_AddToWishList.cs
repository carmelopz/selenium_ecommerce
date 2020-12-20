using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace selenium_ecommerce.Tests._1_ShopMain_TopBarTests
{
    public class _1_3_TopBar_AddToWishList : SoyalabItems
    {
        IWebElement element;
        const string expectedName = "Wishlist";
        const string wishlistItemExpectedName = "Pendant Lamp";

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

            /* Find "AddToWishlist" item next to the product, and click on it. This action will add this product to wishlist. */
            element = wait.Until(condition =>
            {
                try
                {
                    var elementFound = condition.FindElement(By.XPath(XPathDct["AddToWishlistItem"]));
                    return elementFound;
                }
                catch (NoSuchElementException elementNotFoundExc)
                {
                    log.Error("Can't find 'AddToWishList' item.");
                    throw elementNotFoundExc;
                }
            });

            element.Click();

            /* Find "Wishlist" item at the top bar, and click on it. */
            var element2 = wait.Until(condition =>
            {
                try
                {
                    var elementFound = condition.FindElement(By.XPath(XPathDct["Wishlist"]));
                    return elementFound;
                }
                catch (NoSuchElementException elementNotFoundExc)
                {
                    log.Error("Can't find 'Wishlist' item.");
                    throw elementNotFoundExc;
                }
            });

            Assert.True(element2.Text == expectedName, "'Wishlist' element is not as expected.");

            element2.Click();

            /* Check if item previously added to wishlist is present on wishlist. */
            var element3 = wait.Until(condition =>
            {
                try
                {
                    var elementFound = condition.FindElement(By.XPath(XPathDct["PendantLampAtWishlist"]));
                    return elementFound;
                }
                catch (NoSuchElementException elementNotFoundExc)
                {
                    log.Error("Can't find item previously added to wishlist.");
                    throw elementNotFoundExc;
                }
            });

            Assert.True(element3.Text == wishlistItemExpectedName, "Element at wishlist is not as expected.");
        }

        [TearDown]
        public void CloseBrowser()
        {
            Driver.Close();
        }
    }
}
