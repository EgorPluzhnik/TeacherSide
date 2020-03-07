using System;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace vrstud.View
{
    public partial class StartPage : Page
    {
        private readonly StartViewModel ViewModel = new StartViewModel();

        public StartPage()
        {
            DataContext = ViewModel;
            InitializeComponent();
            Loaded += pageInitialized;
        }

        private void pageInitialized(object sender, EventArgs e)
        {
            Navigator.nav = NavigationService.GetNavigationService(this);
            ShowsNavigationUI = false;
        }
    }
}