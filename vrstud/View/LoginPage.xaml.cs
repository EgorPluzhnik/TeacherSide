using System;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace vrstud.View
{
    public partial class LoginPage : Page
    {
        private readonly LoginViewModel ViewModel = new LoginViewModel();

        public LoginPage()
        {
            DataContext = ViewModel;
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var connectionStirng = "";
            #region
            //using (SqlConnection connection = new SqlConnection(connectionStirng))
            //{
            //    var query = "SELECT COUNT(1) FROM table WHERE userName=@UserName AND password=@PASSWORD";
            //    var command = new SqlCommand(query, connection);
            //    command.CommandType = System.Data.CommandType.Text;
            //    command.Parameters.AddWithValue("@UserName", UserName.Text);
            //    command.Parameters.AddWithValue("@Password", Password.Password);
            //    if (Convert.ToInt32(command.ExecuteScalar()) == 1)
            //    {
            //        NavigationService.Navigate(new Uri("/CommonPage.xaml", UriKind.Relative));
            //    }

            //}
            #endregion
            if (UserName.Text == "test" && Password.Password == "test")
            {
                NavigationService.Navigate(new Uri("/CommonPage.xaml", UriKind.Relative));

            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Error);
            }         
        }
    }
}