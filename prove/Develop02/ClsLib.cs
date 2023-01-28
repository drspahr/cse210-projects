using System;

public class Entry
{
    // Field Declaration
    public string UserResponse;
    public string PromptQuestion;
    public string CurDay;

       // Constructor
    public Entry()
    {

    }
}

//----------------------------------------------------------------------------------------------------------

// Class for prompts
public class Prompt
{
    // Field Declaration
    public List<string> Questions = new List<string>();

    // Constructor
    public Prompt()
    {
        Questions.Add("Who was the most interesting person I interacted with today?");
        Questions.Add("What was the best part of my day?");
        Questions.Add("How did I see the hand of the Lord in my life today?");
        Questions.Add("What was the strongest emotion I felt today?");
        Questions.Add("If I had one thing I could do over today, what would it be?");
        Questions.Add("Who did I serve today?");
        Questions.Add("If I was unable to overcome a weakness today, what I have I done to ensure I overcome it tomorrow?");
        Questions.Add("Was I a respector of person today?");
        Questions.Add("What brought me the most joy today?");
        Questions.Add("What scripture did I read for today?");
        Questions.Add("Am I worthy to enter the temple?");
    }

    // Methods
    // Method to determine the index for choosing random question
    public int RndQstIndex(int index)
    {
        Random rnd = new Random();
        index = rnd.Next(0, Questions.Count);

        return index;
    }
}

//----------------------------------------------------------------------------------------------------------

public class Journal
{
    public List<Entry> jnlEntries = new List<Entry>();

    // Constructor
    public Journal()
    {
        
    }

    // Method
    public void ListAdd(string fileName)
    { 
        jnlEntries.Clear();

        string [] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Entry jnlEnt = new Entry();
            string [] parts = line.Split("|");

            jnlEnt.CurDay = parts[0];
            jnlEnt.PromptQuestion = parts[1];
            jnlEnt.UserResponse = parts[2];

            jnlEntries.Add(jnlEnt);
        }
    }

    public void DisplayEntries()
    {   
        Console.Clear();
        Console.WriteLine("\n**********************************************ENTRIES*********************************************************************\n");
        foreach (Entry entry in jnlEntries)
        {
            Console.WriteLine($"Date: {entry.CurDay} - Prompt: {entry.PromptQuestion}");
            Console.WriteLine($"{entry.UserResponse}");
            Console.WriteLine();
        }
        Console.WriteLine("**************************************************************************************************************************");
        Console.WriteLine($"There are {jnlEntries.Count} entries");
        Console.Write("Press Any Key to Continue ");
        Console.ReadKey();
    }


    public void WriteFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in jnlEntries)
            {
                 outputFile.WriteLine($"{entry.CurDay}|{entry.PromptQuestion}|{entry.UserResponse}");
            }
        }        
        
    }
}
