using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            
            for (int i = 0; i < 10; i++)
            {
                array1[i] = rnd.Next(0,10);
                array2[i] = rnd.Next(0,10);
            }
           foreach (var item in array1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
            foreach (var item in array2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
            for (int i = 0; i < 10; i++)
            {
                if (array1[i] == array2[i])
                {                 
                    Console.Write("^ ");
                }
                else
                    Console.Write("  ");
            }
           
        }
    }
}
