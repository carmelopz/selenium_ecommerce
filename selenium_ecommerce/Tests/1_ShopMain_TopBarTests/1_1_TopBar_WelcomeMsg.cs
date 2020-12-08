using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace selenium_ecommerce.Tests._1_ShopMain_TopBarTests
{
    public class _1_1_TopBar_WelcomeMsg : SoyalabItems
    {
        IWebElement element;

        [SetUp]
        public void StartBrowser()
        {
            Driver = SetupSelenium(windowSizeX: 1200, windowSizeY: 1000);
            Driver.Navigate().GoToUrl(SiteAddress);
        }

        [Test]
        public void Test()
        {
            //using (driver)
            //{

            //}
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //element = Driver.FindElement(By.XPath("//*[@id='menu-item-1202']"));
            element = Driver.FindElement(By.XPath("//*[@id='nm - top - bar']/div/div[1]/div"));
            Console.WriteLine("Partial Link Test Pass");

            //*[@id="nm-top-bar"]/div/div[1]/div
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
