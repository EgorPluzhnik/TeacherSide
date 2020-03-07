using System.Collections.Generic;
using System.Windows;

namespace vrstud.test
{
    public partial class Window1 : Window
    {
//        private ViewModel viewModel = new ViewModel {FirstName = "Max"};
        private readonly ViewModel viewModel = new ViewModel(getItems());

        public Window1()
        {
            DataContext = viewModel;
            InitializeComponent();
        }

        private static List<ItemToDo> getItems()
        {
            return new List<ItemToDo>
            {
                new ItemToDo {Id = "1", NameSth = "Duck"},
                new ItemToDo {Id = "2", NameSth = "Goose"},
                new ItemToDo {Id = "3", NameSth = "Dove"}
            };
        }
    }
}