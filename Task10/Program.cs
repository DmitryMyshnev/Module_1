using System;

namespace Task10
{
    class Program
    {
        /*
         Сумма диагоналей квадратной матрицы.
             */
        static void Main(string[] args)
        {
            int sizeOfMatrix = 5;
            int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];
            int summ = 0;
            Random rnd = new Random();
            Console.WriteLine("Matrix:");
            for (int i = 0; i < sizeOfMatrix; i++)
                for (int n = 0; n < sizeOfMatrix; n++)
                {
                    matrix[i, n] = rnd.Next(0, 10);
                    Console.Write(matrix[i, n] + " ");
                    if (n == (sizeOfMatrix - 1))
                        Console.WriteLine("");
                }
            for (int i = 0; i < sizeOfMatrix ; i++)
            {
                summ += matrix[i, i];
            }
            for (int i = 0; i < sizeOfMatrix; i++)
            {
                summ += matrix[i, (sizeOfMatrix-1)-i];
            }
            Console.WriteLine("Summ ="+summ);
            
        }
    }
}
