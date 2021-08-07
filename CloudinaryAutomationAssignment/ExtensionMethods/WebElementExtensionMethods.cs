using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;

namespace CloudinaryAutomationAssignment.ExtensionMethods
{
    public static class WebElementExtensionMethods
    {
        public static IWebElement FindElementUntilDisplayed(this ISearchContext context, By by, uint timeout = 30)
        {
            var wait = new DefaultWait<ISearchContext>(context)
            {
                Timeout = TimeSpan.FromSeconds(timeout),
            };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            return wait.Until(ctx =>
                {
                    var elem = ctx.FindElement(by);
                    if (!elem.Displayed)
                    {
                        return null;
                    }
                    return elem;
                });
        }

        public static ReadOnlyCollection<IWebElement> FindElementsUntilDisplayed(this ISearchContext context, By by, uint timeout = 10)
        {
            var wait = new DefaultWait<ISearchContext>(context)
            {
                Timeout = TimeSpan.FromSeconds(timeout),
            };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            return wait.Until(ctx =>
            {
                var elements = ctx.FindElements(by);
                if (elements.Count == 0)
                {
                    return null;
                }
                
                foreach (var element in elements)
                {
                    if (!element.Displayed)
                    {
                        return null;
                    }
                }                    
                
                return elements;
            });
        }

    }
}
