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
    class Demo
    {
        //just testing github
        IWebDriver driver;
        //IWebElement element;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test()
        {
            using (driver)
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                driver.Navigate().GoToUrl("https://www.google.pl");
                driver.FindElement(By.Name("q")).SendKeys("just testing" + Keys.Enter);
            }
        }

        [TearDown]
        public void CloseBrowser()
        {
            //driver.Close();
        }
    }
}
