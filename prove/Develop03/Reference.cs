using System;

/* Class to clean up and provide format for display */
public class Reference
{
    private string _book;
    private string _chap;
    private string _vers;

    // Constructor
    public Reference()
    {

    }

    public Reference(string scrpRef)
    {
        string [] parts = scrpRef.Split(" ");
        string [] chvrs = parts[1].Split(":");
        string book = parts[0];

        if (book.Contains("-"))
        {
            _book = book.Replace("-", " ");
        }
        else
        {
            _book = book;
        }
        
        _chap = chvrs[0];
        _vers = chvrs[1];
    }

    // Method
    public string DispalyRef(string reference)
    {
       reference = $"{_book} {_chap}:{_vers}";
       return reference;
    }
}   