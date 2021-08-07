using CloudinaryAutomationAssignment.ExtensionMethods;
using CloudinaryAutomationAssignment.Interfaces.Pages;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace CloudinaryAutomationAssignment.Pages
{
    public class HomePage : BasePage, IHomePage
    {
        protected By MainBanner => By.ClassName("cld-main-bar");
        
        protected By Menues => By.XPath("//nav/ul/li/b[@data-balloon]");
                
        protected By Dashboard => By.XPath("//b[@data-balloon='Dashboard']");

        protected By MediaLibrary => By.XPath("//b[@data-balloon='Media Library']");

        protected By Transformations => By.XPath("//b[@data-balloon='Transformations']");

        protected By Reports => By.XPath("//b[@data-balloon='Reports']");

        protected By AddOns => By.XPath("//b[@data-balloon='Add-ons']");


        public HomePage(IWebDriver driver) : base(driver)
        { }

        public void ValidatePage()
        {
            ValidateMainBanner();
            ValidateMainBannerMenus();
        }

        private void ValidateMainBanner()
        {
            var element = webDriver.FindElementUntilDisplayed(MainBanner);
            if (element == null)
            {
                throw new NoSuchElementException(MainBanner.ToString());
            }
        }

        private void ValidateMainBannerMenus()
        {
            var elements = new List<IWebElement>
            {
                webDriver.FindElementUntilDisplayed(Dashboard),
                webDriver.FindElementUntilDisplayed(MediaLibrary),
                webDriver.FindElementUntilDisplayed(Transformations),
                webDriver.FindElementUntilDisplayed(Reports),
                webDriver.FindElementUntilDisplayed(AddOns)
            };
            foreach (var element in elements)
            {
                if (element == null)
                {
                    throw new NoSuchElementException(element.ToString());
                }
            }
        }

        public void GoToMediaLibrary()
        {
            PerformClick(MediaLibrary);
        }

    }
}
