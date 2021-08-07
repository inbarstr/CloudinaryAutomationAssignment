using CloudinaryAutomationAssignment.ExtensionMethods;
using CloudinaryAutomationAssignment.Interfaces.Pages;
using OpenQA.Selenium;

namespace CloudinaryAutomationAssignment.Pages
{
    public class ManagingAssetPage : BasePage, IManagingAssetPage
    {
        protected string AssetName;

        protected By TopBar => By.XPath("//div[@data-test='manage-top-bar']");

        public ManagingAssetPage(IWebDriver driver, string assetName) : base(driver)
        {
            AssetName = assetName;
        }

        public void ValidatePage()
        {
            var element = webDriver.FindElementUntilDisplayed(TopBar);
            if (element == null)
            {
                throw new NoSuchElementException(TopBar.ToString());
            }

            var xpathStringForAsset = $"//div[@data-test='manage-top-bar']//input[contains(@value,'{AssetName}')]";

            element = element.FindElementUntilDisplayed(By.XPath(xpathStringForAsset));
            if (element == null)
            {
                throw new NoSuchElementException(xpathStringForAsset);
            }
        }
       
    }
}
