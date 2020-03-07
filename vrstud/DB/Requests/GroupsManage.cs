using System;
using System.Collections.Generic;

namespace vrstud.DB
{
    public class GroupsManage
    {
        public GroupsManage(string teacherLogin = null)
        {
            if (teacherLogin is null)
                return;

            #region ChangeItWithDBRequests

            Groups = new List<Group>
            {
                new Group {Id = 0, Title = "РИ-280012"},
                new Group {Id = 1, Title = "РИ-280013"},
                new Group {Id = 2, Title = "РИ-280014"}
            };

            #endregion
        }

        public List<Group> Groups { get; private set; }
    }

    public class T
    {
        // realize how data will get from DB
    }
}