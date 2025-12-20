using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.RogozinaMA.Sprint4.Task1.V17.Lib
{
    public class DataService : ISprint4Task1V17
    {
        public int Calculate(int[] array)
        {
            //Дан одномерный целочисленный массив на 14 элементов заполненный значениями с клавиатуры в диапазоне от 1 до 7 подсчитать сумму четных элементов массива.  С клавиатуры: 1, 7, 6, 3, 2, 5, 7, 6, 7, 6, 5, 4, 7, 6
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
    }
}
