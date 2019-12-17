using System;

namespace Task7
{
    class Program
    {
        /*
         Поиск в массиве мин. и максимального, и четного или нечетного элемента (указывает пользователь) с последующей их заменой (поменять местами). 
             */
        static void SearchEvenOrNotEven(string evenOrNoteven, int[] rndArray, int[] tmpArray)
        {
            int maxValue = 0, minValue,  tmp = 0, endArray = 0,buff=0;
            int indexMin=0, indexMax=0;

            if (evenOrNoteven == "even")
            {
                for (int i = 0; i < 10; i++)
                    if (rndArray[i] % 2 == 0)
                    {
                        Console.Write(rndArray[i] + ",");
                        tmpArray[tmp++] = rndArray[i];
                        endArray++;
                    }
            }
            else
                   if (evenOrNoteven == "noteven")
                for (int n = 0; n < 10; n++)
                    if (rndArray[n] % 2 == 1)
                    {
                        Console.Write(rndArray[n] + ",");
                        tmpArray[tmp++] = rndArray[n];
                        endArray++;
                    }
            Console.WriteLine("");
            for (int i = 0; i < endArray; i++)  // search max value
            {
                if (tmpArray[i] >= maxValue)
                {
                    maxValue = tmpArray[i];
                    indexMax = i;
                }
            }
            minValue = tmpArray[0];
            for (int n = 0; n < endArray; n++)  // search min value
            {
                if (tmpArray[n] <= minValue)
                {
                    minValue = tmpArray[n];
                    indexMin =n;
                }
            }
            Console.WriteLine("Max = "+maxValue);
            Console.WriteLine("Min = " + minValue);

            buff = tmpArray[indexMax];
            tmpArray[indexMax] = tmpArray[indexMin];
            tmpArray[indexMin] = buff;
            Console.WriteLine("Change array: ");

            for (int i = 0; i < endArray; i++)                       
                Console.Write(tmpArray[i]+" ");
          
        }
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int[] tempArray = new int[10];
            
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
            Console.WriteLine("Enter 'even' or 'noteven': ");
            
            string evenNoteven = Console.ReadLine();
            SearchEvenOrNotEven(evenNoteven, array,tempArray);
            
            
        }
    }
}
