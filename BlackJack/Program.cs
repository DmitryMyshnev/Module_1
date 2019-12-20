using System;
using System.Text;

namespace BlackJack
{
    
    struct Card
    {
       public string Suit;
       public int Rang;
       public string RangName;
    }
    enum Value 
    {
        Six   = 6,
        Seven = 7,
        Еight = 8,
        Nine  = 9,
        Ten   = 10,
        Jack  = 2,
        Queen = 3,
        King  = 4,
        Ace   = 11
    }
    enum Suit
    {
        Diamonds, //бубны
        Hearts,  // червы
        Spades,  // пики
        Clubs    // трефы
    }
    class Program
    {
      static  Card[] Deck = new Card[36];
      static int[] value = new int[9]
      {
        (int)Value.Six, 
        (int)Value.Seven, 
        (int)Value.Еight, 
        (int)Value.Nine,
        (int)Value.Ten,
        (int)Value.Jack,
        (int)Value.Queen,
        (int)Value.King,
        (int)Value.Ace
      };
      static string[] suitNameBasic = new string[4] {"Diamonds","Hearts","Spades","Clubs"};
      static string[] rangeNameBasic = new string[9] {"6", "7", "8", "9", "10", "J", "Q", "K", "A", };
      static string[,] strategy = new string[16,10] 
        {
            {"H","H","H","H","H","H","H","H","H","H"},
            {"H","H","H","H","H","H","H","H","H","H"},
            {"H","H","H","H","H","H","H","H","H","H"},
            {"H","H","H","H","H","H","H","H","H","H"},
            {"H","H","H","S","S","H","H","H","H","H"},
            {"H","S","S","S","S","H","H","H","H","H"},
            {"H","S","S","S","S","H","H","H","H","H"},
            {"S","S","S","S","S","H","H","H","H","H"},
            {"S","S","S","S","S","H","H","H","H","H"},
            {"S","S","S","S","S","S","S","S","S","S"},
            {"S","S","S","S","S","S","S","H","H","H"},
            {"H","H","H","H","H","H","H","H","H","H"},
            {"H","H","H","H","H","H","H","H","H","H"},
            {"H","H","H","H","H","H","H","H","H","H"},
            {"H","H","H","H","H","H","H","H","H","H"},
            {"H","H","H","H","H","H","H","H","H","H"}
        };
        static void MixDeck()
        {
            //int[] arr = new int[36];
            Random rnd = new Random();
            /*for (int i = 0; i < 36; i++)
            {
                arr[i] = i;
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("");*/
            for (int i = 0; i < 36; i++)
            {
                int tmp;
                Card buffer;
                tmp = rnd.Next(0, 35);
                if (i != tmp)
                {
                    buffer = Deck[i];
                    Deck[i] = Deck[tmp];
                    Deck[tmp] = buffer;
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
                    Deck[n].Suit = suitNameBasic[j];
                    Deck[n].RangName = rangeNameBasic[i];                  
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
            }

            Console.SetCursorPosition(x+1, y); Console.Write("______");
            for (int i = 1; i < 9; i++)
            {
                Console.SetCursorPosition(x+7, y+i); Console.Write("|");              
            }
            Console.SetCursorPosition(x+1, y+8); Console.Write("______");
        }

        static void Main(string[] args)
        {
            //SizeWindow();
            InitDeck();
            MixDeck();
            for (int i = 0; i < 36; i++)
            {
                Console.Write(Deck[i].RangName+" ");
                Console.Write(Deck[i].Suit+" ");
                Console.WriteLine("");
            }
            //Console.WriteLine((char)Value.Queen);
           // Console.WriteLine(Value.Ten.ToString("d"));
           // Console.WriteLine(Value.Seven.ToString("d"));
            Console.ReadLine();
            


        }
    }
}
