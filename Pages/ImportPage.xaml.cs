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
    /// Логика взаимодействия для ImportPage.xaml
    /// </summary>
    public partial class ImportPage : Page
    {
        public ImportPage()
        {
            InitializeComponent();
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            Nav.Back();
        }

        private void GoHomeClick(object sender, RoutedEventArgs e)
        {
            Nav.GoHome();
        }

        private void GoDataBaseClick(object sender, RoutedEventArgs e)
        {
            Nav.Frame.Navigate(new ViewDataBasePage());
        }

        private void PathClick(object sender, RoutedEventArgs e)
        {

        }

        private void PathHistoryClick(object sender, RoutedEventArgs e)
        {

        }

        private void PathTargetClick(object sender, RoutedEventArgs e)
        {

        }

        private void ExecuteImportClick(object sender, RoutedEventArgs e)
        {

        }

        private void GoViewDataBasePageClick(object sender, RoutedEventArgs e)
        {

        }

        private void GoSettingParamConstPageClick(object sender, RoutedEventArgs e)
        {

        }

        private void GoGeneralPageClick(object sender, RoutedEventArgs e)
        {

        }

        private void GoVerificationDatabasePageClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
