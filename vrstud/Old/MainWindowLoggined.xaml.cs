using System.Collections.Generic;
using System.Windows;

namespace vrstud
{
    public partial class MainWindowLoggined : Window
    {
        public MainWindowLoggined()
        {
            InitializeComponent();
            GroupsList.ItemsSource = CreateGroups();
            StudentsList.ItemsSource = CreateStudents();
        }

        public int CountGroups { get; set; } = 3;

        private List<ToDoItem> CreateGroups()
        {
            var groups = new List<ToDoItem>();
            var dataGroups = GetGroupsData();
            for (var i = 0; i < CountGroups; i++) groups.Add(new ToDoItem {Title = dataGroups[i]});

            return groups;
        }

        private static string[] GetGroupsData()
        {
            return new[] {"РИ-280012", "РИ-280013", "РИ-280014"};
        }

        private List<ToDoItem> CreateStudents()
        {
            var groups = new List<ToDoItem>();
            var dataGroups = GetStudentsData();
            for (var i = 0; i < CountGroups; i++) groups.Add(new ToDoItem {Title = dataGroups[i]});

            return groups;
        }

        private static string[] GetStudentsData()
        {
            return new[] {"Корабельников А. С.", "Плужник Е. А.", "Семенченко А. В."};
        }

        private void ShowChangeGroup(object sender, RoutedEventArgs e)
        {
            var form = new StudentsOld();
            form.Show();
        }
    }
}