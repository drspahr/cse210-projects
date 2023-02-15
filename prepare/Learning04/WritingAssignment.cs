using System;

public class WriteAssing : Assignment
{
    private string _title;

    // Constructor
    public WriteAssing(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    // Method
    public string GetWritingInfo()
    {
        return _title;
    }
}