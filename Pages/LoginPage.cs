using OpenQA.Selenium;
using seleniumTest.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumTest.Pages
{
    public class LoginPage:BasePage
    {
        public LoginPage(IWebDriver driver):base(driver)
        {
            //base.BasePage(driver);
        }

    }
}
