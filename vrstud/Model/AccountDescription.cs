namespace vrstud
{
    public class AccountDescription
    {
        public string Name { get; set; } = AccountModerator.IsLoggined ? AccountModerator.NameAccount : "Гость";
        public string Description { get; set; } = AccountModerator.IsLoggined ? AccountModerator.GetDescription() : "";
    }
}