using CloudinaryAutomationAssignment.ExtensionMethods;
using CloudinaryAutomationAssignment.Interfaces.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Linq;

namespace CloudinaryAutomationAssignment.Pages
{
    public class MediaLibraryPage : BasePage, IMediaLibraryPage
    {
        protected By MediaLibraryGrid => By.XPath("//div[contains(@class,'MediaLibrary')]");

        protected By Assets => By.XPath("//div[@data-test='asset-info-text']");

        

        public MediaLibraryPage(IWebDriver driver) : base(driver)
        { }

        public void ValidatePage()
        {
            var mediaLibraryGridElements = webDriver.FindElementUntilDisplayed(MediaLibraryGrid);

            if (mediaLibraryGridElements == null)
            {
                throw new NoSuchElementException(mediaLibraryGridElements.ToString());
            }

        }
        public void SelectAsset(string assetName) 
        {
            var assetsElements = webDriver.FindElementsUntilDisplayed(Assets,30);
          
            var chosenAsset = assetsElements.FirstOrDefault(x => x.Text.Equals(assetName));

            var actions = new Actions(webDriver);
            actions.ContextClick(chosenAsset).Perform();
        }
        
    }
}
