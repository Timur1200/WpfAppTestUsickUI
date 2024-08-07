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
    class History
    {
        public string Name { get; set; }
        public string Message { get; set; }
        public string Date { get; set;}
    }

    public partial class GeneralPage : Page
    {
        public GeneralPage()
        {
            InitializeComponent();
            History h= new History {Name="Название",Message="СООБЩЕНИЕ 123", Date=$"{DateTime.Now}" };
            List<History> list = new List<History>();
            list.Add(h);
            for (int i = 0; i < 20; i++) 
            {
                History q = new History { Name = $"Name {i}", Message = $"СООБЩЕНИЕ {i * 2 + 1}", Date = $"{DateTime.Now}" };
                list.Add(q);
            }
            ProjectListView.ItemsSource = list;
        }

        private void SettingParamConstPageClick(object sender, RoutedEventArgs e)
        {
            Nav.Frame.Navigate(new SettingParamConstPage());
        }

        private void ImportClick(object sender, RoutedEventArgs e)
        {
            Nav.Frame.Navigate (new ImportPage());
        }

        private void VerifDbClick(object sender, RoutedEventArgs e)
        {
            Nav.Frame.Navigate(new VerificationDatabasePage());
        }

        private void ViewDbClick(object sender, RoutedEventArgs e)
        {
            Nav.Frame.Navigate(new ViewDataBasePage());
        }

        private void OilWellModelClick(object sender, RoutedEventArgs e)
        {
            Nav.Frame.Navigate(new OilWellModelPage());
        }

        private void PipelineModelAdaptationClick(object sender, RoutedEventArgs e)
        {
            Nav.Frame.Navigate(new PipelineModelAdaptationPage());
        }

        private void OptimizingPipelineModelsClick(object sender, RoutedEventArgs e)
        {
            Nav.Frame.Navigate(new OptimizingPipelineModelsPage());
        }
    }
}
