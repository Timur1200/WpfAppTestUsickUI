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
    class Proj
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string DateCreate { get; set; }
        public string DateUpdate { get; set; }
    }

    public partial class OpenCreateProjectPage : Page
    {
        public OpenCreateProjectPage()
        {
            InitializeComponent();
            List<Proj> list = new List<Proj>();
            Proj p1 = new Proj {Name = "Новый проект 1", Author = "Иванов Иван", DateCreate=$"{DateTime.Now}",DateUpdate= $"{DateTime.Now}" };
            Proj p2 = new Proj { Name = "Super project123", Author = "Пётр", DateCreate = $"{DateTime.Now.AddDays(-5)}", DateUpdate = $"{DateTime.Now.AddDays(-2)}" };
            Proj p3 = new Proj { Name = "Новый проект 2", Author = "Овощ", DateCreate = $"{DateTime.Now}", DateUpdate = $"{DateTime.Now}" };

            list.Add(p1); 
            list.Add(p2);
            list.Add(p3);
            list.Add(p1);
            list.Add(p2);
            list.Add(p3);
            list.Add(p1);
            list.Add(p2);
            list.Add(p3);

            ProjectListView.ItemsSource = list;
            
        }

        private void CreateClick(object sender, RoutedEventArgs e)
        {
            Nav.Frame.Navigate(new GeneralPage());
        }
    }
}
