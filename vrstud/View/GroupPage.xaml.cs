using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace vrstud.View
{
    public partial class GroupPage : Page
    {
        public GroupPage()
        {
            InitializeComponent();
            lis.Columns.Add(new GridViewColumn(){DisplayMemberBinding = new Binding("asdas"), Header = "shit"});
        }

        private void AddColumns(GridView gr, string[] columns)
        {
            
        }
    }
}