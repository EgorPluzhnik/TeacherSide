using System.Windows;
using System.Windows.Controls;

namespace vrstud.test.test2
{
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            PageWrap.nav.GoBack();
        }
    }
}