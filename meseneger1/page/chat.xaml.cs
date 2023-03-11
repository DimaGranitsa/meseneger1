using meseneger1.bd;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Xml.Linq;

namespace meseneger1.page
{
    /// <summary>
    /// Логика взаимодействия для chat.xaml
    /// </summary>
    public partial class chat : Window
    {
        bd.chatmasage w;
        public chat(bd.chatmasage chatmasegee)
        {
            InitializeComponent();
            w = chatmasegee;
            this.DataContext = w;
            man.ItemsSource = bd.conec.DemoEntities.User.ToList();
            chatt.ItemsSource = bd.conec.DemoEntities.chatmasage.ToList();
        }

        private void chatt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public void q()
        {
            chatt.ItemsSource = bd.conec.DemoEntities.chatmasage.ToList();
        }
        private void man_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void cheng_Click(object sender, RoutedEventArgs e)
        {
            Glav win2 = new Glav();
            win2.Show();
            
        }

        private void leave_Click(object sender, RoutedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void otp_Click(object sender, RoutedEventArgs e)
        {
   
            bd.chatmasage qwe = new bd.chatmasage()
            {
             
                name = otprav.Text,
               date= DateTime.Now,

            };
            bd.conec.DemoEntities.chatmasage.Add(qwe);
            bd.conec.DemoEntities.SaveChanges();
          
            q();
        }
    }
}
