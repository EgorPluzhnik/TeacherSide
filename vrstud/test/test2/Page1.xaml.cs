using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace vrstud.test.test2
{
    public partial class Page1 : Page
    {
        private readonly ObservableCollection<Item> items;
        private Item _selectedItem;

        private NavigationService nav;

//        private NavigationService nav;
        public Page1()
        {
            InitializeComponent();
            PageWrap.Pages.Push(this);
            Loaded += page_Initialized;
            items = new ObservableCollection<Item>
            {
                new Item {Id = "1", Title = "sth"},
                new Item {Id = "2", Title = "smb"},
                new Item {Id = "3", Title = "smw"}
            };
            SthList.ItemsSource = items;
        }

        private void page_Initialized(object sender, EventArgs e)
        {
            PageWrap.nav = NavigationService.GetNavigationService(this);
            ShowsNavigationUI = false;
            KeepAlive = true;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var p = new Page2();
            PageWrap.Pages.Push(p);

            PageWrap.nav.Navigate(p);
        }

        private void Cngh(object sender, SelectionChangedEventArgs e)
        {
            var sth = SthList.SelectedItem;
            MessageBox.Show((sth as Item)?.Id, (sth as Item)?.Title);
        }
    }
}