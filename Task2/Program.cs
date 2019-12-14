using System;

namespace Task2
{
    class Program
    {
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
