namespace vrstud
{
    public class Student : IIdentifiable
    {
        public uint Id { get; set; }
        public uint GroupId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PatronymicName { get; set; }

        public string Abbreviation => GetAbbrNameInStart();

        public string GetAbbrNameInStart()
        {
            return $"{FirstName[0]}. {(PatronymicName is null ? "" : PatronymicName[0].ToString())}. {LastName}";
        }
    }
}