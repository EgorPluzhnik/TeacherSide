using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace vrstud.test.test2
{
    public partial class Window1 : Window
    {
        private readonly ObservableCollection<Item> items;
        private Item _selectedItem;
        private readonly NavigationService nav;

        public Window1()
        {
            InitializeComponent();
            items = new ObservableCollection<Item>
            {
                new Item {Id = "1", Title = "sth"},
                new Item {Id = "2", Title = "smb"},
                new Item {Id = "3", Title = "smw"}
            };

            nav = NavigationService.GetNavigationService(this);
        }


        private void Cngh(object sender, SelectionChangedEventArgs e)
        {
        }

        private void Btn_OnClick(object sender, RoutedEventArgs e)
        {
            var p = new Page1();
            var w = new Window2();
            nav.Navigate(w);
        }
    }
}