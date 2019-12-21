using System;

namespace Task2
{
    class Program
    {
        /*
          Найти максимум или минимум или среднее из 3 чисел. (можно с выбором операции)
        */
        static void Main(string[] args)
        {
             int a = int.Parse(Console.ReadLine()),
                 b = int.Parse(Console.ReadLine()),
                 c = int.Parse(Console.ReadLine()),
                 maxValue;
            string str;
            int row, col;
             if (a > b && a > c)
                 maxValue = a;
             else
                     if (b > c)
                 maxValue = b;
             else
                 maxValue = c;
            Console.WriteLine("Enter: ");
             row = Console.CursorLeft;
             col = Console.CursorTop;
            do
            {
                Console.SetCursorPosition(row, col);               
                str = Console.ReadLine();
                Console.SetCursorPosition(row, col);
                Console.WriteLine(" ");

            }
            while (str != "t");

            do
            {
                Console.SetCursorPosition(row, col);
                str = Console.ReadLine();
                Console.SetCursorPosition(row, col);
                Console.WriteLine(" ");

            }
            while (str != "t");
            Console.WriteLine("Max Value = "+maxValue);
           /*int[] arr = new int[36];
            Random rnd = new Random();
            for (int i = 0; i < 36; i++)
            {
                arr[i] = i;
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("");
            for (int i = 0; i < 36; i++)
            {
                int tmp;
                int buffer;
                tmp = rnd.Next(0, 35);
                if (i != tmp)
                {
                    buffer = arr[i];
                    arr[i] = arr[tmp];
                    arr[tmp] = buffer;
                }
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }*/
        }
    }
}
