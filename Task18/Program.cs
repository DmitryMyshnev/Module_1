using System;

namespace Task18
{
    class Program
    {
        /*
         Реверс строки.
             */
        static void Main(string[] args)
        {
            string text; 
            char[]  simbol;
            int sizeOfText;
            Console.WriteLine("Enter your text.");
            text = Console.ReadLine();
            sizeOfText = text.Length;
            simbol = text.ToCharArray(0,sizeOfText);
            Console.WriteLine("New Text:");
            for (int i = sizeOfText-1; i >= 0; i--)
            {
               Console.Write(simbol[i]);
            }
            
        }
    }
}
