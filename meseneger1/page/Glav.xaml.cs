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
    /// Логика взаимодействия для Glav.xaml
    /// </summary>
    public partial class Glav : Window
    {
        public Glav()
        {
            InitializeComponent();
            chat.ItemsSource = bd.conec.DemoEntities.Chatrum.ToList();
            this.DataContext = MainWindow.user;
        }

        private void chat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var chatA = ((sender as ListView).SelectedItems as bd .chatmasage);
            chat win2 = new chat(chatA);
            win2.Show();
        }

        private void vrema_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Poisk win2 = new Poisk();
            win2.Show();
        }
    }
}
