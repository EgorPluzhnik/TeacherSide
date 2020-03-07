using System.Collections.Generic;

namespace vrstud
{
    /// <summary>
    /// This class shows what kind of cases use in a semester in the group
    /// </summary>
    public class Sheet
    {
        public ushort SemesterNumber { get; set; }
        public List<Case> Cases { get; set; }
        public uint GroupId { get; set; }
    }
}