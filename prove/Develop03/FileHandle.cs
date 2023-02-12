using System;

/* Class that retrieves a list of scriptures from a file. Picks scripture randomly to be memorized. */
public class FileHandle
{
    private List<string> _scripList = new List<string>();

    // Constructor
    public FileHandle(string fileName)
    {
        string [] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string [] parts = line.Split("|");
            _scripList.Add($"{parts[0]}|{parts[1]}");
        }
    }

    //Methods
    public string RandScrip()
    {
        Random rnd = new Random();
        int index = rnd.Next(0, _scripList.Count);
        string randScrip = _scripList[index];
        return randScrip;
    }
}