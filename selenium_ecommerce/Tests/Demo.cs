using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using log4net;
using System.Reflection;
using System.Xml;
using System.IO;

namespace selenium_ecommerce
{
    class Demo : SoyalabItems
    {
        IWebElement element;

        [SetUp]
        public void StartBrowser()
        {
            SetupLogger();
            Driver = SetupSelenium(windowSizeX: 800, windowSizeY: 600);
        }

        [Test]
        public void Test()
        {
            Driver.Navigate().GoToUrl(SiteAddress);

            log.Info("Witaj świecie z log4net!");

            //using (driver)
            //{

            //}
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            element = Driver.FindElement(By.XPath("//*[@id='menu-item-1202']"));
            //driver.FindElement(By.XPath("//input[starts-with(@placeholder,'Fu')]")).SendKeys("Using start with");
            //driver.findElement(By.xpath("//form[@id='userForm']/child::div[1]//label")).getText();
            element.Click();

            //driver.FindElement(By.Name("q")).SendKeys("just testing" + Keys.Enter);
        }

        [TearDown]
        public void CloseBrowser()
        {
            //driver.Close();
        }
    }
}
