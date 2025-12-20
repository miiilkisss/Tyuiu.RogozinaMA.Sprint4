using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

using Tyuiu.RogozinaMA.Sprint4.Task0.V10.Lib;

namespace Tyuiu.RogozinaMA.Sprint4.Task0.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            //// Дан одномерный целочисленный массив на 10 элементов заполненный статическими значениями в диапазоне от 0 до 9 подсчипатать сумму нечетных элементов массива.  {9, 8, 7, 9, 5, 4, 3, 2, 3, 7}
            
            int[] array = new int[] { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };
            int sumOddElements = ds.GetSumOddArrEl(array);
            Console.WriteLine($"Сумма нечетных элементов массива: {sumOddElements}");
            Console.WriteLine(
                "Нажмите любую клавишу для завершения программы...");
            Console.ReadKey();


        }
    }
}
