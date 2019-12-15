using System;

namespace Task11
{
    class Program
    {
        static ulong Factorial(ulong x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number.");
            ulong enterNumber = ulong.Parse(Console.ReadLine());
            ulong factorial = 0;
            factorial = Factorial(enterNumber);
            Console.WriteLine(enterNumber+"! = "+ factorial);
        }
    }
}
