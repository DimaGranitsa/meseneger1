using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using meseneger1.bd;
using meseneger1.page;

namespace meseneger1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static bd.User user;
        public MainWindow()
        {
            InitializeComponent();
            q.Navigate(new page.reg());
            
        }

        private void q_Navigated(object sender, NavigationEventArgs e)
        {
            NavigationService.GetNavigationService(new page.reg()); 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text) && string.IsNullOrEmpty(pass.Password))
            {
                MessageBox.Show("нет введеных даных");
            }
            else
            {
                var a = bd.conec.DemoEntities.User.Where(z => z.Name == username.Text && z.Pass == pass.Password).FirstOrDefault();
               // var d = a..FirstOrDefault();
                if (a != null)
                {
                    if (a.ID == 1)
                    {
                        MessageBox.Show($"добропожаловать{a.Name}");
                        Glav win2 = new Glav();
                        win2.Show();
                        MainWindow.user = a;
                        //NavigationService.Navigate(new exam22stol.Development_Pages.themainwindowfortheadmin());
                    }
                  
                }
                else
                    MessageBox.Show($"нет таких");

            }
        }
    }
}
    

