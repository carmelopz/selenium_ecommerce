using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace selenium_ecommerce.Tests._1_ShopMain_TopBarTests
{
    public class _1_1_TopBar_WelcomeMsg : SoyalabItems
    {
        IWebElement element;
        const string expectedText = "W Soyalab zajmujemy się ręcznym tworzeniem świec sojowych. Startujemy już niedługo!";

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

            //element = wait.Until(condition => condition.FindElement(By.XPath("//div[contains(@class, 'nm-top-bar-text')]")));
            //element = Driver.FindElement(By.XPath("//div[contains(@class, 'nm-top-bar-text')]"));

            element = wait.Until(condition =>
            {
                try
                {
                    var elementFound = condition.FindElement(By.XPath(XPath["nm-top-bar-text"]));
                    return elementFound;
                }
                catch (NoSuchElementException elementNotFoundExc)
                {
                    log.Error("Can't find 'nm-top-bar-text' item.");
                    throw elementNotFoundExc;
                }
            });

            Assert.AreEqual(element.Text, expectedText, "'nm-top-bar-text' element is not as expected.");
        }

        [TearDown]
        public void CloseBrowser()
        {
            Driver.Close();
        }
    }
}
