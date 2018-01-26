using OpenQA.Selenium;
using seleniumTest.Pages;

namespace seleniumTest.Common
{
    internal class PageData
    {
        private IWebDriver seleniumDriver;

        public PageData(IWebDriver seleniumDriver)
        {
            this.seleniumDriver = seleniumDriver;
        }

        public HomePage HomeScreen()
        {
            return new HomePage(seleniumDriver);

        }


        public LoginPage LoginScreen()
        {
            return new LoginPage(seleniumDriver);
        }
    }
}