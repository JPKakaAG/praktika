using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace praktika
{
    internal static class Class1
    {
        public static DataTable ToDataTable<T>(this T[,] matrix)
        {
            var res = new DataTable();
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                res.Columns.Add("col" + (i + 1), typeof(T));
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var row = res.NewRow();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    row[j] = matrix[i, j];
                }

                res.Rows.Add(row);
            }

            return res;
        }

    }
    internal class class2
    {
        /// <summary>
        /// Заполняет матрицу для 4 задания
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        /// <returns></returns>
        public static int[,] GenerateMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
            Random r = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = r.Next(0, 10);
                }
            }

            return matrix;
        }
        /// <summary>
        /// Формирует одномерный массив для 4 задания
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int[] GenerateArray(int[,] matrix, int a, int b)
        {
            int[] resultArray = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int count = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] >= a && matrix[i, j] <= b)
                    {
                        count++;
                    }
                }
                resultArray[i] = count;
            }
            return resultArray;

        }
        /// <summary>
        /// Определяет что все цифры трёхзначного числа одинаковые                                      
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool Evencount(int number)
        {
            int firstDigit = number / 100;
            int secondDigit = (number / 10) % 10;
            int thirdDigit = number % 10;
                if (firstDigit == secondDigit && secondDigit == thirdDigit)
                {
                    return(true);
                }
                else
                {
                    return(false);
                }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <param name="number3"></param>
        /// <param name="positiveCount"></param>
        /// <param name="negativeCount"></param>
        public static void PaNcount(int number1, int number2, int number3, out int positiveCount, out int negativeCount)
        {
            positiveCount = 0;
            negativeCount = 0;

            if (number1 > 0)
                positiveCount++;
            else if (number1 < 0)
                negativeCount++;

            if (number2 > 0)
                positiveCount++;
            else if (number2 < 0)
                negativeCount++;

            if (number3 > 0)
                positiveCount++;
            else if (number3 < 0)
                negativeCount++;
        }
        /// <summary>
        /// Определяет на сколько максимальный элемент массива больше минимального
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int N3(int[] array)
        {
            int max = array[0];
            int min = array[0];

            foreach (int num in array)
            {
                if (num > max)
                {
                    max = num;
                }

                if (num < min)
                {
                    min = num;
                }
            }

            int difference = max - min;
            return (difference);
        }
    }
    
}
