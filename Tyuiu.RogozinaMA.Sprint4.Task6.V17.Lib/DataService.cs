using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.RogozinaMA.Sprint4.Task6.V17.Lib
{
    public class DataService : ISprint4Task6V17
    {
        public int Calculate(string[] array)
        {
            //Дан строковый массив данных ["Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby"] используя класс Array подсчитайте количество элементов, длина которых равна 6.
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length == 6)
                {
                    count++;
                }
            }
            return count;

        }
    }
}
