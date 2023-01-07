using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string f_nam = Console.ReadLine();

        Console.Write("What is your last name? ");
        string l_nam = Console.ReadLine();

        Console.WriteLine($"Your name is {l_nam}, {f_nam} {l_nam}.");

    }
}