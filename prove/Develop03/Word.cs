using System;

/* Class to pick random word from verse(s). Test to see if verse has been completely hidden */
public class Word
{
    private string _word;
    // private bool _isHidden;
    private List<string> _text = new List<string>();

    // Constructor
    public Word(string text)
    {
        Char [] delimiter = {'.', ':', ';', ',', '_', ' '};
        string [] newText = text.Split(delimiter);

        int nTextLen = newText.Count();
        for (int i =0; i < nTextLen; i++)
        {
            if (newText[i] != "")
            {
                _text.Add(newText[i]);
            }
        }
    }

    // Method
    public string RandomWord()
    {        
        Random rWord = new Random();
        int indWord = rWord.Next(0, _text.Count());

        string rtnWord = _text[indWord];
        _word = rtnWord; 
        return rtnWord;
    
    }

    public bool IsBlank()
    {
        if (_text.Count() == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}