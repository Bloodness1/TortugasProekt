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

namespace TortugasProekt.Windows
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btnnazad_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            Window2 Window2 = new Window2();
            Window2.Show();
            this.Close();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Window2 Window2 = new Window2();
            Window2.Show();
            this.Close();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            Window2 Window2 = new Window2();
            Window2.Show();
            this.Close();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Window2 Window2 = new Window2();
            Window2.Show();
            this.Close();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            Window2 Window2 = new Window2();
            Window2.Show();
            this.Close();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            Window2 Window2 = new Window2();
            Window2.Show();
            this.Close();
        }
    }
}
