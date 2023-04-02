class Receptions : Events
{
    private bool _register = false;

    // Constructor
    public Receptions(string title, string desc, string date, string time, bool register) : base(title, desc, date, time)
    {
        _register = register;
    }

    // Method
    public bool IsRegister()
    {
        bool reg;
        if (_register)
        {
            reg = _register;
            return  reg;
        }
        else
        {
            reg = false;
            return  reg;
        }
    }
}