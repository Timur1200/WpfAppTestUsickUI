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
    /// Логика взаимодействия для PipelineModelAdaptationPage.xaml
    /// </summary>
    public partial class PipelineModelAdaptationPage : Page
    {
        public PipelineModelAdaptationPage()
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
    }
}
