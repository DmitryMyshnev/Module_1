using System;

namespace Task15
{
    class Program
    {
        /*
          Удаление символа из строки.
             */
        static void Main(string[] args)
        {
            string text, simbol;
            int index;
            Console.WriteLine("Enter your text.");
            text = Console.ReadLine();
            Console.WriteLine("Enter simbol for remove.");
            simbol = Console.ReadLine();
            index = text.IndexOf(simbol);

            if (index < 0)
                Console.WriteLine("Simbol is not found");
            else
            {
                text = text.Remove(index, 1);
                Console.WriteLine(text);
            }
        }
    }
}
