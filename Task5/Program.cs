using System;

namespace Task5
{
    class Program
    {
        /*
         Метод генерации случайного массива (размер самого массива и диапазон значений должны быть задаваемыми через параметры)
             */
        static void RandomArray(int rangeMin, int rangeMax, int size)
        {
            int[] arrayRnd = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                arrayRnd[i] = rnd.Next(rangeMin, rangeMax);                       
            }
            foreach (var item in arrayRnd)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            RandomArray(0, 10, 10);
            
        }
    }
}
