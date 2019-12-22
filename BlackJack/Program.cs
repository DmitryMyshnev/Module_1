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
        static Card[] Deck = new Card[36];
        static Card[] ComputersCard = new Card[10];
        static Card[] HumansCard = new Card[10];
        static int computerScore = 0;
        static int humanScore = 0;
        static int quanityCardHuman = 0;
        static int quanityCardComputer = 0;
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
        static int resultComputer = 0;
        static int resultHuman = 0;
        static string[] suitNameBasic = new string[4] { "Diamonds", "Hearts", "Spades", "Clubs" };
        static string[] rangeNameBasic = new string[9] { "6", "7", "8", "9", "10", "J", "Q", "K", "A", };
        static int[,] strategy = new int[16, 10]
          {
            {1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
            {1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 },
            {1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 },
            {1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 },
            {1 ,1 ,1 ,0 ,0 ,1 ,1 ,1 ,1 ,1 },
            {1 ,0 ,0 ,0 ,0 ,1 ,1 ,1 ,1 ,1 },
            {1 ,0 ,0 ,0 ,0 ,1 ,1 ,1 ,1 ,1 },
            {0 ,0 ,0 ,0 ,0 ,1 ,1 ,1 ,1 ,1 },
            {0 ,0 ,0 ,0 ,0 ,1 ,1 ,1 ,1 ,1 },
            {0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 },
            {0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,1 },
            {1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 },
            {1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 },
            {1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 },
            {1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 },
            {1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 }


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
            int n = 0;
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
            DrawCard(0, 9, "", "Closed card");
        }
        static void SizeWindow()
        {
            Console.Clear();
            Console.SetWindowSize(120, 40);
            Console.BufferWidth = 120;
            Console.BufferHeight = 40;
        }
        static void DrawCard(int x, int y, string rangName, string cards)
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
                for (int i = 1, k = 7; i < 8; i++, k--)
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
                Console.Write(rangName);
                Console.SetCursorPosition(x + (rangName == "10" ? 6 : 7), y + 7);
                Console.Write(rangName);
            }

        }
 
        static void ClearArea(int posArea, int sizeArea)
        {
            Console.SetCursorPosition(0, posArea);
            for (int i = 0; i < Console.WindowWidth; i++)
                for (int j = 0; j < sizeArea; j++)
                    Console.Write(" ");

        }
        static void WritePoint(string who, int point)
        {
            switch(who)
                {
                case "pc":  Console.SetCursorPosition(1, 5);
                            Console.WriteLine("PC Score: " + point);
                    break;
                case "human":
                            Console.SetCursorPosition(1, 21);
                            Console.WriteLine("Your Score: " + point);
                    break;
                } 
        }
        static int ComputerMove()
        {
            
            if (computerScore == 21)
                return 0;

            if (ComputersCard[0].Rang == 11 && ComputersCard[1].Rang == 11)
                return -1;

            if (computerScore < 8)
                return 1;
            
                if (computerScore > 21)
                return 0;
            else
                return strategy[computerScore-8, quanityCardHuman - 2];
            
        }
        static int HumanMove()
        {
            
            string answerHuman;
            if (humanScore == 21)
                return 0;

            if (HumansCard[0].Rang == 11 && HumansCard[1].Rang == 11)
                return 1;

            if (humanScore > 21)
                return 0;

            Console.CursorVisible = true;
            do
            {
               
                Console.SetCursorPosition(0, 27);
                Console.Write("Make your chuise: ");
                int row = Console.CursorLeft;
                int col = Console.CursorTop;
                Console.SetCursorPosition(row, col);
                answerHuman = Console.ReadLine();
                Console.SetCursorPosition(row, col);
                Console.Write(" ");
            }
            while (answerHuman != "t" && answerHuman != "s");
                        
            if (answerHuman == "t")
            {
                return 1;
            }
            else
                return 0;  
            
        }
        static void StartGame(int selectPlayer)
        {
            bool notFinishGame = true;
            int twoAce = 0;
            ClearArea(27, 1);
            for (int i = 0; i < 2; i++)
            {
                ComputersCard[quanityCardComputer] = Deck[i];
                //computerScore = 15;
                computerScore += ComputersCard[quanityCardComputer].Rang;
                DrawCard(i == 0 ? 20 : 29, 1, ComputersCard[quanityCardComputer].RangName, "Closed card");
                quanityCardComputer++;
            }

            for (int i = 2; i < 4; i++)
            {
                HumansCard[quanityCardHuman] = Deck[i];
                //humanScore = 13;
                humanScore += HumansCard[quanityCardHuman].Rang;
                DrawCard(i == 2 ? 20 : 29, 17, HumansCard[quanityCardHuman].RangName, "Open card");
                quanityCardHuman++;
            }
            //WritePoint("pc", computerScore);
            WritePoint("human", humanScore);
            int stepsOfGame = 0;
            while (notFinishGame)
            {
                if (selectPlayer == 0 && stepsOfGame != 2)
                {
                    switch (ComputerMove())
                    {
                        case 1:
                            ComputersCard[quanityCardComputer] = Deck[quanityCardComputer + quanityCardHuman];
                            computerScore += ComputersCard[quanityCardComputer].Rang;
                            DrawCard(20 + 9 * quanityCardComputer, 1, ComputersCard[quanityCardComputer].RangName, "Closed card");
                            quanityCardComputer++;
                            //WritePoint("pc", computerScore);
                            ComputerMove();
                            break;                      
                        case 0:
                            selectPlayer = 1;
                            stepsOfGame++;
                            break;
                        case -1:
                            twoAce |= 1;
                            break;
                    }

                }
                if (selectPlayer == 1 && stepsOfGame != 2)
                {
                    switch (HumanMove())
                    {
                        case 1:
                            HumansCard[quanityCardHuman] = Deck[quanityCardHuman + quanityCardComputer];
                            humanScore += HumansCard[quanityCardHuman].Rang;
                            DrawCard(20 + 9 * quanityCardHuman, 17, HumansCard[quanityCardHuman].RangName, "Open card");
                            quanityCardHuman++;
                            WritePoint("human", humanScore);
                           
                            break;
                        case 0:
                            selectPlayer = 0;
                            stepsOfGame++;
                            break;
                        case -1:
                            twoAce |= 1 << 1;
                            break;
                    }

                }
                if (stepsOfGame == 2)
                    notFinishGame = false;
            }
            int winOrLose = 0;
                       
                if (humanScore >= 22 && computerScore <= 20) winOrLose = -1;
                   
                if (computerScore >= 22 && humanScore <= 20) winOrLose = 1;
                   
                if ((computerScore >= 22 && humanScore > 22) || (computerScore > 22 && humanScore >= 22))
                    if (computerScore > humanScore) winOrLose = 1;                       
                    else
                        winOrLose = -1;

                 if (computerScore <= 20 && humanScore <= 20)
                   if (computerScore < humanScore) winOrLose = 1;                    
                     else
                    winOrLose = -1;

                if (computerScore == 21 && humanScore != 21) winOrLose = -1;

                if (computerScore != 21 && humanScore == 21) winOrLose = 1;

                if ((computerScore == humanScore) || twoAce == 3) winOrLose = 0;

                if (twoAce == 1) winOrLose = -1;
                  
                if (twoAce == 2) winOrLose = 1;
                   
                if (computerScore == 21 && humanScore == 21) winOrLose = 0;
                                 
                switch(winOrLose)
                {
                    case 1:
                       if (humanScore < 22)
                            resultHuman += humanScore;
                       else
                            resultHuman =+ 21;
                       if (computerScore < 22)
                            resultComputer += computerScore;
                       else
                        resultComputer += 21;
                        WritePoint("pc", computerScore);
                        Console.SetCursorPosition(50, 28);
                        Console.WriteLine("YOU WIN!!!");                       
                        break;
                    case -1:
                        if (computerScore < 22)
                            resultComputer += computerScore;
                        else
                             resultComputer += 21;
                        if (humanScore < 22)
                             resultHuman += humanScore;
                        else
                             resultHuman = +21;
                        WritePoint("pc", computerScore);
                        Console.SetCursorPosition(50, 28);
                        Console.WriteLine("YOU LOSE.");
                        break;
                    case 0:
                         WritePoint("pc", computerScore);
                        Console.SetCursorPosition(50, 28);
                        Console.WriteLine("DRAW.");
                        break;
                        
                }
            ClearArea(27, 1);      
            
        }
         static void Main(string[] args)
        {
            int selectPlayer=0;
            string answerNewGame;
            string[] newGame = new string[1];
            Random rndSelectPlayer = new Random();

            computerScore = 0;
            humanScore = 0;
            quanityCardComputer = 0;
            quanityCardHuman = 0;

            SizeWindow();
            UpdateDisplay();
            InitDeck();
            MixDeck();
                     
            Console.SetCursorPosition(0,27);
            Console.WriteLine("Press Enter to select who starts play randomly.");
            Console.ReadLine();
            ClearArea(27, 1); 
            Console.SetCursorPosition(0, 27);
            selectPlayer = rndSelectPlayer.Next(0, 2);
            if(selectPlayer == 0)
                Console.Write("PC does the first step. ");
            else
                Console.Write("You do the first step. ");
            Console.WriteLine("Press Enter to start play. ");
            Console.SetCursorPosition(0, 33);
            Console.WriteLine("Button Control:");
            Console.WriteLine("");
            Console.WriteLine("Take a card:" + " t");
            Console.WriteLine("Skip a move:" + " s");
            Console.ReadLine();
            StartGame(selectPlayer);
            Console.SetCursorPosition(37, 29);
            Console.Write(@"Do you want to start new game? Yes\No  ");
            int row = Console.CursorLeft;
            int col = Console.CursorTop;
            do
            {                
                Console.SetCursorPosition(row, col);
                answerNewGame = Console.ReadLine();
                Console.SetCursorPosition(row, col);
                Console.Write("   ");
            }
            while (answerNewGame == "");
            
            answerNewGame = answerNewGame.ToUpper();


            if (answerNewGame == "YES")         
                Main(newGame);           
            else
            {
                ClearArea(28, 2);
                Console.SetCursorPosition(40,27);
                Console.Write("PC Score:   "+resultComputer);
                Console.SetCursorPosition(40, 28);
                Console.WriteLine("Your Score: " + resultHuman);
            }
            Console.ReadLine();
            Console.Clear();
                      
        }
    }
}
