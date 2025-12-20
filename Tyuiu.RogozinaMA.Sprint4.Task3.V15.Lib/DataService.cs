using tyuiu.cources.programming.interfaces.Sprint4; 
namespace Tyuiu.RogozinaMA.Sprint4.Task3.V15.Lib
{
    public class DataService : ISprint4Task3V15
    {
        public int Calculate(int[,] array)
        {
            //Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими значениями в диапазоне от 2 до 9. Подсчитайте количество нечетных элементов во всем массиве. 7, 4, 2, 5, 3, 4, 3, 2, 5, 6, 6, 3, 4, 7, 5, 5, 7, 4, 3, 8, 7, 8, 8, 5, 6,
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 2 != 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
