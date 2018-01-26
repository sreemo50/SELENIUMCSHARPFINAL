using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using LinqToExcel;
using seleniumTest.DataExcel;

namespace seleniumTest.Common
{
    public abstract class BaseTest
    {
        public static IEnumerable<string> getThebrowsers()
        {
            string[] browsers = { "Chrome" };
            //string[] browsers = { "Chrome", "firefox", "IE", "Safari" };

            foreach (string b in browsers)
            {
                yield return b;
            }

        }

        public static IEnumerable<string> getCredentials()
        {

            var excel = new ExcelQueryFactory(@"F:\projects\seleniumTest\seleniumTest\DataExcel\TestingDetails.xlsx");
            //excel.UsePersistentConnection = true;
            var testcasedetails = from c in excel.Worksheet<TestCaseData>("TestD") where c.TestCaseKey == "Login" select c;
            return null;

        }


        protected IWebDriver seleniumDriver;
        private readonly string url;
        private PageData pgData;

        //private AppiumDriver<AndroidElement> _androidDriver;
        //private AppiumDriver<IOSElement> _iosElements;
        public void Setup(string browserType)
        {

            if(browserType.Equals("IE"))
            {
                //create driver for Internet Explorer

                seleniumDriver = new InternetExplorerDriver(@"");

            }
            else if (browserType.Equals("firefox"))
            {
                //create driver for Internet Explorer
                seleniumDriver = new FirefoxDriver();

            }
            else if (browserType.Equals("Chrome"))
            {
                //create driver for Internet Explorer
                seleniumDriver = new ChromeDriver(@"F:\supportsoftware");
                seleniumDriver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["url"]);

            }
            else if (browserType.Equals("Safari"))
            {
                //create driver for Internet Explorer
            }
            else
            { //not a correct driver
                Console.WriteLine("no drivers created");
            }

            pgData = new PageData(seleniumDriver);
        }

        /*
        public void MobileSetup(string browserType)
        {

            if (browserType.Equals("IE"))
            {
                //create driver for Internet Explorer

                _androidDriver = new AppiumDriver<AndroidElement>();

            }
            else if (browserType.Equals("firefox"))
            {
                //create driver for Internet Explorer
                seleniumDriver = new FirefoxDriver();

            }
            else if (browserType.Equals("Chrome"))
            {
                //create driver for Internet Explorer
                seleniumDriver = new ChromeDriver();

            }
            else if (browserType.Equals("Safari"))
            {
                //create driver for Internet Explorer
            }
            else
            { //not a correct driver
                Console.WriteLine("no drivers created");
            }
        }

    */
        public void ShutDownTheDriver()
        {
            seleniumDriver.Quit();
        }
    }
}
