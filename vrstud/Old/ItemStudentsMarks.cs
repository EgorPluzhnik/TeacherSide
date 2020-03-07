namespace vrstud
{
    public class ItemStudentsMarks
    {
        public ItemStudentsMarks(int id, string fio, int c1, int c2, int c3)
        {
            Id = id;
            FIO = fio;
            Case1 = c1;
            Case2 = c2;
            Case3 = c3;
        }

        public int Id { get; set; }
        public string FIO { get; set; }
        public int Case1 { get; set; }
        public int Case2 { get; set; }
        public int Case3 { get; set; }
    }
}