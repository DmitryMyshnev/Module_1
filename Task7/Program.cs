using System;

namespace Task7
{
    class Program
    {
        static int SearchValue(string minOrMax, int[] rndArray)
        {

            int maxValue = 0, minValue;

            for (int i = 0; i < 10; i++)  // search max value
            {
                if (rndArray[i] >= maxValue)
                    maxValue = rndArray[i];
            }


            minValue = rndArray[0];
            for (int n = 0; n < 10; n++)  // search min value
            {
                if (rndArray[n] <= minValue)
                    minValue = rndArray[n];
            }


            return rndArray;
        }
        static int SearchEvenOrNotEven(string evenOrNoteven, int[] rndArray)
        {
            int maskIndexArrayEvenOrNotEven = 0;
            if (evenOrNoteven == "even")
                for (int i = 0; i < 10; i++)
                    if (rndArray[i] % 2 == 0)
                    {
                        Console.Write(rndArray[i] + ",");
                        maskIndexArrayEvenOrNotEven |= 1 << i;
                    }
                    else
                   if (evenOrNoteven == "noteven")
                        for (int n = 0; n < 10; n++)
                            if (rndArray[n] % 2 == 1)
                            {
                                Console.Write(rndArray[n] + ",");
                                maskIndexArrayEvenOrNotEven |= 1 << n;
                            }

            return maskIndexArrayEvenOrNotEven;
        }
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int value;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(0, 100);
            }
            Console.WriteLine("Array: ");
            foreach (var item in array)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine("\n");


            Console.WriteLine("Enter 'even' or 'noteven': ");
            string evenNoteven = Console.ReadLine();
            value = SearchEvenOrNotEven(evenNoteven, array);
            //value = SearchValue(minOrmax, array);
            Console.Write(value + "\n");
        }
    }
}
