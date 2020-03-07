using System.Windows.Controls;
using System.Windows.Input;

namespace vrstud.test
{
    public class ItemLink : Label
    {
        public ItemToDo LinkData { get; set; }

        protected override void OnMouseDown(MouseButtonEventArgs mouseButtonEventArgs)
        {
        }
    }
}