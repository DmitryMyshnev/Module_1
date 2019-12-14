using System;

namespace Task7
{
    class Program
    {
       
        static void SearchEvenOrNotEven(string evenOrNoteven, int[] rndArray, int[] tmpArray)
        {
            int maxValue = 0, minValue, index;

            if (evenOrNoteven == "even")
                for (int i = 0; i < 10; i++)
                    if (rndArray[i] % 2 == 0)
                    {
                        Console.Write(rndArray[i] + ",");
                        tmpArray[i] = rndArray[i];
                    }
                    else
                   if (evenOrNoteven == "noteven")
                        for (int n = 0; n < 10; n++)
                            if (rndArray[n] % 2 == 1)
                            {
                                Console.Write(rndArray[n] + ",");
                                tmpArray[n] = rndArray[n];
                            }

            for (int i = 0; i < 10; i++)  // search max value
            {
                if (tmpArray [i] >= maxValue)
                    maxValue = rndArray[i];
                index = i;
            }
            minValue = tmpArray[0];
            for (int n = 0; n < 10; n++)  // search min value
            {
                if (tmpArray[n] <= minValue)
                    minValue = tmpArray[n];
                index = n;
            }
            Console.WriteLine("Max = "+maxValue);
            Console.WriteLine("Min = " + minValue);

            Console.WriteLine("Change array: " + maxValue);
        }
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int[] tempArray = new int[10];
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

            SearchEvenOrNotEven(evenNoteven, array,tempArray);
            
            
        }
    }
}
