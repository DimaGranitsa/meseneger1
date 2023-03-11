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
using System.Windows.Shapes;

namespace meseneger1.page
{
    /// <summary>
    /// Логика взаимодействия для Poisk.xaml
    /// </summary>
    public partial class Poisk : Window
    {
        public Poisk()
        {
            InitializeComponent();
            poiskk.ItemsSource = bd.conec.DemoEntities.User.ToList();

        }

        private void pytesh_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void pytesh_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void poiskk_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
