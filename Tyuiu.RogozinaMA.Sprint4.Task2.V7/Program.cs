using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

using Tyuiu.RogozinaMA.Sprint4.Task2.V7.Lib;

namespace Tyuiu.RogozinaMA.Sprint4.Task0.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            //Дан одномерный целочисленный массив на 12 элементов заполненный случайными в диапазоне от 4 до 9 подсчитать сумму четных элементов массива.
            int[] array = new int[12];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(4, 10);
            }
            Console.WriteLine("Массив: " + string.Join(", ", array));
            int result = ds.Calculate(array);
            Console.WriteLine("Сумма четных элементов массива: " + result);

            Console.ReadLine();
        }
    }
}
