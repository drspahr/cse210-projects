using System;
using System.Text.RegularExpressions;

/* Class and methods to load and display the scripture.*/
public class Scripture
{
    protected string _ref;
    private string _sText;
    private string _scriptString;
    private bool _allBlank = false;

    // Constructor
    public Scripture()
    {
        FileHandle file = new FileHandle("scriptures.txt");
        _scriptString = file.RandScrip();

        string [] parts = _scriptString.Split("|");
        _ref = parts[0];
        _sText = parts[1];

        Reference newRef = new Reference(_ref);
        _ref = newRef.DispalyRef(_ref);     
    }

    // Methods
    public void DisplayScript()
    {
        Console.WriteLine(_ref);
        Console.WriteLine(_sText);
    }

    public void HideWord()
    {
        Word newWord = new Word(_sText);
        _allBlank = newWord.IsBlank();

        if (_allBlank == true)
        {
            System.Environment.Exit(0);
        }
        else
        {
            
            string hidWord = newWord.RandomWord();
            string blank = "";
            foreach (char x in hidWord)
            {
                blank += "_";
            }
            
           _sText = _sText.Replace(hidWord, blank);
        }    
    }
}