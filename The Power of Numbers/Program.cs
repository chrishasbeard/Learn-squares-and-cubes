using System;

namespace The_Power_of_Numbers
{
    class Program
    {

        static void Main(string[] args)
        
        {
            string happyFunTime = "  Number| Square|  Cube |";
            string userNumber = string.Empty;
            Console.WriteLine("Learn you squares and cubes!\n\n");
            Console.Write("Please enter a integer greater than 0: ");
            userNumber = Console.ReadLine();
            double num1 = double.Parse(userNumber);
            Console.WriteLine(happyFunTime);
            PowerNumberTable(num1);
            
        }
        public static double PowerNumberTable(double number)
        {
            
            double j;
            double k;
            for (int i = 1; i <= number; i++)
            {
               
                i = i;
                j = i * i;
                k = i * i * i;
                
                Console.WriteLine($"{i}\t|{j}\t|{k}\t|");
            }
            return number;
        }
        //make a method to ensure a number was entered.
        //make a method to continue use a switch.
    }
}     