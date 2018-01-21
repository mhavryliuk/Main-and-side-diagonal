using System;

namespace Collection04
{
    class MyArray
    {
        // Метод для создания матрицы
        public static int[,] CreateArray(int n)
        {
            int[,] array = new int[n, n];
            Console.WriteLine();

            Console.WriteLine("Задайте значения элементам матрицы");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("Индекс [{0}, {1}] = ", i, j);
                    array[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            return array;
        }

        // Метод для вывода матрицы на консоль
        public static void PrintArray(int[,] array)
        {
            Console.WriteLine("\nЗаданна матрица:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Метод для вывода на консоль главной диагонали
        public static void PrintMainDiagonal(int[,] array)
        {
            Console.Write("\nГлавная диагональ: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write(array[i, i] + " ");
            }
        }

        // Метод для вывода на консоль побочной диагонали
        public static void PrintSecondaryDiagonal(int[,] array)
        {
            Console.Write("\nПобочная диагональ: ");
            for (int j = array.GetLength(0) - 1, i = 0; j >= 0; i++, j--)
            {
                Console.Write(array[i, j] + " ");
            }
        }
    }
}
