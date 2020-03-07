using System;
using System.Windows;
using System.Windows.Input;
using vrstud.View;

namespace vrstud
{
    public class LoginViewModel : ViewModelBase
    {
        private readonly DelegateCommand _logIn;
        private string _loginName;
        private string _password;

        public LoginViewModel()
        {
            _logIn = new DelegateCommand(signUp, canSignUp);
        }

        public string LoginName
        {
            get => _loginName;
            set => SetProperty(ref _loginName, value);
        }

        public string Password //Do it crypto!!!
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public ICommand LogIn => _logIn;

        private void signUp(object commandParameter)
        {
            try
            {
                AccountModerator.Authorize(LoginName, Password);
            }
            catch (AuthoriseException e)
            {
                //MessageBox.Show("Неправильный логин или пароль", "LoginError", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Navigator.CleanAllBackPages();
            Navigator.nav.Navigate(new CommonPage());
        }

        private bool canSignUp(object commandParameter)
        {
            return true;
        }
    }
}