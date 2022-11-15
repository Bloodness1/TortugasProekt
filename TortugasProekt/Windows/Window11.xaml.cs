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

namespace TortugasProekt.Windows
{
    /// <summary>
    /// Логика взаимодействия для Window11.xaml
    /// </summary>
    public partial class Window11 : Window
    {
        public Window11()
        {
            InitializeComponent();
        }

        private void btnnazad_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
            this.Close();
        }

        private void btnnapitki_Click(object sender, RoutedEventArgs e)
        {
            Window12 window12 = new Window12();
            window12.Show();
            this.Close();
        }

        private void btnnapinkis_Click(object sender, RoutedEventArgs e)
        {
            Window12 window12 = new Window12();
            window12.Show();
            this.Close();
        }
    }
}
