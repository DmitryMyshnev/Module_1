using System;

namespace Task2
{
    class Program
    {
        /*
          Найти максимум или минимум или среднее из 3 чисел. (можно с выбором операции)
        */
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()),
                b = int.Parse(Console.ReadLine()),
                c = int.Parse(Console.ReadLine()),
                maxValue;
            if (a > b && a > c)
                maxValue = a;
            else
                    if (b > c)
                maxValue = b;
            else
                maxValue = c;
            
            Console.WriteLine("Max Value = "+maxValue);
        }
    }
}
