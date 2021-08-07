using CloudinaryAutomationAssignment.Enums;
using CloudinaryAutomationAssignment.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CloudinaryAutomationAssignment.Tests
{
    [TestClass]
    public class MediaLibraryTests: BaseTest
    {
        public MediaLibraryTests() : base()
        {}

        [TestMethod]
        [DataRow(BrowserType.Chrome)]
        public void MediaLibrary_Assets_ChooseSpecificAssetSuccessfully(BrowserType browserType)
        {
            OpenBrowser(browserType);

            var signInPage = PagesFactory.GetSignInPage(webDriver);
            signInPage.PerformSignIn(configData.User);

            var homePage = PagesFactory.GetHomePage(webDriver);
            homePage.GoToMediaLibrary();

            var mediaLibraryPage = PagesFactory.GetMediaLibraryPage(webDriver);
            mediaLibraryPage.SelectAsset("home assignment");

            var assetsActionPopUpPage = PagesFactory.GetAssetsActionPopUpPage(webDriver);
            assetsActionPopUpPage.PerformManage();

            var managingAssetPage = PagesFactory.GetManagingAssetPage(webDriver, "home assignment");
        }
    }
}
