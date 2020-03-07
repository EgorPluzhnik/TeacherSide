using System.Windows.Navigation;

namespace vrstud
{
    public static class Navigator
    {
        public static NavigationService nav { get; set; }

        public static void CleanAllBackPages()
        {
            while (nav.CanGoBack) nav.RemoveBackEntry();
        }
    }
}