using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppTestUsickUI.Pages
{
    /// <summary>
    /// Логика взаимодействия для ViewDataBasePage.xaml
    /// </summary>
    public partial class ViewDataBasePage : Page
    {
        public ViewDataBasePage()
        {
            InitializeComponent();
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            Nav.Back();
        }

        private void PathClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
