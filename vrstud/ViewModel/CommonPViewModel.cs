using System.Collections.ObjectModel;
using System.Windows.Input;
using vrstud.View;

namespace vrstud
{
    public class CommonPViewModel : ViewModelBase
    {
        private Group _selectedGroup;

        //public CommonPViewModel()
        //{
        //    Groups = new ObservableCollection<Group>(new Groups().GroupsData);
        //    Students = new ObservableCollection<Student>(new Students().StudentsData);
        //    Account = new AccountDescription();
        //    _openGroup = new DelegateCommand(openGroupPage, canOpeningGroup);
        //}

        public ObservableCollection<Group> Groups { get; set; }
        public ObservableCollection<Student> Students { get; set; }
        public AccountDescription Account { get; set; }

        private readonly DelegateCommand _openGroup;

        public DelegateCommand OpenGroup => _openGroup;

        //private void openGroupPage(object commandParameter)
        //{
        //    Navigator.nav.Navigate(new GroupPage());
        //}

        private bool canOpeningGroup(object commandParameter) => true;

        public Group SelectedGroup
        {
            get => _selectedGroup;
            set => SetProperty(ref _selectedGroup, value);
        }
    }
}