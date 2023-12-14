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

namespace Avtorizaciya
{
    /// <summary>
    /// Логика взаимодействия для bibliotekar.xaml
    /// </summary>
    public partial class bibliotekar : Window
    {
        public bibliotekar()
        {
            InitializeComponent();
        }


        private void Button_SpisokKnig(object sender, RoutedEventArgs e)
        {
            Vseknigi vseknigi = new Vseknigi();
            vseknigi.Show();
            this.Close();

        }

        private void Button_Exit1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_AddUser(object sender, RoutedEventArgs e)
        {
            Regist regist = new Regist();
            regist.Show();

        }

        private void Button_AddKniga(object sender, RoutedEventArgs e)
        {
             RegistKnig regist = new RegistKnig();
            regist.Show();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
