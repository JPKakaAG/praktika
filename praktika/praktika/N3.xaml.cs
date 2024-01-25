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

namespace praktika
{
    /// <summary>
    /// Логика взаимодействия для N3.xaml
    /// </summary>
    public partial class N3 : Window
    {
        public N3()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string input = tb2.Text;
            string[] numbers = input.Split(' ');

            int[] array = numbers.Select(int.Parse).ToArray();
            int minValue = array.Min();
            int maxValue = array.Max();

            int difference = maxValue - minValue;

            tb4.Text = $"Разница: {difference}";
        }

        private void back_click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();
        }
    }
    
}
