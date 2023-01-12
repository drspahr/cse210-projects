using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();

        string usrName = PromptUserName();

        int usrNum = UserNumber();

        int sqNum = SquareNumber(usrNum);

        DisplayResult(usrName, sqNum);


        /* Functions that are called */
        static void DisplayWelcome()
        {
        Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int UserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int number)
        {
            int numSq = number * number;
            return numSq;
        }

        static void DisplayResult(string name, int num)
        {
            Console.WriteLine($"Brother {name}, the square of your number is {num}");
        }

    }
}