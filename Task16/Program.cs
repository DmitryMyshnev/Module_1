using System;

namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            string text, simbol;
            int index;
            Console.WriteLine("Enter your text.");
            text = Console.ReadLine();
            Console.WriteLine("Enter substring for search.");
            simbol = Console.ReadLine();
            index = text.IndexOf(simbol);
            if (index < 0)
                Console.WriteLine("Simbol is not found");
            else
            {
                Console.WriteLine(text);
                for (int i = 0; i < index; i++)
                    Console.Write(" ");
                for (int i = 0; i < simbol.Length; i++)
                {
                   Console.Write("^");
                }
                Console.WriteLine("");
                Console.Write("Indexs of your substring is: ");
                for (int i = index; i < (index + simbol.Length); i++)
                    Console.Write(i+" ");
            }
        }
    }
}
