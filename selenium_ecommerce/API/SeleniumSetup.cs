using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using System.Xml;

namespace selenium_ecommerce
{
    public abstract class SeleniumSetup
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public virtual IWebDriver Driver { get; set; }

        public virtual void SetupSelenium(uint windowSizeX, uint windowSizeY)
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument($"--window-size={windowSizeX},{windowSizeY}");
            Driver = new ChromeDriver(chromeOptions);
        }

        public void SetupLogger()
        {
            XmlDocument log4netConfig = new XmlDocument();

            log4netConfig.Load(File.OpenRead("log4net.config"));
            var repo = log4net.LogManager.CreateRepository(Assembly.GetEntryAssembly(),
                        typeof(log4net.Repository.Hierarchy.Hierarchy));

            log4net.Config.XmlConfigurator.Configure(repo, log4netConfig["log4net"]);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Testing e-commerce shop (https://www.soyalab.pl/) based on WordPress and Woocommerce.");
        }
    }
}
