class Activity
{
    private string _actName;
    private string _description;
    private protected int _duration;

    // Constructor
    public Activity(string activity, string description, int duration)
    {
        _actName = activity;
        _description = description;
        _duration = duration;
    }

    // Methods
    public void DisplayStart()
    {
        Console.WriteLine($"Welcome to the {_actName} activity. This activity will help relax your mind.");
    }

    public void DisplayDesc()
    {
        Console.WriteLine(_description);
    }

    public void DisplayEnd()
    {
        Console.WriteLine($"You have completed another {_duration} seconds of the {_actName} activity!");
    }

    public void Pause()
    {
        Console.WriteLine("Get Ready.");
        char [] spinner = new char [] {'\\', '|', '/', '-'};

        Console.Write("-");
        int index = 0;
        
        for (int i = 0; i <= 40; i++)
        { 
            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write(spinner[index]);
            index ++;

            if (index == spinner.Count())
            {    
                index = 0;
            }
        }
        Console.Write("\b \b");
    }
}