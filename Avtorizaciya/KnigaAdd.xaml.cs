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
    /// Логика взаимодействия для KnigaAdd.xaml
    /// </summary>
    public partial class KnigaAdd : Window
    {
        public KnigaAdd()
        {
            InitializeComponent();
        }

        private void Button_Gotovo(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
