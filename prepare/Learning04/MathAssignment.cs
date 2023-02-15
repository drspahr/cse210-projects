using System;

public class MathAssign : Assignment
{
    private string _textbookSec;
    private string _problems;

    // Constructor
    public MathAssign (string name, string topic, string sect, string problems) : base(name, topic)
    {
        _textbookSec = sect;
        _problems = problems;
    }

    // Method
    public string GetHomeworkList()
    {
        return $"Section {_textbookSec} Problems {_problems}";
    }
}   
