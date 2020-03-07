using vrstud.View;

namespace vrstud
{
    public class StartViewModel : ViewModelBase
    {
        public StartViewModel()
        {
            ShowLoginForm = new DelegateCommand(showLoginForm, canShowLoginForm);
        }

        public DelegateCommand ShowLoginForm { get; }

        private void showLoginForm(object commandParameter)
        {
            Navigator.nav.Navigate(new LoginPage());
        }

        private bool canShowLoginForm(object commandParameter)
        {
            return true;
        }
    }
}