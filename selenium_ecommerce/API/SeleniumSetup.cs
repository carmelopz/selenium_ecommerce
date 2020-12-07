using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace selenium_ecommerce
{
    public abstract class SeleniumSetup
    {
        public virtual IWebDriver Driver { get; set; }

        public virtual IWebDriver SetUpSelenium()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--window-size=1500,1000");
            Driver = new ChromeDriver(chromeOptions);

            return Driver;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Testing e-commerce shop (https://www.soyalab.pl/) based on WordPress and Woocommerce.");
        }
    }
}
