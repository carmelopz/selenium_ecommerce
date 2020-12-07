using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace selenium_ecommerce
{
    class Demo : SoyalabItems
    {
        IWebElement element;

        [SetUp]
        public void StartBrowser()
        {
            Driver = SetUpSelenium();
            Driver.Navigate().GoToUrl(SiteAddress);
        }

        [Test]
        public void Test()
        {
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
