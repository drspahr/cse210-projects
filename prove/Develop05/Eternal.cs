class Eternal : Goal
{
    private int _pntPerCmp = 0;
    private int _timesComp = 0;

    // Constructor
    public Eternal(string name, string description, int points) : base(name, description)
    {
        _pntPerCmp = points;
    }

    public Eternal(string name, string description, int points, int time) : base(name, description)
    {
        _pntPerCmp = points;
        _timesComp = time;
    }

    // Methods
    public int GetTimeCmp()
    {
        return _timesComp;
    }
    // Overrides
    public override void RecordEvent()
    {
        _timesComp += 1;

        if (_timesComp == 10)
        {
            _pntPerCmp *= 2;
            Console.WriteLine($"\nCongratuations!! You are a Tier 2 earner will earn {_pntPerCmp} each time you complete this goal!");
            Console.ReadLine();
        }
        else if (_timesComp == 50)
        {
            _pntPerCmp *= 2;
            Console.WriteLine($"\nCongratualations!! You are a Tier 2 earner and will earn {_pntPerCmp} each tme you complete this goal!");
            Console.ReadLine();
        }
        else if (_timesComp == 100)
        {
            _pntPerCmp *= 5;
            Console.WriteLine($"\nCongratulations!! You ware a Tier 3 earner and will earn the maximum of {_pntPerCmp} each time you complete this goal.");
            Console.ReadLine();
        }
    }

    public override int GetPnts()
    {
        return _pntPerCmp;
    }

    public override bool GetComp()
    {
        return base.GetComp();
    }

    public override bool IsComplete()
    {
        return base.IsComplete();
    }

    public override string ListForm()
    {
        return $"{GetName()} ({GetDesc()}) -- Have completed {GetTimeCmp()} times";
    }

    public override string GoalForm()
    {
        return $"{this.GetType().Name}|{GetName()}|{GetDesc()}|{GetPnts()}|{GetTimeCmp()}";
    }
}