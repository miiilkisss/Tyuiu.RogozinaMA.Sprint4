using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.RogozinaMA.Sprint4.Task6.V17.Lib;

namespace Tyuiu.RogozinaMA.Sprint4.Task0.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            //Дан строковый массив данных ["Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby"] используя класс Array подсчитайте количество элементов, длина которых равна 6.
            string[] array = new string[] { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };
            int result = ds.Calculate(array);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}