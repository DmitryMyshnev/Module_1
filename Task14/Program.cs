using System;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            string text,simbol;
           
            Console.WriteLine("Enter your text.");
            text = Console.ReadLine();
            Console.WriteLine("Enter simbol for search.");
            simbol = Console.ReadLine();
            int index = text.IndexOf(simbol);
            if (index < 0)
                Console.WriteLine("Simbol is not found");
            else
            {
                Console.WriteLine(text);
                for (int i = 0; i < index; i++)
                    Console.Write(" ");

                Console.WriteLine("^");
                Console.WriteLine("Index of your simbol is: " + index);
            }
        }
    }
}
