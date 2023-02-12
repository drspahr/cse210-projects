using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare scripture object
        Scripture newScrip = new Scripture();

        // Declare variable to capture user input
        string userSel = "";

        /* Loop that displays that clears the console. Displays scripture reference and verse. Gets the user input
           and test for "quit" or enter.*/
        do
        {
            Console.Clear();
            newScrip.DisplayScript();
            Console.Write("\nPlease press 'Enter' to continue or type 'quit'. ");
            userSel = Console.ReadLine();

            if (userSel != "quit")
            {
                newScrip.HideWord();
            }
        } while (userSel != "quit");
    }
}