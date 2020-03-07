using System.Collections.Generic;
using System.Linq;
using vrstud.DB;

namespace vrstud
{
    public class Groups
    {
        public Groups()
        {
            var GrpManager = new GroupsManage(AccountModerator.NameAccount);
            GroupsData = GrpManager.Groups;
        }

        public List<Group> GroupsData { get; }

        public List<string> GetTitlesOnly()
        {
            return GroupsData.Select(group => group.Title).ToList();
        }
    }
}