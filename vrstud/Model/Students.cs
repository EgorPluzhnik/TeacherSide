using System.Collections.Generic;
using System.Linq;
using vrstud.DB;

namespace vrstud
{
    public class Students
    {
        public List<Student> StudentsData { get; private set; }

        public Students()
        {
            StudentsData = new StudentsManage(0, AccountModerator.NameAccount).Students;
        }

        public List<string> GetTitlesOnly()
        {
            return StudentsData.Select(student => student.GetAbbrNameInStart()).ToList();
        }
    }
}