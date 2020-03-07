using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace vrstud.test.test2
{
    public static class PageWrap
    {
        public static readonly Stack<Page> Pages;
        public static NavigationService nav;

        static PageWrap()
        {
            Pages = new Stack<Page>();
        }
    }
}