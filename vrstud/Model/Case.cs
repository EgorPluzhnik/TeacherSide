namespace vrstud
{
    public class Case : IIdentifiable
    {
        public uint Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}