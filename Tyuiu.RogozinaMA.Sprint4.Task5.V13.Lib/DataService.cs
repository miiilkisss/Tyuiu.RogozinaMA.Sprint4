using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.RogozinaMA.Sprint4.Task5.V13.Lib
{
    public class DataService : ISprint4Task5V13
    {
        public int[,] Calculate(int[,] matrix)
        {
            //Дан двумерный целочисленный массив 5 на 5 элементов, заполненный случайными значениями в диапазоне от -2 до 5. Заменить отрицательные элементы на 0.
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }
    }
}
