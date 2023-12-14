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
    /// Логика взаимодействия для Vseknigi.xaml
    /// </summary>
    public partial class Vseknigi : Window
    {
        public Vseknigi()
        {
            InitializeComponent();
        }



        private void Button_Vernutsya(object sender, RoutedEventArgs e)
        {
            bibliotekar bibliotekar = new bibliotekar();
            bibliotekar.Show();
            this.Close();

        }

        private void Button_Exit2(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }


        private void Button_DelClick(object sender, RoutedEventArgs e)
        {
            KnigaDel knigaDel = new KnigaDel();
            knigaDel.Show();
        }

        private void Button_AddClick(object sender, RoutedEventArgs e)
        {
            KnigaAdd knigaAdd = new KnigaAdd();
            knigaAdd.Show();
        }
    }
}
