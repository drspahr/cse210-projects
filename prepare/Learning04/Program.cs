using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Assignment assign = new Assignment("David Spahr", "Trig Functions");
        Console.WriteLine(assign.GetSummary());

        Console.WriteLine();
        MathAssign assing1 = new MathAssign("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(assing1.GetSummary());
        Console.WriteLine(assing1.GetHomeworkList());

        Console.WriteLine();
        WriteAssing wassign1 = new WriteAssing("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(wassign1.GetSummary());
        Console.WriteLine($"{wassign1.GetSummary()} by {wassign1.GetName()}\n");
    }
}