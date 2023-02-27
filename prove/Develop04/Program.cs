using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        int menuSel = -1;

        Console.WriteLine("Welcome to Mind Relaxation");

        do
        {
            menuSel = Menu();

            switch (menuSel)
            {
                case 1: Breathe(); break;
                case 2: ReflectAct(); break;
                case 3: Listing(); break;
                case 4: System.Environment.Exit(0); break;
                default: Console.WriteLine("Invalid Choice, Please select 1-5"); break;
            }

        } while (menuSel != 4);
    }

    // Functions
     static int Menu()
    {
        Console.WriteLine("\n::::::::::MAIN MENU::::::::::\n");
        int choice = -1;

        Console.WriteLine("Please Select an Activity\n");

        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");
        Console.WriteLine(":::::::::::::::::::::::::::::");

        Console.WriteLine();
        Console.Write("Which activity would you like to do? ");
        choice = int.Parse(Console.ReadLine());

        return choice;
    }

    static void Breathe()
    {
        string name = "Breathe";
        string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        Console.Write("How long would you like do this activity? ");
        int duration = int.Parse(Console.ReadLine());

        Breathe breath = new Breathe(name, description, duration);
        breath.DisplayStart();
        breath.DisplayDesc();
        breath.Pause();
        breath.DisplayBreathe();
        breath.DisplayEnd();
        breath.Pause();
        Console.Clear();
    }

    static void ReflectAct()
    {
        string name = "Reflect";
        string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        Console.Write("How long would you like do this activity? ");
        int duration = int.Parse(Console.ReadLine());

        Relfect reflect = new Relfect(name, description, duration);
        reflect.DisplayStart();
        reflect.DisplayDesc();
        reflect.Pause();
        reflect.DisplayRefPrompt();
        reflect.DisplayRefQuestion();
        reflect.DisplayEnd();
        reflect.Pause();
        Console.Clear();
    }

    static void Listing()
    {
        string name = "Listing";
        string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        Console.Write("How long would you like do this activity? ");
        int duration = int.Parse(Console.ReadLine());

        Listing listing = new Listing(name, description, duration);
        listing.DisplayStart();
        listing.DisplayDesc();
        listing.DisplayListPrompt();
        listing.Pause();
        listing.GetUser();
        listing.DisplayCount();
        listing.Pause();
        Console.Clear();
    }
}