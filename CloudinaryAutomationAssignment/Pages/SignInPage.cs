using CloudinaryAutomationAssignment.Common;
using CloudinaryAutomationAssignment.ExtensionMethods;
using CloudinaryAutomationAssignment.Interfaces.Pages;
using OpenQA.Selenium;

namespace CloudinaryAutomationAssignment.Pages
{
    public class SignInPage : BasePage, ISignInPage
    {
        protected By EmailAddress => By.Id("user_session_email");

        protected By Password => By.Id("user_session_password");

        protected By SignInButton => By.Id("sign-in");

        protected By NewUserSession => By.Id("new_user_session");
        
        

        public SignInPage(IWebDriver driver) : base(driver)
        { }                

        public void ValidatePage()
        {
            var newUserSessionElement = webDriver.FindElementUntilDisplayed(NewUserSession);
            
            if (newUserSessionElement == null)
            {
                throw new NoSuchElementException(NewUserSession.ToString());
            }
            
        }

        public void PerformSignIn(User user)
        {
            var element = webDriver.FindElement(EmailAddress);
            element.SendKeys(user.UserName);

            element = webDriver.FindElement(Password);
            element.SendKeys(user.Password);

            PerformClick(SignInButton);
        }
    }
}
