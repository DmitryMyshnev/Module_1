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
      static Card[] ComputersCard = new Card[10];
      static Card[] HumansCard = new Card[10];
        static int ComputerScore = 0;
        static int HumanScore = 0;
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
            Random rnd = new Random();         
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
        static void UpdateDisplay()
        {
            Console.SetCursorPosition(55, 0);
            Console.WriteLine("Black Jack");
            DrawCard(0, 9, 0, "Closed card");
        }
        static void SizeWindow()
        {
            Console.Clear();
            Console.SetWindowSize(120, 40);
            Console.BufferWidth = 120;
            Console.BufferHeight = 40;
        }
        static void DrawCard(int x, int y, int indexDeck,string cards)
        {
            Console.CursorVisible = false;
            
            if (cards == "Closed card")
            {
                for (int i = 1; i < 8; i++)
                {
                    Console.SetCursorPosition(x, y + i); Console.Write("|");
                }
                Console.SetCursorPosition(x + 1, y); Console.Write("_______");
                for (int i = 1; i < 8; i++)
                {
                    Console.SetCursorPosition(x + 8, y + i); Console.Write("|");
                }
                Console.SetCursorPosition(x + 1, y + 7); Console.Write("_______");
                for (int i = 1,k = 7; i < 8; i++,k--)
                {
                    Console.SetCursorPosition(x + i, y + i); Console.Write(@"\");
                    Console.SetCursorPosition(x + k, y + i); Console.Write(@"/");
                }              
                Console.SetCursorPosition(x + 4, y + 4); Console.Write("X");
            }
            else
                if (cards == "Open card")
                {
                    for (int i = 1, k = 7; i < 8; i++, k--)
                  {
                    Console.SetCursorPosition(x + i, y + i); Console.Write(" ");
                    Console.SetCursorPosition(x + k, y + i); Console.Write(" ");
                  }
                    for (int i = 1; i < 8; i++)
                  {
                      Console.SetCursorPosition(x, y + i); Console.Write("|");
                  }
                      Console.SetCursorPosition(x + 1, y); Console.Write("_______");
                    for (int i = 1; i < 8; i++)
                  {
                      Console.SetCursorPosition(x + 8, y + i); Console.Write("|");
                  }
                      Console.SetCursorPosition(x + 1, y + 7); Console.Write("_______");
                   
                      Console.SetCursorPosition(x + 1, y + 1);
                      Console.Write(Deck[indexDeck].RangName);
                      Console.SetCursorPosition(x + (Deck[indexDeck].RangName == "10" ? 6 : 7), y + 7); 
                      Console.Write(Deck[indexDeck].RangName);
                }
           
        }
        static void Ruls()
        {
            Console.SetCursorPosition(0, 33);
            Console.WriteLine("Button Control:");
            Console.WriteLine("");
            Console.WriteLine("Take a card:" +" t");
            Console.WriteLine("Skip a move:"+" s");
        }
        static void ClearArea(int posArea, int sizeArea)
        {
            Console.SetCursorPosition(0,posArea);
            for (int i = 0; i < Console.WindowWidth; i++)
                for(int j = 0;j < sizeArea; j++)             
                  Console.Write(" ");
            
        }
        static void StartGame(int selectPlayer)
        {
            ComputersCard[0] = Deck[0];
            ComputerScore += ComputersCard[0].Rang;
            DrawCard(20, 1,ComputersCard[0].Rang, "Closed card");

            ComputersCard[0] = Deck[1];
            ComputerScore += ComputersCard[1].Rang;
            DrawCard(29, 1, ComputersCard[1].Rang, "Closed card");

            HumansCard[0] = Deck[3];
            HumanScore += HumansCard[0].Rang;
            DrawCard(20, 17, ComputersCard[0].Rang, "Open card");

            HumansCard[1] = Deck[4];
            HumanScore += HumansCard[1].Rang;
            DrawCard(29, 17, ComputersCard[1].Rang, "Open card");
            Console.SetCursorPosition(1, 5);
            Console.WriteLine("PC Score: "+ComputerScore);
            Console.SetCursorPosition(1, 21);
            Console.WriteLine("Your Score: " + HumanScore);

        }
        static void Main(string[] args)
        {
            int selectPlayer=0;
            Random rndSelectPlayer = new Random();
             
            SizeWindow();
            UpdateDisplay();
            InitDeck();
            MixDeck();
                     
            Console.SetCursorPosition(0,27);
            Console.WriteLine("Press Enter to randomly select who starting to play.");
            Console.ReadLine();
            ClearArea(27, 1); 
            Console.SetCursorPosition(0, 27);
            selectPlayer = rndSelectPlayer.Next(0, 2);
            if(selectPlayer == 0)
                Console.Write("First step doing PC. ");
            else
                Console.Write("First step doing You. ");
            Console.WriteLine("Press Enter to starting to play. ");
            Ruls();
            Console.ReadLine();
            StartGame(selectPlayer);
            Console.ReadLine();
            //  Console.WriteLine((char)Value.Queen);
            //Console.WriteLine(Value.Ten.ToString("d"));
            // Console.WriteLine(Value.Seven.ToString("d"));           





        }
    }
}
