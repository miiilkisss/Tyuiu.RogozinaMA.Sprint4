using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.RogozinaMA.Sprint4.Task4.V13.Lib;

namespace Tyuiu.RogozinaMA.Sprint4.Task0.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            //Дан двумерный целочисленный массив 6 на 6 элементов, заполненный случайными значениями в диапазоне от 1 до 9. Подсчитайте количество четных элементов во всем массиве.\

            int[,] matrix = new int[6, 6];
            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    matrix[i, j] = rand.Next(1, 10);
                }
            }
            int result = ds.Calculate(matrix);
            Console.WriteLine("Количество четных элементов в массиве: " + result);
            Console.WriteLine(
                "Исходный массив:\n" +
                string.Join("\n", Enumerable.Range(0, 6).Select(i =>
                    string.Join(" ", Enumerable.Range(0, 6).Select(j => matrix[i, j]))))
            );

            Console.ReadLine();

        }
    }
}