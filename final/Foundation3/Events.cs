class Events
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;

    // Constructor
    public Events()
    {

    }
    public Events(string title, string desc, string date, string time)
    {
        _title = title;
        _description = desc;
        _date = date;
        _time = time;
    }

    // Method
    public void Messages()
    {

    }

    public void DisplayEvent()
    {
        
    }

    public void SetAddress()
    {
        Address evnt = new Address();
        evnt.GetAddress();
    }
}