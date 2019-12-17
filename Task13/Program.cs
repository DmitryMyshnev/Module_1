using System;

namespace Task13
{
    class Program
    {
        static int BinarySearch(int[] arr, int val, int size)
        {
            int search;
            Array.Sort(arr);
            foreach (var item in arr)
                Console.Write(item+" ");
            Console.WriteLine("");
            if (arr[0] == val)
                return 0;
            else
            if (arr[size - 1] == val)
                return size - 1;
            search = Array.BinarySearch(arr, val);
            if (search < 0)
                return -1; 
            else
                return search;

        }
        static void Main(string[] args)
        {
            int sizeOfArrey = 10;           
            int[] array = new int[sizeOfArrey];
            int valueOfSearch;
            int result;
            Random rnd = new Random();
            Console.WriteLine("Array:");
            for (int i = 0; i < sizeOfArrey; i++)
            {
                array[i] = rnd.Next(0, 100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Enter number for search.");
            valueOfSearch = int.Parse(Console.ReadLine());
            result = BinarySearch(array, valueOfSearch,sizeOfArrey);
            if (result == -1)           
                Console.WriteLine("Value is not found");
            else
                Console.WriteLine("The item you are looking for is: " + result);
            
        }
    }
}
