using CloudinaryAutomationAssignment.ExtensionMethods;
using CloudinaryAutomationAssignment.Interfaces.Pages;
using OpenQA.Selenium;

namespace CloudinaryAutomationAssignment.Pages
{
    public class AssetsActionPopUpPage : BasePage, IAssetsActionPopUpPage
    {
        protected By PopoverList => By.XPath("//div[@data-test='popover']");

        protected By Manage => By.XPath("//div[@data-test='action-manage-btn']");

        protected By Transform => By.XPath("//div[@data-test='action-transform-btn']");

        protected By Analyze => By.XPath("//div[@data-test='action-analyze-btn']");

        protected By Copy => By.XPath("//div[@data-test='action-copy-btn']");

        protected By Download => By.XPath("//div[@data-test='action-download-btn']");

        protected By AddToCollection => By.XPath("//div[@data-test='action-addToCollection-btn']");

        protected By Delete => By.XPath("//div[@data-test='action-delete-btn']");


        public AssetsActionPopUpPage(IWebDriver driver) : base(driver)
        { }

        public void ValidatePage()
        {
            var element = webDriver.FindElementUntilDisplayed(PopoverList);
            if (element == null)
            {
                throw new NoSuchElementException(PopoverList.ToString());
            }
        }       
        

        public void PerformManage()
        {
            PerformClick(Manage);
        }

        public void PerformTransform()
        {
            PerformClick(Transform);
        }

        public void PerformAnalyze()
        {
            PerformClick(Analyze);
        }

        public void PerformCopy()
        {
            PerformClick(Copy);
        }

        public void PerformDownload()
        {
            PerformClick(Download);
        }

        public void PerformAddToCollection()
        {
            PerformClick(AddToCollection);
        }

        public void PerformDelete()
        {
            PerformClick(Delete);
        }

    }
}
