using System.Windows.Controls;

namespace vrstud.View
{
    public partial class CommonPage : Page
    {
        private CommonPViewModel ViewModel = new CommonPViewModel();
        public CommonPage()
        {
            DataContext = ViewModel;
            InitializeComponent();
            GroupsList.ItemsSource = ViewModel.Groups;
            StudentsList.ItemsSource = ViewModel.Students;
        }
    }
}