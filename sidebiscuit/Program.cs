using System;

namespace The_Power_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string happyFunTime = "  Number| Square|  Cube |";
            double num1;

            Console.WriteLine("Learn you squares and cubes!\n\n");
            Console.Write("Please enter a integer greater than 0: ");
            string userNumber = Console.ReadLine();
            num1 = Convert.ToDouble(userNumber);
            PowerNumberTable(num1);
            CheckingNonZero(num1);
            Console.WriteLine(happyFunTime);
            Console.WriteLine("Do you want to enter another number?(y/n): ");
            Console.WriteLine("Do you want to enter another number?(y/n): ");
            string yesNo = Console.ReadLine().ToLower();

        }

    }
    public static double PowerNumberTable(double number)
    {
        string userNumber;
        double j;
        double k;
        for (int i = 1; i <= number; i++)
        {
            j = i * i;
            k = i * i * i;
            Console.WriteLine($"{i}\t|{j}\t|{k}\t|");
        }
        return number;

    }
    public static double CheckingNonZero(double num1)
    {

        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("That was invalid. Enter a number greater than Zero, Silly.");
        }
        return num1;
    }
    public static bool KeepGoing()
    {
        Console.WriteLine("Do you want to enter another number?(y/n): ");
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
    
