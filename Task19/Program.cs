using System;

namespace Task19
{
    class Program
    {
        /*
         Проверка строки на палиндром.
             */
        static void Main(string[] args)
        {
            string text;
            char[] newText;
            char[] anyOf = new char[]{' ','!','.',',','-'};
            int sizeOfText;
            int search = 0;
            bool palindrom = false;
            Console.WriteLine("Enter your text.");
            text = Console.ReadLine();
            while (search >= 0)
            {
                search = text.IndexOfAny(anyOf,0);
                if(search >= 0)
                text = text.Remove(search, 1);
            }
   
            text = text.ToLower();

            newText = text.ToCharArray(0, text.Length);
            sizeOfText = text.Length;
            for (int i = 0,j = sizeOfText-1; i != j; i++,j--)
            {
                if (newText[i] == newText[j])
                    palindrom = true;
                else
                {
                    palindrom = false;
                    break;
                }
            }
            if(palindrom)
                Console.WriteLine("Text is palindrom.");
            else
                Console.WriteLine("Text is not palindrom.");
            //sizeOfText = text.Length;
            //Console.WriteLine(sizeOfText);
            /*foreach (var item in text)
             {
                 Console.Write(item);
             }*/
        }
    }
}
