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
    /// Логика взаимодействия для N2.xaml
    /// </summary>
    public partial class N2 : Window
    {
        public N2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int number1, number2, number3;
            if (int.TryParse(tb1.Text, out number1) &&
                int.TryParse(tb2.Text, out number2) &&
                int.TryParse(tb3.Text, out number3))
            {
                int[] result = class2.PaNcount(number1, number2, number3);
                int positiveCount, negativeCount;
                positiveCount = result[0];
                negativeCount = result[1];
                tb4.Text = $"Положительных чисел: {positiveCount}\r\nОтрицательных чисел: {negativeCount}";
               
            }
            else
            {
                MessageBox.Show("Введите корректные числа.");
            }
        }
        private void back_click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();
        }
    }
}
