using System.Collections.Generic;

namespace vrstud.DB
{
    public class MarksManage
    {
        public Dictionary<uint, Dictionary<Case, ushort>> Marks { get; set; } =
            new Dictionary<uint, Dictionary<Case, ushort>>
            {
                {
                    0, new Dictionary<Case, ushort>
                    {
                        {new Case(), 58},
                        {new Case(), 85},
                        {new Case(), 69}
                    }
                },
                {
                    1, new Dictionary<Case, ushort>
                    {
                        {new Case(), 94}, 
                        {new Case(), 57}, 
                        {new Case(), 46}
                    }
                },
                {
                    2, new Dictionary<Case, ushort>
                    {
                        {new Case(), 71}, 
                        {new Case(), 64}, 
                        {new Case(), 75}
                    }
                }
            };
        //do it ctor with id group and 1 another ctor with id student
    }
}