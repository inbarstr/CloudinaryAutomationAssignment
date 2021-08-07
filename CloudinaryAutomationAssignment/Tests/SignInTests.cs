using CloudinaryAutomationAssignment.Enums;
using CloudinaryAutomationAssignment.Pages;
using CloudinaryAutomationAssignment.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CloudinaryAutomationAssignment.Test
{
    [TestClass]
    public class SignInTests: BaseTest
    {
        public SignInTests() : base()
        {}

        [TestMethod]
        [DataRow(BrowserType.Chrome)]
        public void SignInSuccessfully(BrowserType browserType)
        {
            OpenBrowser(browserType);

            var signInPage = PagesFactory.GetSignInPage(webDriver);
            signInPage.PerformSignIn(configData.User);

            var homePage = PagesFactory.GetHomePage(webDriver);
        }

    }
}
