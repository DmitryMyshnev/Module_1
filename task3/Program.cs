using System;

namespace task3
{
    class Program
    {
        /*
           Название цифр. Пользователь вводит число. Нужно вывести название всех цифр в нем.
        */
        static void Main(string[] args)
        {
            string[] nameArray = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", };
            int inputData,sizeArrey=0, temp;
                                    
            Console.WriteLine("Enter number:");   
             inputData = int.Parse(Console.ReadLine());
            temp = inputData;
            while (temp != 0)
            {   
                temp /=10;
                sizeArrey++;
            }
            
            int[] numberArrey = new int[sizeArrey];
            int i=0;
            temp = inputData;
            
            while (temp != 0)
            { 
                i++;
                numberArrey[sizeArrey - i] = temp % 10;
                temp /= 10;                                           
            }
            
             for (int n = 0; n < sizeArrey; n++)
             {
                Console.WriteLine(nameArray[numberArrey[n]]);                
             }

        }
    }
}
