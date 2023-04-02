class Lectures : Events
{
    private string _speaker;
    private string _capacity;

    // Constructor
    public Lectures(string title, string desc, string date, string time, string speaker, string capacity) : base(title, desc, date, time)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // Method
    public string GetName()
    {
        return _speaker;
    }

    public string GetCap()
    {   
        return _capacity;
    }
}