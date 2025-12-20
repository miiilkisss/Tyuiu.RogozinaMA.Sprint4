using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.RogozinaMA.Sprint4.Task3.V15.Lib;

namespace Tyuiu.RogozinaMA.Sprint4.Task0.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            //Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими значениями в диапазоне от 2 до 9. Подсчитайте количество нечетных элементов во всем массиве. 7, 4, 2, 5, 3, 4, 3, 2, 5, 6, 6, 3, 4, 7, 5, 5, 7, 4, 3, 8, 7, 8, 8, 5, 6,
            int[,] array = new int[5, 5]
            {
                {7, 4, 2, 5, 3},
                {4, 3, 2, 5, 6},
                {6, 3, 4, 7, 5},
                {5, 7, 4, 3, 8},
                {7, 8, 8, 5, 6}
            };
            int result = ds.Calculate(array);
            Console.WriteLine("Количество нечетных элементов в массиве: " + result);
            Console.WriteLine(
                result == 13
                ? "Результат верный"
                : "Результат неверный"
            );

            Console.ReadLine();

        }
    }
}