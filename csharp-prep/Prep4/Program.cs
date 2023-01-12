using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();

        float userNum = -1;
        float total = 0;
        float ttlCount = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        
        while (userNum != 0)
        {
            Console.Write("Enter number: ");
            userNum = float.Parse(Console.ReadLine());

            if (userNum != 0)
            {
                numbers.Add(userNum);
            }
        }

        foreach (int number in numbers)                 // Core-1
        {
            total += number;
            ttlCount += 1;
        }

        float average = total / ttlCount;               // Core-2
        float max = numbers[0];
        float min = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)                           // Core-3
            {
                max = number;
            }
            else if (number < max && number > 0)        // Stretch-1
            {
                min = number;
            }
        }

        numbers.Sort();

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {min}");
        Console.WriteLine("The sorted list is:");

        foreach (int number in numbers)                     // Stretch-2
        {
            Console.WriteLine(number);
        }

    }
}