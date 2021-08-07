using OpenQA.Selenium;

namespace CloudinaryAutomationAssignment.Pages
{
    public class BasePage
    {
        protected readonly IWebDriver webDriver;

        public BasePage(IWebDriver driver)
        {
            webDriver = driver;
        }

        public void PerformClick(By bySelctor)
        {
            var element = webDriver.FindElement(bySelctor);
            if (element != null)
            {
                element.Click();
            }
            else
            {
                throw new NoSuchElementException(bySelctor.ToString());
            }
        }
    }
}
