using System;

namespace Task12
{
    class Program
    {
        static void Bothle (int[] arr, int size)
            {
            int buff = 0;
            
            for (int n = 0; n < size - 1; n++)           
                for (int i = 0; i < size - 1; i++)               
                    if (arr[i] > arr[i + 1])
                    {
                        buff = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = buff;
                    }                           
            
            Console.WriteLine("Sort of bothle metod.");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
        static void Insert(int[] arr, int size)
        {
            int buff = 0;
            int tmp=0;
            for (int n = 0; n < size - 1; n++)           
                for (int i = 0; i < size - 1; i++)               
                    if (arr[i] > arr[i + 1])
                    { 
                        tmp = i;
                        while(arr[tmp]< arr[i+1] && tmp !=0)
                            tmp--;
                        buff = arr[i+1];
                        arr[i+1] = arr[i];
                        arr[tmp] = buff;
                    } 
        }
        static void Main(string[] args)
        {
            int sizeOfArrey = 5;
            string choice;
            
            int[] array = new int[sizeOfArrey]{5,4,3,2,1,0};
            
           // Random rnd = new Random();
            Console.WriteLine("Array:");
            for (int i = 0; i < sizeOfArrey; i++)
            {
               // array[i] = rnd.Next(0, 100);
                Console.Write(array[i]+" ");
            }

            Console.WriteLine("") ;
           // Console.WriteLine("Made of choice for sort: 'bothle' or 'insert'");
            
           // choice = Console.ReadLine();
           // if (choice == "bothle")
               // Bothle(array,sizeOfArrey);
               Insert(array,sizeOfArrey);
                     
        }
    }
}
