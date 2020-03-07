using System.Collections.Generic;
using System.Windows;

namespace vrstud
{
    public partial class StudentsOld : Window
    {
        public StudentsOld()
        {
            InitializeComponent();
            var marks = new List<ItemStudentsMarks>();
            marks.Add(new ItemStudentsMarks(1, "Багиров А. М.", 5, 3, 2));
            marks.Add(new ItemStudentsMarks(2, "Власов С. В.", 2, 3, 5));
            marks.Add(new ItemStudentsMarks(2, "Смирноф Т. Г.", 5, 5, 5));
            CatalogDataGrid.ItemsSource = marks;
        }
    }
}