using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инициализация двумерного массива размером 4x5
            int[,] array = new int[4, 5]
            {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 10},
                {11, 12, 13, 14, 15},
                {16, 17, 18, 19, 20}
            };

            // Вызов метода для обмена симметричных строк
            SwapSymmetricRows(array);

            // Вывод измененного массива
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Метод для обмена симметричных строк в двумерном массиве
        public static void SwapSymmetricRows(int[,] array)
        {
            // Вычисление индекса средней строки
            int middle = array.GetLength(0) / 2;

            // Временный массив для хранения значений во время обмена
            int[] temp = new int[array.GetLength(1)];

            // Цикл по первой половине строк
            for (int i = 0; i < middle; i++)
            {
                // Цикл по каждому элементу в строке
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    // Обмен значениями между текущей строкой и ее симметричной парой
                    temp[j] = array[i, j];
                    array[i, j] = array[middle + i, j];
                    array[middle + i, j] = temp[j];
                }
            }
        }
    }
}
