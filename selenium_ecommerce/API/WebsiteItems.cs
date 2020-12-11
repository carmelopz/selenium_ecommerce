using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace selenium_ecommerce
{
    public abstract class SoyalabItems : SeleniumSetup
    {
        public string SiteAddress = "https://www.soyalab.pl";

        public Dictionary<string, string> XPath = new Dictionary<string, string>()
        {
            {"nm-top-bar-text", "//div[contains(@class, 'nm-top-bar-text')]"}
        };
    }
}
