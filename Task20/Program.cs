using System;

namespace Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            string simbol;
            char[] anyOf;
            string[] newText;

            Console.WriteLine("Enter your text.");
            text = Console.ReadLine();
            Console.WriteLine("Enter your separate simbol.");
            simbol = Console.ReadLine();
            anyOf = simbol.ToCharArray(0,1);
            newText = text.Split(anyOf);
            foreach (var item in newText)
            {
                Console.WriteLine(item);
            }
        }
    }
}
