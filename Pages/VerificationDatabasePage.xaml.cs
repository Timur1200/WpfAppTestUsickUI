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
    /// Логика взаимодействия для VerificationDatabasePage.xaml
    /// </summary>
    public partial class VerificationDatabasePage : Page
    {
        public VerificationDatabasePage()
        {
            InitializeComponent();
            for(int i = 0; i < 10; i++)
            {
                DGrid.Items.Add("");
            }
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            Nav.Back();
        }
    }
}
