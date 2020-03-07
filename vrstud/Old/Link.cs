using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace vrstud
{
    internal class Link : Label
    {
        public static readonly DependencyProperty LinkDataProperty;

        static Link()
        {
            LinkDataProperty =
                DependencyProperty.Register("LinkData", typeof(ToDoItem), typeof(Link));
        }

        public ToDoItem LinkData
        {
            set => SetValue(LinkDataProperty, value);
            get => (ToDoItem) GetValue(LinkDataProperty);
        }

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            base.OnMouseDown(e);
//            MessageBox.Show("id: " + this.LinkData.Id + ", name: " + this.LinkData.Title);
        }
    }
}