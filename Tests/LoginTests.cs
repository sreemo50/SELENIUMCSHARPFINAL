using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using seleniumTest.Common;
using seleniumTest.Pages;

namespace seleniumTest.Tests
{
    [TestFixture]
    [Parallelizable]
    public class LoginTests:BaseTest
    {

        private HomePage Hp;
        

        [Test]
        [TestCaseSource(typeof(BaseTest),"getThebrowsers")]
        public void LoginTest(string browser)
        {
            Setup(browser);
            Hp = new HomePage(seleniumDriver);

           //seleniumDriver;
        }

        [Test]
        [TestCaseSource(typeof(BaseTest), "getCredentials")]
        public void LoginToSite(String username,string passcode,string browser)
        {
            Setup(browser);

        }
    }
}
