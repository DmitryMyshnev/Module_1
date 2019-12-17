using System;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            string text, simbol;
            int index;
            Console.WriteLine("Enter your text.");
            text = Console.ReadLine();
            Console.WriteLine("Enter substring for remove.");
            simbol = Console.ReadLine();
            index = text.IndexOf(simbol);

            if (index < 0)
                Console.WriteLine("Simbol is not found");
            else
            {
                Console.WriteLine("New Text:");
                text = text.Remove(index, simbol.Length);
                Console.WriteLine(text);
            }
        }
    }
}
