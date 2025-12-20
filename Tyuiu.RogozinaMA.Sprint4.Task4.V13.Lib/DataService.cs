using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.RogozinaMA.Sprint4.Task4.V13.Lib
{
    public class DataService : ISprint4Task4V13
    {
        public int Calculate(int[,] matrix)
        {
            //Дан двумерный целочисленный массив 5 на 5 элементов, заполненный значениями с клавиатуры в диапазоне от 3 до 7. Найдите сумму четных элементов массива. 6, 3, 5, 7, 5, 3, 5, 7, 4, 5, 5, 6, 4, 5, 4, 7, 4, 7, 3, 3, 4, 6, 5, 5, 6,
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
