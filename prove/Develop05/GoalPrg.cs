using System;
using System.IO;

public class EternalGoals
{
    private int _totalPoints = 0;
    private int _mainSel = 0;
    private List<Goal> _goals = new List<Goal>();

    public void RunPrg()
    {
        do
        {
            switch (_mainSel = MainMenu())
            {
                case 1: CreateGoal(); break;
                case 2: ListGoals(); break;
                case 3: SaveFile(); break;
                case 4: LoadFile(); break;
                case 5: RecordGoalEvent(); break;
                case 6: ExitPrg(); break;
                default: Console.WriteLine("Invalid Choice, Please select 1-6. "); break;
            }
        } while (_mainSel != 6);
    }

    private int MainMenu()  // The main menu to select the action to take
    {
        Console.Clear();
        Console.WriteLine("      Goal Tracker\n");
        Console.WriteLine($"   You have {_totalPoints} points\n");
        Console.WriteLine("         Main Menu\n");

        Console.WriteLine("     1. Create Goal");
        Console.WriteLine("     2. List Goals");
        Console.WriteLine("     3. Save Goals");
        Console.WriteLine("     4. Load Goals");
        Console.WriteLine("     5. Record Event");
        Console.WriteLine("     6. Exit Program");

        Console.Write("\nWhat would you like to do? --> ");
        int usrSel = int.Parse(Console.ReadLine());
        return usrSel;
    }

    private void CreateGoal()  // The menu to select which goal to create
    {
        Console.Clear();
        Console.WriteLine("       Create a Goal\n");

        Console.WriteLine("     1. Simple Goal");
        Console.WriteLine("     2. Enternal Goal");
        Console.WriteLine("     3. Checklist Goal");
        Console.WriteLine("     4. Return");

        Console.Write("\nWhat goal would you like to create? --> ");
        int goalSel = int.Parse(Console.ReadLine());      

        Console.Write("\nWhat is the name of the goal? --> ");
        string name = Console.ReadLine();

        Console.Write("Provide short description of goal. --> ");
        string desc = Console.ReadLine();

        Console.Write("How many points is this goal worth? --> ");
        int points = int.Parse(Console.ReadLine());

        switch (goalSel)
        {
            case 1: Simple sim = new Simple(name, desc, points);
                    _goals.Add(sim); break;
            case 2: Eternal etn = new Eternal(name, desc, points);
                    _goals.Add(etn); break;
            case 3: Console.Write("Number of times goal needs to be completed to receive bonus? --> ");
                    int num = int.Parse(Console.ReadLine());
                    Console.Write("How many bouns points upon completion? --> ");
                    int bonus = int.Parse(Console.ReadLine());
                    Checklist chk = new Checklist(name, desc, points, num, bonus);
                    _goals.Add(chk); break;
        }
        Console.ReadLine();
    }

    private void ListGoals()
    {
        int index = 1;
        string cmp;
        Console.Clear();
        Console.WriteLine("Your goals are:");
        foreach (Goal goal in _goals)
        {
            if (goal.GetComp() == false)
            {
                cmp = " ";
            }
            else
            {
                cmp = "X";
            }
            
            Console.WriteLine($"{index}. [{cmp}] {goal.ListForm()}");
            index += 1;
        }
        Console.ReadLine();
    }

    private void SaveFile()
    {
        Console.Clear();
        Console.Write("What file do you want to save your goals to? --> ");
        string fileName = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(fileName))
        {
            output.WriteLine(_totalPoints);
            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GoalForm());
            }
        }
    }

    private void LoadFile()
    {
        Console.Write("Please enter your filename to be loaded. --> ");
        string fileName = Console.ReadLine();

        _goals.Clear();

        string [] lines = File.ReadAllLines(fileName);
        _totalPoints = int.Parse(lines[0]);

        foreach (string line in lines.Skip(1))
        {
            string [] parts = line.Split("|");
            switch (parts[0])
            {
                case "Simple": Simple sim = new Simple(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                               _goals.Add(sim); break;
                case "Eternal": Eternal etn = new Eternal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]));
                                _goals.Add(etn); break;
                case "Checklist": Checklist chk = new Checklist(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), bool.Parse(parts[7]));
                                  _goals.Add(chk); break;
            }
        }
    }

    private void RecordGoalEvent()
    {
        List<Goal> list = new List<Goal>();
        int index = 1;

        Console.Clear();
        Console.WriteLine("Your Uncompleted Goals Are: ");

        foreach (Goal goal in _goals)
        {
            if (goal.GetComp() == false)
            {
                list.Add(goal);
                Console.WriteLine($"{index}. {goal.GetName()}");
                index += 1;
            }
        }

        Console.Write("Which goal do you what to update? --> ");
        int updtSel = int.Parse(Console.ReadLine()) - 1;

        switch (list[updtSel].GetType().Name)
        {
            case "Simple": list[updtSel].RecordEvent();
                           _totalPoints += list[updtSel].GetPnts(); break;
            case "Eternal": list[updtSel].RecordEvent(); 
                            _totalPoints += list[updtSel].GetPnts(); break;
            case "Checklist": list[updtSel].RecordEvent();
                              _totalPoints += list[updtSel].GetPnts(); break;
        }
    }

    private void ExitPrg()
    {
        Console.WriteLine("\nThank you for using Goal Tracker!\n");
        Environment.Exit(0);
    }
}