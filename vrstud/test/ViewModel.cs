using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace vrstud.test
{
    public class ViewModel : ViewModelBase
    {
        public ViewModel(List<ItemToDo> items)
        {
            Items = new ObservableCollection<ItemToDo>(items);
        }

        private ObservableCollection<ItemToDo> Items { get; }


//        private DelegateCommand _removeCommand;
//
//        public DelegateCommand RemoveCommand
//        {
//            get
//            {
//                return _removeCommand ??
//                       (_removeCommand = new DelegateCommand(obj =>
//                           {
//                               var item = obj as ItemToDo;
//                               if (item != null) items.Remove(item);
//                           },
//                           obj => items.Count > 0));
//            }
//        }
//
//        public ToDoItem SelectedItem
//        {
//            get => _selectedItem;
//            set
//            {
//                _selectedItem = value;
//            }
//        }
//
//        public string FirstName
//        {
//            get => _firstName;
//            set => SetProperty(ref _firstName, value);
//        }
//
//        public string GettingText
//        {
//            get => _gettingText;
//            set => SetProperty(ref _gettingText, value);
//        }
//
//        private readonly DelegateCommand _changeNameCommand;
//        public ICommand ChangeNameCommand => _changeNameCommand;
//        
//        private readonly DelegateCommand _selectItem;
//        public ICommand SelectItem => _selectItem;
//        
//        private string _firstName;
//        private string _gettingText;
//        private ToDoItem _selectedItem;
//
//        public ViewModel()
//        {
//            _changeNameCommand = new DelegateCommand(OnChangeName, CanChangeName);
//        }
//
//        private void OnChangeName(object commandParameter)
//        {
//            FirstName = GettingText;
//            _changeNameCommand.InvokeCanExecuteChanged();
//        }
//
//        private bool CanChangeName(object commandParameter) => true;
    }
}