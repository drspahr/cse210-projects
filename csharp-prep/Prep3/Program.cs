using System;

class Program
{
    static void Main(string[] args)
    {
        string userNumber;
        int userNum;
        int number;
        string play = "yes";

        // Console.Write("What is the magic number? ");        // Core-1
        // userNumber = Console.ReadLine();                    // Core-1
        // number = int.Parse(userNumber);                     // Core-1
        while (play == "yes")                                  // Stretch-2 
            {
                int count = 0;                                 // Stretch-1

                Random randomGenerator = new Random();                 // Core-3
                number = randomGenerator.Next(1,100);
                
                do                                                  // Core-2 do/while statement
                {
                    Console.Write("What is your guess? ");
                    userNumber = Console.ReadLine();
                    userNum = int.Parse(userNumber);                // Can eliminate this line when using int.Parse(Console.Readline());

                    if (userNum == number)                          // Core-1
                    {
                        count += 1;
                        Console.WriteLine("Congratualtions, you have guessed the number!!");
                    }
                    else if (userNum < number)
                    {
                        count += 1;
                        Console.WriteLine("Higher");
                    }
                    else
                    {
                        count += 1;
                        Console.WriteLine("Lower");
                    }
                } while (userNum != number);

                Console.WriteLine($"You guessed {count} times.");

                Console.Write("Do you wish to play? ");
                play = Console.ReadLine();

                if (play == "no")
                {
                    Console.WriteLine("Thank you for playing!");
                }
            }
    }
}