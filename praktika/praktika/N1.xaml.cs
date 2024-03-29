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

namespace praktika
{
    /// <summary>
    /// Логика взаимодействия для N1.xaml
    /// </summary>
    public partial class N1 : Window
    {
        public N1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int number;
            if (int.TryParse(tb1.Text, out number))
            {
                if (number >= 100 && number <= 999)
                {
                    bool result = class2.Evencount(number); 
                    if (result == true)
                    {
                        tb2.Text = $"Все цифры одинаковые";
                    }
                    else
                    {
                        tb2.Text = $"Все цифры неодинаковые";
                    }
                }
                else
                {
                    MessageBox.Show("Введите трехзначное число.");
                }
            }
            else
            {
                MessageBox.Show("Введите корректное число.");
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
