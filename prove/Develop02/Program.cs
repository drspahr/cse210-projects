 using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // Variable declarations
        int usrSel = -1;
        
        // Object declarations
        Journal jnl = new Journal();
        Prompt prm = new Prompt();

        // Welcome message
        Console.WriteLine("    Welcome to the Daily Journal!");

        // do-while menu selection. Program will end when "5" selected
        do
        {
            usrSel = Menu();

            // Test user selection and call the function selected.
            switch (usrSel)
            {
                case 1: GetEntry(jnl, prm); break;
                case 2: DisplayEntries(jnl); break;
                case 3: LoadFile(jnl); break;
                case 4: SaveFile(jnl); break;
                case 5: System.Environment.Exit(0); break;
                default: Console.WriteLine("Invalid Choice, Please select 1-5");
                    break;
            }
        } while (usrSel != 5);
    }

    //Functions
    //Menu function to display the options for user to select.
    static int Menu()
    {
        Console.WriteLine("\n---------JOURNAL APPLICATION-------");
        Console.WriteLine("               Main Menu          ");
        Console.WriteLine();
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
        Console.WriteLine("---------------------------------------");

        Console.WriteLine();
        Console.Write("Enter Choice: ");
        choice = int.Parse(Console.ReadLine());

        return choice;
    }

    // Function to get the random question, user response, and current day and load jnlEntries
    static void GetEntry(Journal jnl, Prompt prm)
    {
        //Variable and object
        Entry entry = new Entry();
        int ind = 0;

        //Get index for random question
        ind = prm.RndQstIndex(ind);
        entry.PromptQuestion = prm.Questions[ind];

        // //Get User response
        Console.WriteLine(entry.PromptQuestion);
        Console.Write(">");
        entry.UserResponse = Console.ReadLine();

        // Get current day
        entry.CurDay = DateTime.Now.ToShortDateString();
        
        // Add to jnlEntries
        jnl.jnlEntries.Add(entry);
        Console.Clear();
    }

    // Function to display the entries in jnlEntries
    static void DisplayEntries(Journal jnl)
    {
        jnl.DisplayEntries();
        Console.Clear();
    }

    // Function to save the entries in jnlEntries to a file of the user's chooseing.
    static void SaveFile(Journal jnl)
    {        
        // Get a filename from the user
        Console.WriteLine("Please Enter a filename (ie: journal.txt): ");
        string fileName = Console.ReadLine();

        jnl.WriteFile(fileName);
        Console.Clear();
    }

    // Function to load jnlEntries from a file of the user's choosing
    static void LoadFile(Journal jnl)
    {
        // Get filename from user
        Console.WriteLine("Please Enter file name to be loaded (ie: journal.txt): ");
        string fileName = Console.ReadLine();

        jnl.ListAdd(fileName);
        Console.Clear();
    }
}