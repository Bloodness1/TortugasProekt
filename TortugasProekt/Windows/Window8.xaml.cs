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
    /// Логика взаимодействия для Window8.xaml
    /// </summary>
    public partial class Window8 : Window
    {
        public Window8()
        {
            InitializeComponent();
        }

        private void btnsalete_Click(object sender, RoutedEventArgs e)
        {
            Window9 window9 = new Window9();
            window9.Show();
            this.Close();
        }

        private void btnnazad_Click(object sender, RoutedEventArgs e)
        {
            Window7 window7 = new Window7();
            window7.Show();
            this.Close();
        }
    }
}
