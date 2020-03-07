using System.Collections.Generic;
using System.Linq;

namespace vrstud.DB
{
    public class SheetsManage
    {
        private List<Sheet> Sheets { get; set; } = new List<Sheet>();

        public SheetsManage(uint groupId, ushort semesterNumber)
        {
            //return Sheets.Where(sheet => sheet.SemesterNumber == semesterNumber);
        }
    }
}