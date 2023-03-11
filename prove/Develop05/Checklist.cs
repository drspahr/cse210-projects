class Checklist : Goal
{
    private int _num = 0;
    private int _numComp = 0;
    private bool _complete = false;
    private int _pntPerCmp = 0;
    private int _bonus = 0;

    // Constructor
    public Checklist(string name, string description, int points, int num, int bonus) : base(name, description)
    {
        _pntPerCmp = points;
        _bonus = bonus;
        _num = num;
    }

    public Checklist(string name, string description, int points, int bonus, int numComp, int num, bool complete) : base(name, description)
    {
        _pntPerCmp = points;
        _bonus = bonus;
        _num = num;
        _numComp = numComp;
        _complete = complete;
    }

    // Methods
    public int NumComp()
    {
        return _numComp += 1;
    }

    public int GetBon()
    {
        return _bonus;
    }

    public int GetNum()
    {
        return _num;
    }

    public int GetNumCmp()
    {
        return _numComp;
    }

    // Overrides
    public override void RecordEvent()
    {
        NumComp();
        if (_numComp == _num)
        {
            IsComplete();
            _pntPerCmp += _bonus;
            Console.WriteLine("\nCongratulations!! You've completed the goal!");
            Console.ReadLine();
        }
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
        return _pntPerCmp;
    }

    public override string ListForm()
    {
        return $"{GetName()} ({GetDesc()}) -- Currently Completed: {GetNumCmp()}/{GetNum()}";
    }

    public override string GoalForm()
    {
        return $"{this.GetType().Name}|{GetName()}|{GetDesc()}|{GetPnts()}|{GetBon()}|{GetNumCmp()}|{GetNum()}|{GetComp()}";
    }
}