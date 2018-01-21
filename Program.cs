using System;

/* Задание: Вывести на экран главную и неглавную диагонали матрицы.
 * Значения вводить вручную, использовать классы. */

namespace Collection04
{
    class Program
    {
        static void Main()
        {
            Console.Write("Укажите размер матрицы (n * n): ");
            int n = int.Parse(Console.ReadLine());
            int[,] array = MyArray.CreateArray(n);

            MyArray.PrintArray(array);
            MyArray.PrintMainDiagonal(array);
            MyArray.PrintSecondaryDiagonal(array);

            Console.ReadLine();
        }
    }
}
