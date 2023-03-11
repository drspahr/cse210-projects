class Simple : Goal
{
    private bool _complete = false;
    private int _pnts = 0;

    //Constructor
    public Simple(string name, string description, int points) : base(name, description)
    {
        _pnts = points;
    }

    public Simple(string name, string description, int points, bool complete) : base(name, description)
    {
        _pnts = points;
        _complete = complete;
    }

    // Methods
    
    // Overrides
    public override void RecordEvent()
    {
        IsComplete();
        Console.WriteLine("\nCongratulations!! You've completed the goal!");
        Console.ReadLine();
    }

    public override bool GetComp()
    {
        return _complete;
    }

    public override bool IsComplete()
    {
       return _complete = true;
    }

    public override int GetPnts()
    {
      return _pnts;
    }

    public override string ListForm()
    {
        return $"{GetName()} ({GetDesc()})";
    }

    public override string GoalForm()
    {
        return $"{this.GetType().Name}|{GetName()}|{GetDesc()}|{GetPnts()}|{GetComp()}";
    }
}