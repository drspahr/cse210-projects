class Outdoors : Events
{
    private string _weather;
    
    // Constructor
    public Outdoors(string title, string desc, string date, string time, string weather) : base(title, desc, date, time)
    {
        _weather = weather;
    }

    // Method
    public string GetWeather()
    {
        return _weather;
    }
}