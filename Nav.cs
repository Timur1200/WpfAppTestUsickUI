using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfAppTestUsickUI.Pages;

namespace WpfAppTestUsickUI
{
    internal class Nav
    {
        public static Frame Frame { get; set; }
        public static void Back()
        {
            if (Frame.NavigationService.CanGoBack)
                Frame.NavigationService.GoBack();
        }
        public static void GoHome()
        {
            Frame.Navigate(new GeneralPage());
        }
    }
}
