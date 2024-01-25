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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace praktika
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void n1_click(object sender, RoutedEventArgs e)
        {
            N1 n1 = new N1();
            this.Close();
            n1.Show();
        }
        private void n2_click(object sender, RoutedEventArgs e)
        {
            N2 n2 = new N2();
            this.Close();
            n2.Show();
        }
        private void n3_click(object sender, RoutedEventArgs e)
        {
            N3 n3 = new N3();
            this.Close();
            n3.Show();
        }
        private void n4_click(object sender, RoutedEventArgs e)
        {
            N4 n4 = new N4();
            this.Close();
            n4.Show();
        }
    }
}
