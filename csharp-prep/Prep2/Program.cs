using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeFromUser = Console.ReadLine();

        float gradePercent = float.Parse(gradeFromUser);
        string letter;

        if (gradePercent >= 90)
        {
            /*Console.WriteLine("Your letter grade is: A");*/    // Core 1
            letter = "A";                                        // Core 3
        }
        else if (gradePercent < 90 && gradePercent >= 80)
        {
            /*Console.WriteLine("Your letter grade is: B");*/
            letter = "B";
        }
        else if (gradePercent < 80 && gradePercent >= 70)
        {
            /*Console.WriteLine("Your letter grade is: C");*/
            letter = "C";
        }
        else if (gradePercent < 70 && gradePercent >= 60)
        {
            /*Console.WriteLine("Your letter grade is: D");*/
            letter = "D";
        }
        else
        {
            /*Console.WriteLine("Your letter grade is: F");*/
            letter = "F";
        }

        float remainder = gradePercent % 10;                    // Stretch 1
        string sign;

        if (remainder > 7 && (letter != "A" && letter != "F"))                                                   // Stretch 1, Stretch 3 and Stretch 3
        {
            sign = "+";
        }
        else if (remainder < 3 && letter != "F")                // Stretch 3
        {
            sign = "-";
        }
        else
        {
            sign = " ";
        }

        Console.WriteLine($"Your letter grade is: {letter}{sign}");     // Core 3 and Stretch 1

        if (gradePercent >= 70)                                         // Core 2
        {
            Console.WriteLine("Congratulations! You have passed the course!");
        }
        else
        {
            Console.WriteLine("You did not pass. If you need help there is help available and continue to work hard. You can do it!");
        }
    }
}