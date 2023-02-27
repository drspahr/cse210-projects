class Listing : Activity
{
    private List<string> _listPrompt = new List<string>();
    private List<string> _userList = new List<string>();

    // Constructors
    public Listing(string activity, string description, int duration) : base(activity, description, duration)
    {
        string [] llines = System.IO.File.ReadAllLines("listprompts.txt");
        foreach (string line in llines)
        {
            _listPrompt.Add(line);
        }
    }

    // Methods
    public void DisplayListPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(0, _listPrompt.Count);
        string randList = _listPrompt[index];

        Console.WriteLine("Think about the following question.");
        Console.WriteLine($"------ {randList} ------");
        Console.WriteLine($"Prepare to write as many answer as possible in the next {_duration} seconds");
    }

    public void GetUser()
    {
        string usrRsp;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("--> ");
            usrRsp = Console.ReadLine();
            _userList.Add(usrRsp);
        }
    }

    public void DisplayCount()
    {
        Console.WriteLine($"You made {_userList.Count} entries");
    }
}