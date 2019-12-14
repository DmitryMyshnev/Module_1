using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter niumber:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter power:");
            int power = int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= num; 
            }
            Console.WriteLine(result);
        }
    }
}
