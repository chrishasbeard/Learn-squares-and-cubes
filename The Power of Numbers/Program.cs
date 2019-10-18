using System;

namespace The_Power_of_Numbers
{
    class Program
    {

        static void Main(string[] args)

        {
            string happyFunTime = "  Number| Square|  Cube |";                
            string userNumber = string.Empty;
            double num1;
               Console.WriteLine("Learn some squares and cubes!\n\n");


            do
            {

                Console.Write("Please enter a integer greater than 0: ");
                userNumber = Console.ReadLine();
                num1 = double.Parse(userNumber);
                Console.WriteLine(happyFunTime);
                PowerNumberTable(num1);
            }

            while (true);
            
        }
        public static double PowerNumberTable(double num1)
        {
            
            double j;
            double k;
            for (int i = 1; i <= num1; i++)
            {
                j = i * i;
                k = i * i * i;
                
                Console.WriteLine($"{i}\t|{j}\t|{k}\t|");
                
            }
            Console.WriteLine("Do you want to keep learning?: (y/n) ");
            KeepGoing();
            return num1;
        }
        public static double CheckingNonZero(double num1)
        {
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("That was invalid. Enter a number greater than Zero, Silly.");
            }
            return num1;
        }
        public static bool KeepGoing ()
        {
            
            string yesNo = Console.ReadLine().ToLower();
            switch (yesNo)
            {
                case "y":
                    yesNo = "y";
                    return true;
                case "n":
                    yesNo = "n";
                    return false;
                default:
                    return KeepGoing();
            }
        }
        //make a method to ensure a number was entered.
        //make a method to continue use a switch.
    }
}     