using System;
using System.Text;

namespace BlackJack
{
    struct Card
    {
       public string Suit;
       public int Rang;      
    }
    enum Value 
    {
        Six = 6,
        Seven = 7,
        Еight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 'J',
        Queen = 'Q',
        King = 'K',
        Ace = 'A'
    }
    class Program
    {
      static  Card[] Deck = new Card[36];
      static int[] value = new int[9] { 6, 7, 8, 9, 10, 2, 3, 4, 11 };

        static void MixDeck()
        {
            int[] arr = new int[36];
            Random rnd = new Random();
            for (int i = 0; i < 36; i++)
            {
                arr[i] = i;
                Console.Write(arr[i] + " ");
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
            
        }       
           static void InitDeck()
           {
            int n=0;
            for (int i = 0; i < 9; i++)           
                for (int j = 0; j < 4; j++)
                {
                    Deck[n].Rang = value[i];
                    n++;
                }           
           }
        static void SizeWindow()
        {
            Console.Clear();
            Console.SetWindowSize(120, 33);
            Console.BufferWidth = 120;
            Console.BufferHeight = 33;
        }
        static void DrawCard(int x, int y)
        {
            Console.CursorVisible = false;
            for (int i = 1; i < 9; i++)
            {
                Console.SetCursorPosition(x, y+i); Console.Write("|");
              /*  Console.SetCursorPosition(0, y + 2); Console.Write("|");
                Console.SetCursorPosition(0, 3); Console.Write("|");
                Console.SetCursorPosition(0, 4); Console.Write("|");
                Console.SetCursorPosition(0, 5); Console.Write("|");
                Console.SetCursorPosition(0, 6); Console.Write("|");
                Console.SetCursorPosition(0, 7); Console.Write("|");
                Console.SetCursorPosition(0, 8); Console.Write("|");*/
            }

            Console.SetCursorPosition(x+1, y); Console.Write("______");
            for (int i = 1; i < 9; i++)
            {
                Console.SetCursorPosition(x+7, y+i); Console.Write("|");
               /* Console.SetCursorPosition(7, 2); Console.Write("|");
                Console.SetCursorPosition(7, 3); Console.Write("|");
                Console.SetCursorPosition(7, 4); Console.Write("|");
                Console.SetCursorPosition(7, 5); Console.Write("|");
                Console.SetCursorPosition(7, 6); Console.Write("|");
                Console.SetCursorPosition(7, 7); Console.Write("|");
                Console.SetCursorPosition(7, 8); Console.Write("|");*/
            }
            Console.SetCursorPosition(x+1, y+8); Console.Write("______");
        }

        static void Main(string[] args)
        {
            SizeWindow();
            InitDeck();
             ;
            Console.WriteLine((char)Value.Queen);
            Console.WriteLine(Value.Ten.ToString("d"));
            Console.WriteLine(Value.Seven.ToString("d"));
            Console.ReadLine();
            


        }
    }
}
