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
    /// Логика взаимодействия для SettingParamConstPage.xaml
    /// </summary>
    public partial class SettingParamConstPage : Page
    {
        public SettingParamConstPage()
        {
            InitializeComponent();
            for (int i = 0; i < 50; i++)
            {
                DGrid.Items.Add("");
            }
            

            StatusTextBox.AppendText  ("1232134142353lrdes232134142353l4142353lrdes232134142353lrdesg4142353lrdes232134142353lrdesg4142353lrdes232134142353lrdesg4142353lrdes232134142353lrdesg4142353lrdes232134142353lrdesg4142353lrdes232134142353lrdesg4142353lrdes232134142353lrdesg4142353lrdes232134142353lrdesg4142353lrdes232134142353lrdesg4142353lrdes232134142353lrdesg4142353lrdes232134142353lrdesg4142353lrdes232134142353lrdesg4142353lrdes232134142353lrdesg4142353lrdes232134142353lrdesg4142353lrdes232134142353lrdesg4142353lrdes232134142353lrdesg4142353lrdes232134142353lrdesg4142353lrdes232134142353lrdesg4142353lrdes232134142353lrdesg4142353lrdes232134142353lrdesg4142353lrdes232134142353lrdesg4142353lrdes232134142353lrdesg4142353lrdes232134142353lrdesg4142353lrdes232134142353lrdesgrdesgkderfkbgvedfkgbherlgldg,kdflgkdf232134142353lrdesgkderfkbgvedfkgbherlgldg,kdflgkdf232134142353lrdesgkderfkbgvedfkgbherlgldg,kdflgkdf232134142353lrdesgkderfkbgvedfkgbherlgldg,kdflgkdf232134142353lrdesgkderfkbgvedfkgbherlgldg,kdflgkdf232134142353lrdesgkderfkbgvedfkgbherlgldg,kdflgkdf232134142353lrdesgkderfkbgvedfkgbherlgldg,kdflgkdf232134142353lrdesgkderfkbgvedfkgbherlgldg,kdflgkdf232134142353lrdesgkderfkbgvedfkgbherlgldg,kdflgkdf232134142353lrdesgkderfkbgvedfkgbherlgldg,kdflgkdfgkderfkbgvedfkgbherlgldg,kdflgkdf232134142353lrdesgkderfkbgvedfkgbherlgldg,kdflgkdf232134142353lrdesgkderfkbgvedfkgbherlgldg,kdflgkdf232134142353lrdesgkderfkbgvedfkgbherlgldg,kdflgkdf232134142353lrdesgkderfkbgvedfkgbherlgldg,kdflgkdf232134142353lrdesgkderfkbgvedfkgbherlgldg,kdflgkdf232134142353lrdesgkderfkbgvedfkgbherlgldg,kdflgkdflgkdflgkdfhgokdhlk" +
                "eerreytdy");
        }

        private void GoHomeClick(object sender, RoutedEventArgs e)
        {
            Nav.GoHome();   
        }
    }
}
