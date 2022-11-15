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
    /// Логика взаимодействия для Window12.xaml
    /// </summary>
    public partial class Window12 : Window
    {
        public Window12()
        {
            InitializeComponent();
        }

        private void btnnazad_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
            this.Close();
        }

        private void btnoplata_Click(object sender, RoutedEventArgs e)
        {
            Window13 window13 = new Window13();
            window13.Show();
            this.Close();
        }
    }
}
