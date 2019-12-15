using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = 5; 
            int[,] matrix = new int[sizeOfMatrix,sizeOfMatrix];
            int count = 10;
            int indexMatrix = 0;
            //Random rnd = new Random();
            Console.WriteLine("Matrix:");
            for (int i = 0; i < sizeOfMatrix; i++)
                for (int n = 0; n < sizeOfMatrix; n++)
                {
                    matrix[i, n] = count;
                    count++;
                    Console.Write(matrix[i,n] + " ");
                    if(n == (sizeOfMatrix-1))
                    Console.WriteLine("");
                }
            Console.WriteLine("");
            Console.WriteLine("New Array:");
            int[] arrayOfMatrix = new int[Convert.ToInt32 (Math.Pow(sizeOfMatrix , 2))];
            for (int i = sizeOfMatrix-1; i >= 0; i--)
                for (int n = sizeOfMatrix-1; n >= 0; n--)
                {
                    arrayOfMatrix[indexMatrix] = matrix[n, i];
                    Console.Write(arrayOfMatrix[indexMatrix] + " ");
                    indexMatrix++;
                }
                
            
            
            //Console.WriteLine("Hello World!");
        }
    }
}
