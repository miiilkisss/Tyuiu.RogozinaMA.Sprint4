using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.RogozinaMA.Sprint4.Task7.V11.Lib;

namespace Tyuiu.RogozinaMA.Sprint4.Task0.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            // Дана строка из одноразрядных цифр "56789012". Преобразуйте ее в матрицу 4 на 2 и подсчитайте количество нечетных чисел в матрице.
            string value = "56789012";
            int n = 4;
            int m = 2;
            int result = ds.Calculate(n, m, value);
            Console.WriteLine(result);
            Console.WriteLine(
                result == 4 ? "Test passed." : "Test failed."
            );
            Console.WriteLine(
                "Press any key to continue..."
            );
            Console.ReadKey();


        }
    }
}