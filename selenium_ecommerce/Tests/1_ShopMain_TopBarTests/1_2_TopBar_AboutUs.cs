using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace selenium_ecommerce.Tests._1_ShopMain_TopBarTests
{
    public class _1_2_TopBar_AboutUs : SoyalabItems
    {
        IWebElement element;
        const string expectedName = "About Us";

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
                    var elementFound = condition.FindElement(By.XPath(XPath["AboutUs"]));
                    return elementFound;
                }
                catch (NoSuchElementException elementNotFoundExc)
                {
                    log.Error("Can't find 'AboutUs' item."); //TODO
                    throw elementNotFoundExc;
                }
            });

            Assert.True(element.Text == expectedName, "'AboutUs' element is not as expected.");

            element.Click();

            var element2 = Driver.FindElement(By.XPath("//*[contains(text(),'Telephone')]"));
            log.Info(element2.Text);


            //if (element.Text == expectedName)
            //{
            //    log.Info("'AboutUs' element is as expected.");

            //    element.Click();

            //    var element2 = Driver.FindElement(By.XPath("//*[contains(text(),'Telephone')]"));
            //    log.Info(element2.Text);

            //}
            //else
            //{
            //    Assert.Fail("'AboutUs' element is not as expected.");
            //}



            //if (element.Text == expectedName)
            //{
            //    Assert.Pass("'AboutUs' element is as expected.");
            //    log.Info(element.Text);

            //}
            //else
            //{
            //    Assert.Fail("'AboutUs' element is not as expected.");
            //}

        }
    }
}
