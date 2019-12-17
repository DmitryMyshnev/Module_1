using System;

namespace Task12
{
    class Program
    {
        /*
         Сортировка массива. Пузырьком и вставками.
             */
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
            int buff ;
            int tmp;
           // for (int n = 0; n < size - 1; n++)           
                for (int i = 0; i < size - 1 ; i++)               
                    if (arr[i] > arr[i + 1])
                    {             
                        buff = arr[i+1];
                        arr[i+1] = arr[i];
                        arr[i] = buff;
                        tmp = i;
                        if (tmp != 0)
                            while (arr[tmp] < arr[tmp - 1])
                        {
                            buff = arr[tmp];
                            arr[tmp] = arr[tmp-1];
                            arr[tmp-1] = buff;
                            if(tmp!=1)
                             tmp--;
                        }
                        
                    }
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
        static void Main(string[] args)
        {
            int sizeOfArrey = 10;
            string choice;
            
            int[] array = new int[sizeOfArrey];
            
            Random rnd = new Random();
            Console.WriteLine("Array:");
            for (int i = 0; i < sizeOfArrey; i++)
            {
                array[i] = rnd.Next(0, 100);
                Console.Write(array[i]+" ");
            }

            Console.WriteLine("") ;
            Console.WriteLine("Made of choice for sort: 'bothle' or 'insert'");
            
            choice = Console.ReadLine();
            if (choice == "bothle")
               Bothle(array,sizeOfArrey);
            else
                if(choice == "insert")
               Insert(array,sizeOfArrey);
             
                     
        }
    }
}
