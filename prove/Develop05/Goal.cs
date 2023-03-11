class Goal
{
    private string _name;
    private string _description;
    private int _totalPoints = 0;
    

    // Constructor
    public Goal()
    {

    }
    public Goal(string name, string description)
    {
        _name = name;
        _description = description;
    }


    // Methods
    public string GetName()
    {
        return _name;
    }

    public string GetDesc()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _totalPoints;
    }


    // Virtuals
    public virtual void RecordEvent()
    {
        
    }

    public virtual bool GetComp()
    {
        return false;
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual int GetPnts()
    {
        return -1;
    }

    public virtual string GoalForm()
    {
        return "";
    }

    public virtual string ListForm()
    {
        return "";
    }
}
