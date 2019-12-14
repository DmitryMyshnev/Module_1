using System;

namespace Task6
{
    class Program
    {
        static void Array(bool dir)
        {
            int[] writeArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            if (dir)
            {
                for (int i = 0; i <= 9; i++)
                {
                    if (i < 9)
                        Console.Write(writeArray[i] + ",");
                    else
                        Console.Write(writeArray[i] + ".\n");
                }

            }
            else
            {
                for (int i = 9; i >= 0; i--)
                {
                    if (i > 0)
                        Console.Write(writeArray[i] + ",");
                    else
                        Console.Write(writeArray[i] + ".\n");
                }
            }
        }
        static void Main(string[] args)
        {          
            Array(true);
            Array(false);
            Console.WriteLine("end.");
        }
    }
}
