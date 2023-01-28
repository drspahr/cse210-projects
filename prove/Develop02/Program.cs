 using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--------------------JOURNAL APPLICATION--------------------");
        // Variable declarations
        int usrSel = -1;

        // Object declarations
        Journal jnl = new Journal();
        Entry entry = new Entry();
        Prompt prm = new Prompt();

        // Welcome message
        Console.WriteLine("Welcome to the Daily Journal!");

        // do-while menu selection. Program will end when "5" selected
        do
        {
            usrSel = Menu();

            // Test user selection and call the function selected.
            switch (usrSel)
            {
                case 1: GetEntry(entry, jnl, prm); break;
                case 2: DisplayEntries(jnl); break;
                case 3: // TO DO: LoadFile();
                    break;
                case 4: // TO DO: SaveFile();
                    break;
                case 5: // TO DO: Exit;
                    break;
                default: Console.WriteLine("Invalid Choice, Please select 1-5");
                    break;
            }
        } while (usrSel != 5);
    }

    //Functions
    //Menu function to display the options for user to select.
    static int Menu()
    {
        // Variable Declaration
        int choice = -1;

        // Display statement(s), menu, and ask for choice
        Console.WriteLine("Please select from the following:");
        Console.WriteLine();

        Console.WriteLine("1. Write new entry");
        Console.WriteLine("2. Display Journal Entries");
        Console.WriteLine("3. Load Journal File");
        Console.WriteLine("4. Save Journal File");
        Console.WriteLine("5. Exit");

        Console.WriteLine();
        Console.Write("Enter Choice: ");
        choice = int.Parse(Console.ReadLine());

        return choice;
    }


    static void GetEntry(Entry entry, Journal jnl, Prompt prm)
    {
        //Variable
        int ind = 0;

        //Get index for random question
        ind = prm.RndQstIndex(ind);
        entry.PromptQuestion = prm.Questions[ind];

        // //Get User response
        Console.WriteLine(entry.PromptQuestion);
        Console.Write(">");
        entry.UserResponse = Console.ReadLine();

        // //Get current day
        entry.CurDay = DateTime.Now.ToShortTimeString();
        //entry.UserEntry();
        jnl.jnlEntries.Add(entry);
        //jnl.ListAdd(entry);
    }


   static void DisplayEntries(Journal jnl)
    {
        jnl.DisplayEntries();
        Console.ReadKey();
    }
}