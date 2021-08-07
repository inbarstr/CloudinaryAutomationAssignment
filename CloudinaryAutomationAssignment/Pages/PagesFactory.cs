using CloudinaryAutomationAssignment.Interfaces.Pages;
using OpenQA.Selenium;

namespace CloudinaryAutomationAssignment.Pages
{
    public class PagesFactory
    {
        public static ISignInPage GetSignInPage(IWebDriver webDriver)
        {
            var signInPage = new SignInPage(webDriver);
            signInPage.ValidatePage();
            return signInPage;
        }

        public static IHomePage GetHomePage(IWebDriver webDriver)
        {
            var homePage = new HomePage(webDriver);
            homePage.ValidatePage();
            return homePage;
        }

        public static IMediaLibraryPage GetMediaLibraryPage(IWebDriver webDriver)
        {
            var mediaLibraryPage = new MediaLibraryPage(webDriver);
            mediaLibraryPage.ValidatePage();
            return mediaLibraryPage;
        }

        public static IAssetsActionPopUpPage GetAssetsActionPopUpPage(IWebDriver webDriver)
        {
            var assetsActionPopUpPage = new AssetsActionPopUpPage(webDriver);
            assetsActionPopUpPage.ValidatePage();
            return assetsActionPopUpPage;
        }

        public static IManagingAssetPage GetManagingAssetPage(IWebDriver webDriver, string assetName)
        {
            var managingAssetPage = new ManagingAssetPage(webDriver, assetName);
            managingAssetPage.ValidatePage();
            return managingAssetPage;
        }

        
    }
}
