using System.Windows;

namespace vrstud
{
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            var Form = new MainWindowLoggined();
            Form.Show();
        }
    }
}