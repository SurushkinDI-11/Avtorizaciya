﻿using System;
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
    /// Логика взаимодействия для KnigaDel.xaml
    /// </summary>
    public partial class KnigaDel : Window
    {
        public KnigaDel()
        {
            InitializeComponent();
        }

        private void Button_Gotovo(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
