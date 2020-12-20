using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace selenium_ecommerce
{
    public abstract class SoyalabItems : SeleniumSetup
    {
        public string SiteAddress = "https://www.soyalab.pl";

        public Dictionary<string, string> XPathDct = new Dictionary<string, string>()
        {
            /* TopBar tests related items. */
            {"TopBarText", "//div[contains(@class, 'nm-top-bar-text')]"},
            {"AboutUs",    "//li[@id='menu-item-1174']"},
            {"ContactUs",  "//*[contains(text(),'Telephone')]"},
            {"AddToWishlistItem", "//a[@id='nm-wishlist-item-252-button']" },
            {"Wishlist", "//li[@id='menu-item-1175']" },
            {"PendantLampAtWishlist", "//*[contains(text(),'Pendant Lamp')]" }
        };
    }
}
