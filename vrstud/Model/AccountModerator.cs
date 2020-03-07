using System;
using vrstud.DB;

namespace vrstud
{
    public static class AccountModerator
    {
        public static bool IsLoggined => !(NameAccount is null);

        public static string NameAccount { get; private set; }

        public static void Authorize(string Name, string Password)
        {
            if (IsLoggined)
                throw new Exception($"System was authorized next account:{NameAccount}");
            if (GetPassword(Name) != Password)
                throw new AuthoriseException();
            if(Name == "" || Name is null)
                throw new AuthoriseException();
            NameAccount = Name;
        }

        public static string GetDescription()
        {
            return "NotImplemented";
        }

        public static void Invalidate()
        {
            NameAccount = null;
        }

        private static string GetPassword(string name)
        {
            var managerAccount = new ManagingAccount();
            return managerAccount.GetPassword(name);
        }
    }
}