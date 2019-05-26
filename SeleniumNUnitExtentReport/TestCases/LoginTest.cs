using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumNUnitExtentReport.Config;
using SeleniumNUnitExtentReport.PageMethods;

namespace SeleniumNUnitExtentReport.TestCases
{
    [TestFixture]
    public class LoginTest : ReportsGenerationClass
    {
        LoginPage loginPage;

        [Test]
        [Category("Login")]
        public void test_validLogin()
        {
            loginPage = new LoginPage(GetDriver());
            loginPage.goToPage();
            loginPage.goToToggleMenu();
            loginPage.goToLoginMenu();
            loginPage.enterUserName("John Doe");
            loginPage.enterPassword("ThisIsNotAPassword");
            loginPage.clickLoginBtn();
            Assert.IsTrue(loginPage.verifyDashboard());
            loginPage.closeBrowser();
        }

        [Test]
        [Category("Login")]
        public void test_invalidLogin()
        {
            loginPage = new LoginPage(GetDriver());
            loginPage.goToPage();
            loginPage.goToToggleMenu();
            loginPage.goToLoginMenu();
            loginPage.enterUserName("John Doe");
            loginPage.enterPassword("ThisIsNotA");
            loginPage.clickLoginBtn();
            Assert.IsTrue(loginPage.verifyDashboard());
            loginPage.closeBrowser();
        }
    }
}
