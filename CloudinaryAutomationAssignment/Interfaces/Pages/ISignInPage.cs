using CloudinaryAutomationAssignment.Common;

namespace CloudinaryAutomationAssignment.Interfaces.Pages
{
    public interface ISignInPage
    {
        void PerformSignIn(User user);

        void ValidatePage();
    }
}
