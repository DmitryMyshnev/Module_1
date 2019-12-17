using System;

namespace BaseControl1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText;
            string longestName = "";
            int sizeOfArrey = 0;
            int aLotOfPeple = 0;
            int indexMostPopuplar = 0;
            string[] tempPars;

            char[] simbolParsOfSity = new char[] { ';', ',', '=' };
            Console.WriteLine("Enter Text.");
            inputText = Console.ReadLine();
            tempPars = inputText.Split(simbolParsOfSity);
            sizeOfArrey = tempPars.Length / 3;
            double[] density = new double[sizeOfArrey];
            string[] city = new string[sizeOfArrey];
            string[] square = new string[sizeOfArrey];
            string[] people = new string[sizeOfArrey];

            for (int i = 0, j = 0, k = 0; i < sizeOfArrey; i++, j++, k++)
            {
                city[i] = tempPars[i * 3];
                people[k] = tempPars[k * 3 + 1];
                square[j] = tempPars[j * 3 + 2];          
            }

            for (int i = 0; i < sizeOfArrey; i++)
            {
                if (int.Parse(people[i]) > aLotOfPeple)
                    aLotOfPeple = int.Parse(people[i]);
            }

            for (int i = 0; i < sizeOfArrey; i++)
            {
                if (int.Parse(people[i]) == aLotOfPeple)
                    indexMostPopuplar = i;
            }

            for (int i = 0; i < sizeOfArrey; i++)
            {           
                if (city[i].Length > longestName.Length)               
                    longestName = city[i];                             
            }

            for (int i = 0; i < sizeOfArrey; i++)
            {
                double pip = int.Parse(people[i]);
                double sq = int.Parse(square[i]);
                density[i] = pip / sq;
            }
            Console.WriteLine("");
            Console.WriteLine("Most populated: " + city[indexMostPopuplar]+" ({0} people)",people[indexMostPopuplar]);
            Console.WriteLine("Longest name:   " + longestName + " ({0} letters)",longestName.Length);
            Console.WriteLine("Density:");
            for (int i = 0; i < sizeOfArrey; i++)
            {
                Console.Write("        {0}", city[i]);
                Console.SetCursorPosition(longestName.Length + 10,i+6);
                Console.WriteLine("  {0:0.00}", density[i]);
            }
            
        }
    }
}
