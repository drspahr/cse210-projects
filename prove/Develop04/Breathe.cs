class Breathe : Activity
{
    private int _breathein;
    private int _breatheout;

    //Constructor
    public Breathe(string activity, string description, int duration) : base(activity, description, duration)
    {
        _breathein = 8;
        _breatheout = 8;
    }

    // Methods
    public void DisplayBreathe()
    {
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            InTime(_breathein, "in");
            InTime(_breatheout, "out");
            Console.WriteLine();
            
        } 
    }

    public void InTime(int breath, string dir)
    {
        if (dir == "in" || dir == "out")
        {
            for (int i = breath; i >= 0; i--)
            {
                Console.Write("\r");
                Console.Write($"Breath {dir}... "+"{0} {1}", i, i == 0 ? "\n": "");
                Thread.Sleep(1000);
            }
        }
    }
}