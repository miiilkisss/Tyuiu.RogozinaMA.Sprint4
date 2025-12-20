using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.RogozinaMA.Sprint4.Task0.V10.Lib
{
    public class DataService : ISprint4Task0V10
    {
        public int GetSumOddArrEl(int[] array)
        {
            // Дан одномерный целочисленный массив на 10 элементов заполненный статическими значениями в диапазоне от 0 до 9 подсчипатать сумму нечетных элементов массива.  {9, 8, 7, 9, 5, 4, 3, 2, 3, 7}
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sum += array[i];
                }
            }
            return sum;

        }
    }
}
