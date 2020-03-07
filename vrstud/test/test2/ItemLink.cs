using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace vrstud.test.test2
{
    public class ItemLink : Label
    {
        public Item LinkData { get; set; }

        protected override void OnMouseDown(MouseButtonEventArgs mouseButtonEventArgs)
        {
            MessageBox.Show(LinkData.Id, LinkData.Title);
        }
    }
}