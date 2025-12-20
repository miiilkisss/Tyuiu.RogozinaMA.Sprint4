using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.RogozinaMA.Sprint4.Task1.V17.Lib;

namespace Tyuiu.RogozinaMA.Sprint4.Task0.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            //Дан одномерный целочисленный массив на 14 элементов заполненный значениями с клавиатуры в диапазоне от 1 до 7 подсчитать сумму четных элементов массива.  С клавиатуры: 1, 7, 6, 3, 2, 5, 7, 6, 7, 6, 5, 4, 7, 6
            int[] array = new int[14];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите элемент массива под индексом {i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            int result = ds.Calculate(array);
            Console.WriteLine($"Сумма четных элементов массива: {result}");
            Console.WriteLine(
                "Нажмите любую клавишу для завершения программы...");
            Console.ReadKey();


        }
    }
}
