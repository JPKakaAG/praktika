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
using System.Data;

namespace praktika
{
    /// <summary>
    /// Логика взаимодействия для N4.xaml
    /// </summary>
    public partial class N4 : Window
    {

        int[,] matrix;
        public N4()
        {
            InitializeComponent();
            dg1.CellEditEnding += Dg1_CellEditEnding;
        }

        private void Dg1_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {       
            int rowIndex = e.Row.GetIndex();
            int columnIndex = e.Column.DisplayIndex;         
            matrix[rowIndex, columnIndex] = Convert.ToInt32(((TextBox)e.EditingElement).Text);
            if (int.TryParse(tb2.Text, out int matrixRows) &&
                int.TryParse(tb3.Text, out int matrixColumns) &&
                int.TryParse(tbA.Text, out int a) &&
                int.TryParse(tbB.Text, out int b))
            {               
                int[] resultArray = class2.GenerateArray(matrix, a, b);
                tb4.Text = $"Массив: {string.Join(", ", resultArray)}";
            }
            else
            {
                MessageBox.Show("Введите корректные числа.");
            }          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tb2.Text, out int matrixRows) &&
                int.TryParse(tb3.Text, out int matrixColumns) &&
                int.TryParse(tbA.Text, out int a) &&
                int.TryParse(tbB.Text, out int b))
            {
                matrix = class2.GenerateMatrix(matrixRows, matrixColumns);
                dg1.ItemsSource = Class1.ToDataTable(matrix).DefaultView;
                int[] resultArray = class2.GenerateArray(matrix, a, b);
                tb4.Text = $"Массив: {string.Join(", ", resultArray)}";
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
